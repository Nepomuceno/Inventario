using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Sirius.Coletor.Base;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System;

namespace Sirius.Coletor.Dados
{
    public class Banco
    {
        private const int BATCH_SIZE = 1000;
        private const string CAMINHO_INVENTARIO = "/Inventarios.json";
        private const string CAMINHO_OPERADORES = "/Operadores.json";
        private const string CAMINHO_FILIAIS = "/Filiais.json";
        private const string CAMINHO_PRODUTOS = "/Produtos.json";
        private bool _inicializado = false;
        public bool Inicializado { get { return _inicializado; } }

        public ParametrosDeInicializacao ParametrosDeInicializacao { get; set; }


        public Colecao<Inventario> Inventarios { get; set; }

        public Colecao<Operador> Operadores { get; set; }

        public Colecao<Filial> Filiais { get; set; }

        public Colecao<Produto> Produtos { get; set; }

        public void Carregar(string caminho)
        {
            var serializer = new JsonSerializer();
            var stream = File.Open(Path.Combine(caminho, CAMINHO_INVENTARIO), FileMode.OpenOrCreate);
            var inventarios = new StreamReader(stream).ReadToEnd();
            Inventarios = JsonConvert.DeserializeObject<Colecao<Inventario>>(inventarios);
            stream.Flush();
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_OPERADORES), FileMode.OpenOrCreate);
            Operadores = serializer.Deserialize<Colecao<Operador>>(new JsonTextReader(new StreamReader(stream)));
            stream.Flush();
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_FILIAIS), FileMode.OpenOrCreate);
            Filiais = serializer.Deserialize<Colecao<Filial>>(new JsonTextReader(new StreamReader(stream)));
            stream.Flush();
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_PRODUTOS), FileMode.OpenOrCreate);
            Produtos = serializer.Deserialize<Colecao<Produto>>(new JsonTextReader(new StreamReader(stream)));
            stream.Flush();
            stream.Dispose();
            Inicialize();
        }

        public void SalvarTudo(string caminho)
        {
            Inicialize();
            var serializer = new JsonSerializer();
            var stream = File.Open(Path.Combine(caminho, CAMINHO_INVENTARIO), FileMode.OpenOrCreate);
            var textWriter = new JsonTextWriter(new StreamWriter(stream)) { Formatting = Formatting.Indented };
            serializer.Serialize(textWriter, Inventarios);
            textWriter.Flush();
            stream.Flush();
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_OPERADORES), FileMode.OpenOrCreate);
            textWriter = new JsonTextWriter(new StreamWriter(stream));
            serializer.Serialize(textWriter, Operadores);
            textWriter.Flush();
            stream.Flush();
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_FILIAIS), FileMode.OpenOrCreate);
            textWriter = new JsonTextWriter(new StreamWriter(stream));
            serializer.Serialize(textWriter, Filiais);
            textWriter.Flush();
            stream.Flush();
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_PRODUTOS), FileMode.OpenOrCreate);
            textWriter = new JsonTextWriter(new StreamWriter(stream));
            serializer.Serialize(textWriter, Produtos);
            textWriter.Flush();
            stream.Flush();
            stream.Dispose();
        }



        public void LimparBase(string filepath)
        {
            var filialsPath = Path.Combine(filepath, CAMINHO_FILIAIS);
            if (File.Exists(filialsPath))
            {
                File.Delete(filialsPath);
            }
            var operadoresPath = Path.Combine(filepath, CAMINHO_OPERADORES);
            if (File.Exists(operadoresPath))
            {
                File.Delete(operadoresPath);
            }
            var inventariosPath = Path.Combine(filepath, CAMINHO_INVENTARIO);
            if (File.Exists(inventariosPath))
            {
                File.Delete(inventariosPath);
            }
            var produtosPath = Path.Combine(filepath, CAMINHO_PRODUTOS);
            if (File.Exists(produtosPath))
            {
                File.Delete(produtosPath);
            }
        }

        private void Inicialize()
        {
            if (Inventarios == null)
            {
                Inventarios = new Colecao<Inventario>();
            }
            if (Operadores == null)
            {
                Operadores = new Colecao<Operador>();
            }
            if (Filiais == null)
            {
                Filiais = new Colecao<Filial>();
            }
            if (Produtos == null)
            {
                Produtos = new Colecao<Produto>();
            }
            ParametrosDeInicializacao = new ParametrosDeInicializacao()
            {
                LeituraLocalAposCadaItem = false,
                TipoLeitura = TipoLeitura.Multipla
            };
            _inicializado = true;
        }

        public void ImportarDados(bool importarInventarios, bool importarOperadores, bool importarFiliais, bool importarProdutos)
        {
            using (var service = new SiriusService.SiriusService())
            {
                if (importarInventarios)
                {
                    var inventariosPendentes = service.ListarInventariosPendentes();
                    this.Inventarios = JsonConvert.DeserializeObject<Colecao<Inventario>>(inventariosPendentes);
                }
                if (importarOperadores)
                {
                    var operadores = service.ListarOperadoresColetor();
                    if (!string.IsNullOrEmpty(operadores))
                    {
                        this.Operadores = JsonConvert.DeserializeObject<Colecao<Operador>>(operadores);
                    }
                }
                if (importarFiliais)
                {
                    var filiais = service.ListarFiliais();
                    this.Filiais = JsonConvert.DeserializeObject<Colecao<Filial>>(filiais);
                }
                if (importarProdutos)
                {
                    int totalProdutos;
                    bool specified;
                    service.RetornaQuantidadeProdutoCadastrados(out totalProdutos, out specified);
                    this.Produtos = new Colecao<Produto>();
                    for (int i = 0; i < (totalProdutos / BATCH_SIZE) + 1; i++)
                    {
                        var produtos = service.ListarProdutos(i, true, BATCH_SIZE, true);
                        this.Produtos.AddRange(JsonConvert.DeserializeObject<Colecao<Produto>>(produtos));
                        GC.Collect();
                    }
                }
            }
        }
    }

    public class ParametrosDeInicializacao
    {
        public TipoLeitura TipoLeitura { get; set; }
        public bool LeituraLocalAposCadaItem { get; set; }
    }

    public class Colecao<T> : List<T>
    {
    }
}

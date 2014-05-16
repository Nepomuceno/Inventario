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
        public Banco()
        {
            ParametrosDeInicializacao = new ParametrosDeInicializacao();
            Inventarios = new Colecao<Inventario>();
            Operadores = new Colecao<Operador>();
            Filiais = new Colecao<Filial>();
            Produtos = new Colecao<Produto>();
        }
        // ReSharper disable InconsistentNaming
        //Default name for file paths following MS Specs
        private const int BATCH_SIZE = 500;
        private const string CAMINHO_INVENTARIO = "\\Inventarios.json";
        private const string CAMINHO_OPERADORES = "\\Operadores.json";
        private const string CAMINHO_FILIAIS = "\\Filiais.json";
        private const string CAMINHO_PRODUTOS = "\\Produtos.json";
        private const string CAMINHO_PARAMETROS = "\\Parametros.json";
        // ReSharper restore InconsistentNaming

        public ParametrosDeInicializacao ParametrosDeInicializacao { get; set; }

        public Colecao<Inventario> Inventarios { get; set; }

        public Colecao<Operador> Operadores { get; set; }

        public Colecao<Filial> Filiais { get; set; }

        public Colecao<Produto> Produtos { get; set; }
        
        
        public void Carregar(string caminho)
        {
            var inventarios = DesserializeFromFile<Colecao<Inventario>>(PathUtil.Combine(caminho, CAMINHO_INVENTARIO));
            if (inventarios != null)
            {
                Inventarios = inventarios;
            }
            var operadores = DesserializeFromFile<Colecao<Operador>>(PathUtil.Combine(caminho, CAMINHO_OPERADORES));
            if (operadores != null)
            {
                Operadores = operadores;
            }
            var filiais = DesserializeFromFile<Colecao<Filial>>(PathUtil.Combine(caminho, CAMINHO_FILIAIS));
            if (filiais != null)
            {
                Filiais = filiais;
            }
            var produtos = DesserializeFromFile<Colecao<Produto>>(PathUtil.Combine(caminho, CAMINHO_PRODUTOS));
            if (produtos != null)
            {
                Produtos = produtos;
            }
            var parametrosDeInicializacao = DesserializeFromFile<ParametrosDeInicializacao>(PathUtil.Combine(caminho, CAMINHO_PARAMETROS));
            if (parametrosDeInicializacao != null)
            {
                ParametrosDeInicializacao = parametrosDeInicializacao;
            }
        }

        public void SalvarOperadores(string caminho)
        {
            SerializeToFile(PathUtil.Combine(caminho, CAMINHO_OPERADORES), Operadores);
        }

        public void SalvarFiliais(string caminho)
        {
            SerializeToFile(PathUtil.Combine(caminho, CAMINHO_FILIAIS), Filiais);
        }

        public void SalvarInventarios(string caminho)
        {
            SerializeToFile(PathUtil.Combine(caminho, CAMINHO_INVENTARIO), Inventarios);           
        }

        public void SalvarParametros(string caminho)
        {
            SerializeToFile(PathUtil.Combine(caminho, CAMINHO_PARAMETROS), ParametrosDeInicializacao);
        }

        public void SalvarProdutos(string caminho)
        {
            SerializeToFile(PathUtil.Combine(caminho, CAMINHO_PRODUTOS),Produtos);
        }

        private void SerializeToFile(string path, object content)
        {
            GC.Collect();
            var jsonSerializer = new JsonSerializer();
            var stream = File.Open(path, FileMode.Create);
            var textWriter = new JsonTextWriter(new StreamWriter(stream)) { Formatting = Formatting.Indented };
            jsonSerializer.Serialize(textWriter,content);
            textWriter.Flush();
            stream.Flush();
            stream.Dispose();
        }

        private T DesserializeFromFile<T>(string path)
        {
            GC.Collect();
            var stream = File.Open(path, FileMode.OpenOrCreate);
            var objects = new StreamReader(stream).ReadToEnd();
            var result = JsonConvert.DeserializeObject<T>(objects);
            stream.Flush();
            stream.Dispose();
            return result;
        }
       

        public void SalvarTudo(string caminho)
        {
            SalvarProdutos(caminho);
            SalvarFiliais(caminho);
            SalvarInventarios(caminho);
            SalvarOperadores(caminho);
            SalvarParametros(caminho);
        }

        public void LimparBase(string filepath)
        {
            var filialsPath = PathUtil.Combine(filepath, CAMINHO_FILIAIS);
            if (File.Exists(filialsPath))
            {
                File.Delete(filialsPath);
            }
            var operadoresPath = PathUtil.Combine(filepath, CAMINHO_OPERADORES);
            if (File.Exists(operadoresPath))
            {
                File.Delete(operadoresPath);
            }
            var inventariosPath = PathUtil.Combine(filepath, CAMINHO_INVENTARIO);
            if (File.Exists(inventariosPath))
            {
                File.Delete(inventariosPath);
            }
            var produtosPath = PathUtil.Combine(filepath, CAMINHO_PRODUTOS);
            if (File.Exists(produtosPath))
            {
                File.Delete(produtosPath);
            }
        }


        public void ImportarDados(bool importarInventarios, bool importarOperadores, bool importarFiliais, bool importarProdutos)
        {
            using (var service = new SiriusService.SiriusService())
            {
                if (importarInventarios)
                {
                    var inventariosPendentes = service.ListarInventariosPendentes();
                    var inventarionsNovos = JsonConvert.DeserializeObject<Colecao<Inventario>>(inventariosPendentes);
                    Inventarios.ForEach(invAtual => inventarionsNovos.RemoveAll(invNovo => invNovo.Codigo == invAtual.Codigo));
                    Inventarios.AddRange(inventarionsNovos);
                }
                if (importarOperadores)
                {
                    var operadores = service.ListarOperadoresColetor();
                    if (!string.IsNullOrEmpty(operadores))
                    {
                        Operadores = JsonConvert.DeserializeObject<Colecao<Operador>>(operadores);
                    }
                }
                if (importarFiliais)
                {
                    var filiais = service.ListarFiliais();
                    Filiais = JsonConvert.DeserializeObject<Colecao<Filial>>(filiais);
                }
                if (importarProdutos)
                {
                    int totalProdutos;
                    bool specified;
                    service.RetornaQuantidadeProdutoCadastrados(out totalProdutos, out specified);
                    Produtos = new Colecao<Produto>();
                    for (int i = 0; i < (totalProdutos / BATCH_SIZE) + 1; i++)
                    {
                        var produtos = service.ListarProdutos(i, true, BATCH_SIZE, true);
                        Produtos.AddRange(JsonConvert.DeserializeObject<Colecao<Produto>>(produtos));
                        GC.Collect();
                    }
                }
            }
        }
    }

    public class Colecao<T> : List<T>
    {
    }
}

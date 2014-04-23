using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Sirius.Coletor.Base;
using Newtonsoft.Json;

namespace Sirius.Coletor.Dados
{
    public class Banco
    {
        private const string CAMINHO_INVENTARIO = "/Inventarios.json";
        private const string CAMINHO_OPERADORES = "/Operadores.json";
        private const string CAMINHO_FILIAIS = "/Filials.json";
        private const string CAMINHO_PRODUTOS = "/Produtos.json";

        public Colecao<Inventario> Inventarios { get; set; }
        
        public Colecao<Operador> Operadores { get; set; }
        
        public Colecao<Filial> Filials { get; set; }

        public Colecao<Produto> Produtos { get; set; }

        public void Carregar(string caminho)
        {
            var serializer = new JsonSerializer();

            var stream = File.Open(Path.Combine(caminho, CAMINHO_INVENTARIO), FileMode.OpenOrCreate);
            Inventarios = serializer.Deserialize <Colecao<Inventario>>(new JsonTextReader(new StreamReader(stream)));
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_OPERADORES), FileMode.OpenOrCreate);
            Operadores = serializer.Deserialize<Colecao<Operador>>(new JsonTextReader(new StreamReader(stream)));
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_FILIAIS), FileMode.OpenOrCreate);
            Filials = serializer.Deserialize<Colecao<Filial>>(new JsonTextReader(new StreamReader(stream)));
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_PRODUTOS), FileMode.OpenOrCreate);
            Produtos = serializer.Deserialize<Colecao<Produto>>(new JsonTextReader(new StreamReader(stream)));
            stream.Dispose();
        }

        public void SalvarTudo(string caminho)
        {
            var serializer = new JsonSerializer();

            var stream = File.Open(Path.Combine(caminho, CAMINHO_INVENTARIO), FileMode.OpenOrCreate);
            serializer.Serialize(new JsonTextWriter(new StreamWriter(stream)), Inventarios);
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_OPERADORES), FileMode.OpenOrCreate);
            serializer.Serialize(new JsonTextWriter(new StreamWriter(stream)), Operadores);
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_FILIAIS), FileMode.OpenOrCreate);
            serializer.Serialize(new JsonTextWriter(new StreamWriter(stream)), Filials);
            stream.Dispose();
            stream = File.Open(Path.Combine(caminho, CAMINHO_PRODUTOS), FileMode.OpenOrCreate);
            serializer.Serialize(new JsonTextWriter(new StreamWriter(stream)), Produtos);
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
    }

    public class Colecao<T> : List<T>
    {
    }
}

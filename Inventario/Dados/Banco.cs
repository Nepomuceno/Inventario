using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Sirius.Coletor.Base;

namespace Sirius.Coletor.Dados
{
    public class Banco
    {
        private const string CAMINHO_INVENTARIO = "/Inventarios.xml";
        private const string CAMINHO_OPERADORES = "/Operadores.xml";
        private const string CAMINHO_FILIAIS = "/Filials.xml";

        public Colecao<Inventario> Inventarios { get; set; }
        
        public Colecao<Operador> Operadores { get; set; }
        
        public Colecao<Filial> Filials { get; set; }

        public void Carregar(string caminho)
        {
            var serializerInventario = new XmlSerializer(typeof(Colecao<Inventario>));
            Inventarios = serializerInventario.Deserialize(File.Open(Path.Combine(caminho,CAMINHO_INVENTARIO),FileMode.OpenOrCreate)) as Colecao<Inventario>;
            var serializerOperador = new XmlSerializer(typeof (Colecao<Operador>));
            Operadores = serializerOperador.Deserialize(File.Open(Path.Combine(caminho, CAMINHO_OPERADORES), FileMode.OpenOrCreate)) as Colecao<Operador>;
            var serializerFilials = new XmlSerializer(typeof(Colecao<Filial>));
            Filials = serializerFilials.Deserialize(File.Open(Path.Combine(caminho, CAMINHO_FILIAIS), FileMode.OpenOrCreate)) as Colecao<Filial>;
        }

        public void SalvarTudo(string caminho)
        {
            var serializerInventario = new XmlSerializer(typeof(Colecao<Inventario>));
            serializerInventario.Serialize(File.Open(Path.Combine(caminho, CAMINHO_INVENTARIO), FileMode.OpenOrCreate),
                Inventarios);
            var serializerOperadores = new XmlSerializer(typeof(Colecao<Operador>));
            serializerOperadores.Serialize(File.Open(Path.Combine(caminho, CAMINHO_OPERADORES), FileMode.OpenOrCreate),
                Inventarios);
            var serializerFiliais = new XmlSerializer(typeof(Colecao<Filial>));
            serializerFiliais.Serialize(File.Open(Path.Combine(caminho, CAMINHO_FILIAIS), FileMode.OpenOrCreate),
                Inventarios);
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
        }
    }

    public class Colecao<T> : List<T>
    {
    }
}

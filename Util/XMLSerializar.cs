using System;
using System.IO;
using System.Xml.Serialization;

namespace Util
{
    public class XMLSerializar
    {
        public void Serializar(object Tipo, string Arquivo)
        {
            StreamWriter SW = new StreamWriter(Arquivo);
            XmlSerializer xml = new XmlSerializer(Tipo.GetType());
            xml.Serialize(SW, Tipo);
            SW.Close();

        }
        public Object Deserializar(object Tipo, string Arquivo)
        {
            StreamReader SR = new StreamReader(Arquivo);
            XmlSerializer xml = new XmlSerializer(Tipo.GetType());
            Tipo = xml.Deserialize(SR);
            SR.Close();
            return Tipo;
        }

    }
}

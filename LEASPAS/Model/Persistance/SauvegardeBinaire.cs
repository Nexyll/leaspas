using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LEASPAS.Model.Persistance
{
    public class SauvegardeBinaire : ISauvegarde
    {
        public void Sauvegarder(string uri, Collection collection)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(uri, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, collection);
            stream.Close();
        }

        public Collection Charger(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            Collection container = formatter.Deserialize(stream) as Collection;
            stream.Close();

            if (container == null)
                throw new SerializationException("Cast exception");

            return container;
        }
    }
}
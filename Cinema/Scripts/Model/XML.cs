using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cinema.Scripts.Model
{
    public class XML
    {
        private const string fileName = "TitlesData.xml";

        private XmlSerializer serializer { get; set; } = new XmlSerializer(typeof(List<TitleInfo>));

        public void Serialize(List<TitleInfo> coll)
        {
            ClearFileContent();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, coll);
            }
        }

        private void ClearFileContent()
        {
            StreamWriter sr = new StreamWriter(fileName, false);
            sr.WriteLine("");
            sr.Close();
        }

        public List<TitleInfo> Deserialize()
        {
            List <TitleInfo> coll = null;
            try
            {
                using (FileStream fs = File.OpenRead(fileName))
                {
                    coll = (List<TitleInfo>)serializer.Deserialize(fs);
                }
            }
            catch (FileNotFoundException) { }
            return coll ?? (coll = new List<TitleInfo>());
        }
    }

}


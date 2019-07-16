using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrencyXml
{
    public class Serializer
    {
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            string XmlCode;
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;
            using (WebClient client = new WebClient())
            {
                XmlCode = client.DownloadString("http://resources.finance.ua/ua/public/currency-cash.xml");
            }
            Source customer = ser.Deserialize<Source>(XmlCode);

            foreach (var i in customer.Organizations.Organization)
            {
                Console.WriteLine($"{i.Currencies.C[0].Id}");
            }
            Console.WriteLine(customer.Date);

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable peopleTable = tableClient.GetTableReference("currencyesTable");

            await peopleTable.CreateIfNotExistsAsync();
            Console.ReadKey();
        }
    }
}

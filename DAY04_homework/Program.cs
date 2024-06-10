using System.Text.Json;
using System.Xml.Serialization;

namespace DAY04_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = Books.TestBooks;
            Console.WriteLine("Serialize books");
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine("..", "..", "..", "books.txt")))
            {
                XmlSerializer xmlsSerialize = new XmlSerializer(books.GetType());
                xmlsSerialize.Serialize(streamWriter, books);
            }



            Console.WriteLine("Now we deserialize");
            books = null;

            using (StreamReader streamReader = new StreamReader(Path.Combine("..", "..", "..", "books.txt")))
            {
                XmlSerializer deXml = new XmlSerializer(typeof(Book[]));
                books = (Book[])deXml.Deserialize(streamReader);
            }
            foreach (var b in books) {
                Console.WriteLine(b);
            
            }

            Console.WriteLine("Deserialization ended");
        }
    }
}

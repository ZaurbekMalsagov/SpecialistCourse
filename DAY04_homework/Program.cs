using System.Text.Json;
using System.Xml.Serialization;

namespace DAY04_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = Books.TestBooks;
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine("..", "..", "..", "books.txt")))
            {
                XmlSerializer xmlsSerialize = new XmlSerializer(books.GetType());
                xmlsSerialize.Serialize(streamWriter, books);
            }


            Console.WriteLine("Serialize books");
        }
    }
}

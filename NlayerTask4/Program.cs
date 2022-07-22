using BusinessLayer;

namespace NlayerTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            PublisherMan pm = new PublisherMan();
            foreach (var item in pm.GetAll())
            {
                Console.WriteLine("ID ve Name: " + item.publisherID + " " + item.publisherName);
            }
        }
    }
}
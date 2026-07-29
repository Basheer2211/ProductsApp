using ProductApp.Factories;
using ProductApp.Readers.Classes;
using ProductApp.Readers.Interfaces;
using ProductApp.Repositories.classes;
 using ProductApp.Services.Classes;
using ProductApp.Writers.Classes;
using ProductApp.Writers.Interfaces;

namespace ProductApp;

class Program
{
    static void Main(string[] args)
    {
        var repository = new ProductRepository(new ProductDataStore());

        var validator = new ProductValidator(repository);

        var service = new ProductService(
            repository,
            validator
        );

        Console.WriteLine("Choose input method:");
        Console.WriteLine("1. Console");
        Console.WriteLine("2. CSV");

        var inputChoice = Console.ReadLine();

        IProductReader reader;


        if (inputChoice == "1")
        {
            reader = ProductReaderFactory.Create("console");
        }
        else if (inputChoice == "2")
        {
            Console.Write("Enter CSV file path: ");
            var path = Console.ReadLine();

            reader = ProductReaderFactory.Create("csv", path);
        }
        else
        {
            throw new ArgumentException("Invalid input choice");
        }


        service.ImportProducts(reader);



        Console.WriteLine("Choose output method:");
        Console.WriteLine("1. Console");
        Console.WriteLine("2. JSON");

        var outputChoice = Console.ReadLine();

        IProductWriter writer;


        if (outputChoice == "1")
        {
            writer = ProductWriterFactory.Create("console");
        }
        else if (outputChoice == "2")
        {
            Console.Write("Enter JSON output path: ");
            var path = Console.ReadLine();

            writer = ProductWriterFactory.Create("json", path);
        }
        else
        {
            throw new ArgumentException("Invalid output choice");
        }


        service.ExportProducts(writer);
    }
}
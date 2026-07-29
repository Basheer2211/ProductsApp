using ProductApp.Factories;
using ProductApp.Repositories.classes;
 using ProductApp.Services.Classes;
 
namespace ProductApp;

class Program
{
    static void Main(string[] args)
    {
        var repository = new ProductRepository();

        var validator = new ProductValidator();

        var service = new ProductService(
            repository,
            validator
        );


        var reader = ProductReaderFactory.Create("csv");

        service.ImportProducts(reader);

        var writer = ProductWriterFactory.Create("json");

        service.ExportProducts(writer);



        Console.WriteLine("Done");
    }
}
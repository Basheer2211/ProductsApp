using ProductApp.Readers.Interfaces;
using ProductApp.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Services.Interfaces
{
    public interface IProductService
    {
        void ImportProducts(IProductReader reader);
        void ExportProducts(IProductWriter writer);

    }
}

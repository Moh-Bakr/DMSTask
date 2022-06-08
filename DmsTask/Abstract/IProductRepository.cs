using DmsTask.Models;
using DmsTask.Provider;
using Microsoft.EntityFrameworkCore;

namespace DmsTask.Abstract
{
    public interface IProductRepository
    {
        public void AddPrinter(PrinterModel model);
        public void AddLaptop(LaptopModel model);
        public IEnumerable<LaptopModel> GetAlLaptops();
        public PrinterModel GetPrinter(int id);
        public  void UpdatePrinter(PrinterModel model);
        public  void UpdateLabtop(LaptopModel model);
        public LaptopModel GetLaptop(int id);
        public void complete();
    }
}
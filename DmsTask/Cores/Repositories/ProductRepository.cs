using AutoMapper;
using DmsTask.Abstract;
using DmsTask.Models;
using DmsTask.Provider;

namespace DmsTask.Cores.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private ItContext _context;
        private IMapper _mapper;
        public ProductRepository(ItContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddPrinter(PrinterModel model)
        {
            model.Category = type.Printer;
            _context.Printers.Add(_mapper.Map<PrinterModel, Printer>(model));
            
        }

        public void AddLaptop(LaptopModel model)
        {
            model.Category = type.Laptop;
            _context.Laptops.Add(_mapper.Map<LaptopModel, Laptop>(model));

        }

        public IEnumerable<LaptopModel> GetAlLaptops()
        {
            var allPrinter = _context.Printers.AsEnumerable();
            var allLaptops = _context.Laptops.AsEnumerable();
            IEnumerable<LaptopModel> allProducts = new Queue<LaptopModel>();
            foreach (var model in allPrinter)
            {
                var product = new Laptop(){DeviceName = model.DeviceName, Id = model.Id, Category = model.Category};
                allProducts= allProducts.Append(_mapper.Map<Laptop,LaptopModel>(product));

            }   foreach (var model in allLaptops)
            {
                allProducts= allProducts.Append(_mapper.Map<Laptop,LaptopModel>(model));

            }

            return allProducts;
        }

        public PrinterModel GetPrinter(int id)
        {
            return _mapper.Map<Printer,PrinterModel>(_context.Printers.SingleOrDefault(e => e.Id == id));
        }

        public void UpdatePrinter(PrinterModel model)
        {
            model.Category = type.Printer;
            _context.Update(_mapper.Map<PrinterModel, Printer>(model));
            
        }

        public void UpdateLabtop(LaptopModel model)
        {
            model.Category = type.Laptop;
            _context.Update(_mapper.Map<LaptopModel,Laptop>(model));
        }

        public LaptopModel GetLaptop(int id)
        {
            return _mapper.Map<Laptop, LaptopModel>(_context.Laptops.SingleOrDefault(e => e.Id == id));
        }

        public void complete()
        {
            _context.SaveChanges();
        }
    }
}

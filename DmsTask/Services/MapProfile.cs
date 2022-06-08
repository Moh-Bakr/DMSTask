using AutoMapper;
using DmsTask.Models;
using DmsTask.Provider;

namespace DmsTask.Services
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Printer, PrinterModel>().ReverseMap();
            CreateMap<Laptop, LaptopModel>().ReverseMap();
        }
    }
}

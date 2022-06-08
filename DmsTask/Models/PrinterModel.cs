using DmsTask.Provider;

namespace DmsTask.Models
{
    public class PrinterModel:ProductInformation
    {
        public int Id { set; get; }
        public string Ip { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}

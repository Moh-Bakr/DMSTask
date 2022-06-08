using System.ComponentModel.DataAnnotations;

namespace DmsTask.Provider
{
    public class Printer: ProductInformation
    {
        public Printer(int id, string ip, string color, string brand)
        {
            Id = id;
            Ip = ip;
            Color = color;
            Brand = brand;
        }

        public Printer()
        {
            
        }

        public int Id { get; set; }
        [Required]
        public string Ip { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}

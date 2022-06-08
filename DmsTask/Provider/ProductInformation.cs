namespace DmsTask.Provider
{
    public class ProductInformation
    {
       

        public string DeviceName { get; set; }
        public string SerialNo { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string Memo { get; set; }
        public type Category { get; set; }
    }

    public enum type
    {
        Laptop,
        Switch,
        Printer
    };
}

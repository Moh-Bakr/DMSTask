namespace DmsTask.Provider
{
    public class Laptop : ProductInformation
    {
        public int Id { get; set; }   
        public string Processor { get; set; }

        public string HD { get; set; }

        public string Ram { get; set; }

        public string Display { get; set; }

        public string IP { get; set; }

        public string Brand { get; set; }
        public string User { get; set; }
    }
}

namespace PresentationLayer.VMs.Product
{
    public class AllProducts
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int StockQuantity { get; set; }
        public string Images { get; set; } = string.Empty;


    }
}

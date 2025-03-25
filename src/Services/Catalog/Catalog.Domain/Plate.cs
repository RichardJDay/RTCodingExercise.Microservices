namespace Catalog.Domain
{
    public class Plate
    {
        public Guid Id { get; set; }

        public string? Registration { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice => SalePrice + (PurchasePrice / 100 * 20);

        public string? Letters { get; set; }

        public int Numbers { get; set; }
    }
}
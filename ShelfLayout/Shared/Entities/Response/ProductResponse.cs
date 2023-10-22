namespace ShelfLayout.Shared.Entities.Response
{
    public class ProductResponse
    {
        public string JanCode { get; set; }

        public string Name { get; set; }

        public decimal Volume { get; set; }

        public decimal SizeX { get; set; }

        public decimal SizeY { get; set; }

        public decimal SizeZ { get; set; }

        public string ImageUrl { get; set; }
    }
}

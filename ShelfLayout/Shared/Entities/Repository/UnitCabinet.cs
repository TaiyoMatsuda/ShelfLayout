namespace ShelfLayout.Shared.Entities.Repository
{
    public class UnitCabinet
    {
        public int CabinetId { get; set; }

        public int StoreId { get; set; }

        public decimal CabinetPositionX { get; set; }

        public decimal CabinetPositionY { get; set; }

        public decimal CabinetPositionZ { get; set; }

        public decimal CabinetSizeX { get; set; }

        public decimal CabinetSizeY { get; set; }

        public decimal CabinetSizeZ { get; set; }

        public int CabinetRowId { get; set; }

        public short RowNum { get; set; }

        public decimal RowPositionZ { get; set; }

        public decimal RowSizeZ { get; set; }

        public int CabinetRowLaneId { get; set; }

        public short LaneNum { get; set; }

        public short Quantity { get; set; }

        public decimal CabinetRowLanePositionX { get; set; }

        public string JanCode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        public decimal ProductVolume { get; set; }

        public decimal ProductSizeX { get; set; }

        public decimal ProductSizeY { get; set; }

        public decimal ProductSizeZ { get; set; }

        public string ProductImageUrl { get; set; } = string.Empty;
    }
}

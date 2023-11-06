namespace ShelfLayout.Shared.Entities.View.Shelf
{
    public class CabinetRowView
    {
        public int Id { get; set; }

        public short RowNum { get; set; }

        public decimal PositionZ { get; set; }

        public decimal SizeZ { get; set; }

        public List<CabinetRowLaneView> CabinetLanes { get; set; } = new List<CabinetRowLaneView>();
    }
}

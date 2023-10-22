namespace ShelfLayout.Shared.Entities.Repository
{
    public class CabinetRowLane
    {
        public int Id { get; set; }

        public int CabinetRowId { get; set; }

        public short LaneNum { get; set; }

        public string JanCode { get; set; }
        public short Quantity { get; set; }

        public decimal PositionX { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }
    }
}

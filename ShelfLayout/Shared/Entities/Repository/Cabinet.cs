namespace ShelfLayout.Shared.Entities.Repository
{
    public class Cabinet
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public decimal PositionX { get; set; }

        public decimal PositionY { get; set; }

        public decimal PositionZ { get; set; }

        public decimal SizeX { get; set; }

        public decimal SizeY { get; set; }

        public decimal SizeZ { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public List<CabinetRow> CabinetRows { get; set; }
    }
}

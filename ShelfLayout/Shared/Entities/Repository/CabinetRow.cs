using ShelfLayout.Shared.Entities.View.Shelf;

namespace ShelfLayout.Shared.Entities.Repository
{
    public class CabinetRow
    {
        public int Id { get; set; }

        public int CabinetId { get; set; }

        public short RowNum { get; set; }

        public decimal PositionZ { get; set; }

        public decimal SizeZ { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public List<CabinetRowLane> CabinetRows { get; set; }
    }
}

using ShelfLayout.Shared.Entities.View.Shelf;

namespace ShelfLayout.Shared.Entities.View.ShelfLayout
{
    public class CabinetView
    {
        public int Id { get; set; }

        public decimal PositionX { get; set; }

        public decimal PositionY { get; set; }

        public decimal PositionZ { get; set; }

        public List<LaneView> Lanes { get; set; } = new List<LaneView>();
    }
}

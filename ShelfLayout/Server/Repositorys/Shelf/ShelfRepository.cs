using Dapper;
using ShelfLayout.Server.Infrastructure;
using ShelfLayout.Shared.Entities.Repository;

namespace ShelfLayout.Server.Repositorys.Shelf
{
    public class ShelfRepository: IShelfRepository
    {
        private readonly DapperDbContext _dbContext;

        public ShelfRepository(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UnitCabinet>> GetCabinet(int storeId, int cabinetId)
        {
            var result = new List<UnitCabinet>();
            using (var connection = _dbContext.CreateConnection())
            {
                await connection.OpenAsync();

                var sql = @"
                    SELECT 
                        ca.id AS CabinetId,
                        ca.store_id As StoreId,
                        ca.position_x AS CabinetPositionX,
                        ca.position_y As CabinetPositionY,
                        ca.position_z AS CabinetPositionZ,
                        ca.size_x As CabinetSizeX,
                        ca.size_y AS CabinetSizeY,
                        ca.size_z As CabinetSizeZ,
                        cr.id AS CabinetRowId,
                        cr.row_num As RowNum,
                        cr.position_z AS RowPositionZ,
                        cr.size_z As RowSizeZ,
                        crl.id AS CabinetRowLaneId,
                        crl.lane_num As LaneNum,
                        crl.quantity As Quantity,
                        crl.position_x AS CabinetRowLanePositionX,
                        pr.jan_code AS JanCode,
                        pr.name AS ProductName,
                        pr.volume AS ProductVolume,
                        pr.size_x AS ProductSizeX,
                        pr.size_y AS ProductSizeY,
                        pr.size_z AS ProductSizeZ,
                        pr.image_url AS ProductImageUrl
                    FROM Cabinet ca
                    INNER JOIN CabinetRow cr ON ca.id = cr.cabinet_id
                    INNER JOIN CabinetRowLane crl ON cr.id = crl.cabinet_row_id
                    INNER JOIN Product pr ON pr.jan_code = crl.jan_code
                    WHERE
                        ca.Disabled = 0
                        AND cr.Disabled = 0
                        AND crl.Disabled = 0
                        AND pr.Disabled = 0
                        AND ca.store_id = @store_id
                        AND ca.id = @cabinet_id;
                ";

                var queryResult = await connection.QueryAsync<UnitCabinet>(sql, 
                    new { store_id = storeId, cabinet_id = cabinetId });
                result = queryResult.ToList();

                await connection.CloseAsync();
            }

            return result;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Shared.Entities.Response.Shelf;
using Microsoft.Data.SqlClient;
using ShelfLayout.Server.Infrastructure;
using Dapper;
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

        public async Task<List<Cabinet>> GetCabinet()
        {
            List<Cabinet> products = null;
            using (var connection = _dbContext.CreateConnection())
            {
                try
                {

                    await connection.OpenAsync();
                }
                catch(Exception ex)
                {

                }

                var sql = @"
                    SELECT * FROM Cabinet ca
                    LEFT JOIN CabinetRow cr ON ca.id = cr.cabinet_id
                    LEFT JOIN CabinetRowLane crl ON cr.id = crl.cabinet_row_id
                ";
                //DB接続

                products = (await connection.QueryAsync<Cabinet, List<CabinetRow>, List<CabinetRowLane>, Cabinet>(
                    sql,
                    (cabinet, cabinetRows, cabinetRowLanes) =>
                    {
                        if (cabinetRows != null && cabinetRows.Count > 0)
                        {
                            cabinet.CabinetRows = cabinetRows;

                            foreach (var row in cabinet.CabinetRows)
                            {
                                if (cabinetRowLanes != null && cabinetRowLanes.Count > 0)
                                {
                                    row.CabinetRows = cabinetRowLanes;
                                }
                            }
                        }
                        return cabinet;
                    },
                    splitOn: "id, id"
                )).ToList();

                await connection.CloseAsync();
            }

            return products;
        }
    }
}

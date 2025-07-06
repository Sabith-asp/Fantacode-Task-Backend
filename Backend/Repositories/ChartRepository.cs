using Backend.DTOs;

namespace Backend.Repositories
{
    public class ChartRepository:IChartRepository
    {
        public async  Task<List<TicketStatusDto>> GetTicketStatusData()
        {
            return new List<TicketStatusDto>
        {
            new TicketStatusDto { Status = "Open", Count = 30 },
            new TicketStatusDto { Status = "In Progress", Count = 20 },
            new TicketStatusDto { Status = "Resolved", Count = 50 },
            new TicketStatusDto { Status = "Closed", Count = 40 }
        };
        }

        public async Task<List<SalesCategoryDto>> GetSalesCategoryData()
        {
            return new List<SalesCategoryDto>
        {
            new SalesCategoryDto { Category = "Electronics", Value = 400 },
            new SalesCategoryDto { Category = "Clothing", Value = 300 },
            new SalesCategoryDto { Category = "Books", Value = 200 },
            new SalesCategoryDto { Category = "Others", Value = 100 }
        };
        }
    }
}

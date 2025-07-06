using Backend.DTOs;

namespace Backend.Repositories
{
    public interface IChartRepository
    {
        Task<List<SalesCategoryDto>> GetSalesCategoryData();
        Task<List<TicketStatusDto>> GetTicketStatusData();
    }
}

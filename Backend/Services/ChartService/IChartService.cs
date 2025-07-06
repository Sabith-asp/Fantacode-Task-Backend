using Backend.DTOs;

namespace Backend.Services.ChartService
{
    public interface IChartService
    {
        Task<ResponseDto<List<SalesCategoryDto>>> GetSalesCategoryChart();
        Task<ResponseDto<List<TicketStatusDto>>> GetTicketStatusChart();
    }
}

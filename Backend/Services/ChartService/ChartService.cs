using Backend.DTOs;
using Backend.Repositories;

namespace Backend.Services.ChartService
{
    public class ChartService : IChartService
    {
        private readonly IChartRepository _chartRepo;

        public ChartService(IChartRepository chartRepo)
        {
            _chartRepo = chartRepo;
        }

        public async Task<ResponseDto<List<TicketStatusDto>>> GetTicketStatusChart()
        {
            try
            {
                var data = await _chartRepo.GetTicketStatusData();
                return new ResponseDto<List<TicketStatusDto>>
                {
                    Data = data,
                    Message = "Ticket status chart fetched successfully",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<List<TicketStatusDto>>
                {
                    Data = null,
                    Message = $"Error: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ResponseDto<List<SalesCategoryDto>>> GetSalesCategoryChart()
        {
            try
            {
                var data = await _chartRepo.GetSalesCategoryData();
                return new ResponseDto<List<SalesCategoryDto>>
                {
                    Data = data,
                    Message = "Sales category chart fetched successfully",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<List<SalesCategoryDto>>
                {
                    Data = null,
                    Message = $"Error: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}

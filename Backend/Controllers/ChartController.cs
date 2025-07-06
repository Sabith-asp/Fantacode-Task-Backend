using Backend.DTOs;
using Backend.Services.ChartService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IChartService chartService;

        public ChartController(IChartService _chartService)
        {
            chartService = _chartService;
        }
        [Authorize]
        [HttpGet("ticket-status")]
        public async Task<IActionResult> GetTicketStatus()
        {
            var response = await chartService.GetTicketStatusChart();
            return StatusCode(response.StatusCode,response);
        }
        [Authorize]

        [HttpGet("sales-category")]
        public async Task<IActionResult> GetSalesCategory()
        {
            var response =await chartService.GetSalesCategoryChart();
            return StatusCode(response.StatusCode, response);
        }
    }
}

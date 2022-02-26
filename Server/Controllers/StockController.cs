using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Stock_Portfolio.Shared;

namespace Stock_Portfolio.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StockController : ControllerBase
{
    HttpClient client = new HttpClient();
    dynamic? data;
    private Stock? Stock { get; set; }

    [HttpGet("{symbol}")]
    public async Task<ActionResult<Stock>> GetStockAsync(string? symbol)
    {
        try
        {
            string url = $"https://cloud.iexapis.com/stable/stock/{symbol}/quote?token=pk_390d6e1502f74704a024a370ee96ed0b";
            string response = await client.GetStringAsync(url);
            data = JsonConvert.DeserializeObject<dynamic>(response);
            Stock = new Stock()
            {
                CompanyName = data["companyName"],
                Symbol = data["symbol"],
                Currency = data["currency"],
                High = data["high"],
                Low = data["low"],
                LatestPrice = data["latestPrice"]
            };
        }
        catch(Exception)
        {  
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
        }

        return Stock;
    }
}

//     @* Intra Day  *@
// @* https://cloud.iexapis.com/stable/stock/BAC/intraday-prices?token=YOUR_TOKEN_HERE&chartLast=20  *@

// @* https://cloud.iexapis.com/stable/stock/FB/chart/date/20191107?token=YOUR_TOKEN_HERE  *@
namespace Stock_Portfolio.Shared;
public class Stock
{
    public int Id { get; set; }
    public string? CompanyName { get; set; }
    public string? Symbol { get; set; }
    public string? Currency { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal LatestPrice { get; set; }
}


//     public int avgTotalVolume { get; set; }
//     public string? calculationPrice { get; set; }
//     public decimal change { get; set; }
//     public decimal changePercent { get; set; }
//     public string? close { get; set; }
//     public string? closeSource{ get; set; }
//     public DateTime closeTime { get; set; }
//     public string? companyName { get; set; }
//     public string? currency { get; set; }
//     public decimal delayedPrice { get; set; }
//     public DateTime delayedPriceTime { get; set; }
//     public decimal extendedChange { get; set; }
//     public decimal extendedChangePercent { get; set; }
//     public decimal extendedPrice { get; set; }
//     public DateTime extendedPriceTime { get; set; }
//     public decimal high { get; set; }
//     public string? highSource { get; set; }
//     public DateTime highTime { get; set; }
//     public decimal iexAskPrice { get; set; }
//     public decimal iexAskSize { get; set; }
//     public decimal iexBidPrice { get; set; }
//     public decimal iexBidSize { get; set; }
//     public decimal iexClose { get; set; }
//     public decimal iexCloseTime { get; set; }
//     public DateTime iexLastUpdated { get; set; }
//     public decimal iexMarketPercent { get; set; }
//     public string? iexOpen { get; set; }
//     public DateTime iexOpenTime { get; set; }
//     public decimal iexRealtimePrice { get; set; }
//     public decimal iexRealtimeSize { get; set; }
//     public decimal iexVolume { get; set; }
//     public DateTime lastTradeTime { get; set; }
//     public decimal latestPrice { get; set; }
//     public string? latestSource { get; set; }
//     public DateTime latestTime { get; set; }
//     public string? latestUpdate { get; set; }
//     public string? latestVolume { get; set; }
//     public decimal low { get; set; }
//     public string? lowSource { get; set; }
//     public DateTime lowTime { get; set; }
//     public string? marketCap { get; set; }
//     public decimal oddLotDelayedPrice { get; set; }
//     public DateTime oddLotDelayedPriceTime { get; set; }
//     public decimal open { get; set; }
//     public DateTime openTime { get; set; }
//     public string? openSource { get; set; }
//     public decimal peRatio { get; set; }
//     public decimal previousClose { get; set; }
//     public decimal previousVolume { get; set; }
//     public string? primaryExchange { get; set; }
//     public string? symbol { get; set; }
//     public int volume { get; set; }
//     public decimal week52High { get; set; }
//     public decimal week52Low { get; set; }
//     public decimal ytdChange { get; set; }
//     public bool isUSMarketOpen { get; set; }
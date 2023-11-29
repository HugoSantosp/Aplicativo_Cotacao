using Newtonsoft.Json;



namespace Aplicativo_Cotações
{
    public class Currency
    {
        [JsonProperty(PropertyName = "buy")]
        public decimal BuyCoin { get; set; }
    }
}

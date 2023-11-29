using Newtonsoft.Json;


namespace Aplicativo_Cotações
{
    internal class Market
    {
        public Market() { 
            this.Currency = new Currency();
        }
        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}

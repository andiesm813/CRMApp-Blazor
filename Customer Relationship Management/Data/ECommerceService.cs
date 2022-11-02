using System.Net.Http.Json;

namespace Customer_Relationship_Management.ECommerce
{
    public class ECommerceService
    {
        private readonly HttpClient http;

        public ECommerceService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<RevenueType[]?> GetRevenue()
        {
            return await this.http.GetFromJsonAsync<RevenueType[]>("https://excel2json.io/api/share/03e74dde-d2e1-4fee-437d-08da496bf5f2");
        }
    }
}
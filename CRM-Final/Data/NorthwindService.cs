using System.Net.Http.Json;

namespace CRM_Final.Northwind
{
    public class NorthwindService
    {
        private readonly HttpClient http;

        public NorthwindService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<CustomersType[]?> GetCustomers()
        {
            return await http.GetFromJsonAsync<CustomersType[]>("/static-data/northwind-customers.json");
        }
    }
}
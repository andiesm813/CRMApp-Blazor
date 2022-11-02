using System.Net.Http.Json;

namespace Customer_Relationship_Management.CRMApp
{
    public class CRMAppService
    {
        private readonly HttpClient http;

        public CRMAppService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<MeetingsTasksType[]?> GetMeetingsTasks()
        {
            return await this.http.GetFromJsonAsync<MeetingsTasksType[]>("https://excel2json.io/api/share/2fd4ecd6-da6c-4e37-e666-08dab79fa5b4");
        }
    }
}
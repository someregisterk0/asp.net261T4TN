using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CoronaRepository
    {
        public async Task<string> GetCoronas()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://corona.lmao.ninja");
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage responseMessage = await client.GetAsync("/v2/countries?fbclid=IwAR3pYzhFm8C3HWjy0sCIgYXxi0O2pm-X6Vq8BcmK_-ZDxfWTtG7QgVrjXJg");
                if (responseMessage.IsSuccessStatusCode)
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }
                return null;
            }
        }
    }
}

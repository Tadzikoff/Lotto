using Lotto.Models;
using Lotto.Services.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lotto.Services.API
{
    public class APILottoNumberService : ILottoResultsServices
    {
        public async Task<LottoResults> GetLottoResults()
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = "http://serwis.mobilotto.pl/mapi_v6/index.php?json=getGames";

                HttpResponseMessage apiResponse = await client.GetAsync(requestUri);

                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                var apiResults = JsonSerializer.Deserialize<APILottoResults>(jsonResponse, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

                return new LottoResults(apiResults);
            }
        }

        
    }
}

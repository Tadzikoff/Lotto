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
        public async Task<IEnumerable<LottoResults>> GetLottoResults(int amountOfLottoNumbers)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = "http://serwis.mobilotto.pl/mapi_v6/index.php?json=getGames";

               HttpResponseMessage apiResponse = await client.GetAsync(requestUri);

                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                List<APILottoResults> apiResults = JsonSerializer.Deserialize<List<APILottoResults>>(jsonResponse, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

                return apiResults.Take(amountOfLottoNumbers).Select(apiResults => new LottoResults()
                {
                    LottoNumbers = apiResults.numerki

                    //LottoDate = apiResults.data_losowania

                });

            }
        }

        
    }
}

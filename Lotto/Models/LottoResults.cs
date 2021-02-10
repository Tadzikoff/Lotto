using Lotto.Services.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotto.Models
{
    public class LottoResults
    {
        public LottoResults(APILottoResults apiResults)
        {
            LottoNumbers = apiResults.Lotto.numerki.Split(",").Select(x=> Int32.Parse(x)).ToArray(); 
        }
        public Int32[] LottoNumbers { get; set; }
        
        public DateTime LottoDate { get; set; }
    }
}

using Lotto.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Services
{
   public interface ILottoResultsServices
    {
        Task<IEnumerable<LottoResults>> GetLottoResults(int amountOfLottoNumbers);

    }
}

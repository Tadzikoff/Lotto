using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto.Services.API.Models
{
    public class APILottoResults
    {
        public Wyniki Lotto { get; set; }
        public Wyniki LottoPlus { get; set; }
        public WynikiJoker Joker { get; set; }
    }

    public class Wyniki
    {
        public string numerki { get; set; }
        public string num_losowania { get; set; }
        public string data_losowania { get; set; }
        public string superszansa_id { get; set; }
    }


    public class WynikiJoker : Wyniki
    {
        public string joker { get; set; }
    }
}

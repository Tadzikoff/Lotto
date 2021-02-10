using Lotto.Services.API;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lotto
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override async void OnStartup(StartupEventArgs e)
        {
            APILottoNumberService lottoNumberService = new APILottoNumberService();

            var result = await lottoNumberService.GetLottoResults();

            base.OnStartup(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface ICurrencyPairBll
    {

        CurrencyPairModel Save(CurrencyPairModel model);

        CurrencyPairModel GetById(Guid productId);

        IEnumerable<CurrencyPairModel> GetAll();

            
    }
}
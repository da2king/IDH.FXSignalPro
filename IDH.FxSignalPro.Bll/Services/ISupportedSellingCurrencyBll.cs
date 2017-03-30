using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface ISupportedSellingCurrencyBll
    {

        SupportedSellingCurrencyModel Save(SupportedSellingCurrencyModel model);

        SupportedSellingCurrencyModel GetById(Guid productId);

        IEnumerable<SupportedSellingCurrencyModel> GetAll();

            
    }
}
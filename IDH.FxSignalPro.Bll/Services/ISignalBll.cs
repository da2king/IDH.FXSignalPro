using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface ISignalBll
    {

        SignalModel Save(SignalModel model);

        SignalModel GetById(Guid productId);

        IEnumerable<SignalModel> GetAll();

        IEnumerable<SignalModel> GetByCurrencyPairId(Guid currencypairid);
                                  
                                   IEnumerable<SignalModel> GetBySellerProfileId(Guid sellerprofileid);
                                  
                                   IEnumerable<SignalModel> GetBySupportedSellingCurrencyId(Guid supportedsellingcurrencyid);
                                  
                                   IEnumerable<SignalModel> GetByTimeFrameId(Guid timeframeid);
                                  
                                       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface ISellerProfileBll
    {

        SellerProfileModel Save(SellerProfileModel model);

        SellerProfileModel GetById(Guid productId);

        IEnumerable<SellerProfileModel> GetAll();

            
    }
}
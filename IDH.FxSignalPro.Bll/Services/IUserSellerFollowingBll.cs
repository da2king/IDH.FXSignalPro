using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface IUserSellerFollowingBll
    {

        UserSellerFollowingModel Save(UserSellerFollowingModel model);

        UserSellerFollowingModel GetById(Guid productId);

        IEnumerable<UserSellerFollowingModel> GetAll();

        IEnumerable<UserSellerFollowingModel> GetBySellerProfileId(Guid sellerprofileid);
                                  
                                   IEnumerable<UserSellerFollowingModel> GetByUserId(Guid userid);
                                  
                                       
    }
}
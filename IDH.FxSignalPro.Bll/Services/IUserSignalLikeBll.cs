using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface IUserSignalLikeBll
    {

        UserSignalLikeModel Save(UserSignalLikeModel model);

        UserSignalLikeModel GetById(Guid productId);

        IEnumerable<UserSignalLikeModel> GetAll();

        IEnumerable<UserSignalLikeModel> GetBySignalId(Guid signalid);
                                  
                                   IEnumerable<UserSignalLikeModel> GetByUserId(Guid userid);
                                  
                                       
    }
}
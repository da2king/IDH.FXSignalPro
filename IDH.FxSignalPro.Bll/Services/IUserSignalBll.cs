using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface IUserSignalBll
    {

        UserSignalModel Save(UserSignalModel model);

        UserSignalModel GetById(Guid productId);

        IEnumerable<UserSignalModel> GetAll();

        IEnumerable<UserSignalModel> GetBySignalId(Guid signalid);
                                  
                                   IEnumerable<UserSignalModel> GetByUserId(Guid userid);
                                  
                                       
    }
}
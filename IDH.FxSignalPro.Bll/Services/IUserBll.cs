using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface IUserBll
    {

        UserModel Save(UserModel model);

        UserModel GetById(Guid productId);

        IEnumerable<UserModel> GetAll();

            
    }
}
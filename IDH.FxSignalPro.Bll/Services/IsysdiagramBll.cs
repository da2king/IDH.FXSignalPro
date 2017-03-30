using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface IsysdiagramBll
    {

        sysdiagramModel Save(sysdiagramModel model);

        sysdiagramModel GetById(Guid productId);

        IEnumerable<sysdiagramModel> GetAll();

            
    }
}
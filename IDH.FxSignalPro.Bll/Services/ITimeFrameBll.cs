using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface ITimeFrameBll
    {

        TimeFrameModel Save(TimeFrameModel model);

        TimeFrameModel GetById(Guid productId);

        IEnumerable<TimeFrameModel> GetAll();

            
    }
}
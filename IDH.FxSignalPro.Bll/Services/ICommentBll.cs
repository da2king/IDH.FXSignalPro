using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Models;
namespace IDH.FxSignalPro.Bll.Services
{
    public  interface ICommentBll
    {

        CommentModel Save(CommentModel model);

        CommentModel GetById(Guid productId);

        IEnumerable<CommentModel> GetAll();

        IEnumerable<CommentModel> GetBySignalId(Guid signalid);
                                  
                                   IEnumerable<CommentModel> GetByUserId(Guid userid);
                                  
                                       
    }
}
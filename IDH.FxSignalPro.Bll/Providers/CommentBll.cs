using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDH.FxSignalPro.Bll.Services;
using IDH.FxSignalPro.Data;
using IDH.FxSignalPro.Models;
using IDH.Frameworks.Bll.Providers;
using IDH.Frameworks.Repository;
namespace IDH.FxSignalPro.Bll.Providers
{
    public  class CommentBll:BLLBaseGetAndPost<Comment, CommentModel, CommentModel>,ICommentBll
    {
        private Repository<Signal> _signalDal;
        private Repository<User> _userDal;
        private Repository<Comment> _commentDal;
        public CommentBll(Repository<Signal> signalDal,Repository<User> userDal,Repository<Comment> commentDal)
        {
            _signalDal = signalDal;

            _userDal = userDal;

            _commentDal = commentDal;

            
              
        }
         
       public override Comment EntityLogic(Comment coreObject, CommentModel model)
        {
            return _commentDal.Save(coreObject);
        }

       public override Comment ProcessAGet(System.Linq.Expressions.Expression<Func<Comment, bool>> condition)
       {
           return _commentDal.Get(condition);
       }

       public override IEnumerable<Comment> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<Comment, bool>> condition)
       {
           return _commentDal.GetQueryable(condition).ToList();
       }

       public override Comment ToEntity(CommentModel modelObject)
       {
           var entity = default(Comment);

           if (modelObject.CommentId == Guid.Empty)
           {
               entity = new Comment();
               entity.CommentId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _commentDal.Get(a => a.CommentId == modelObject.CommentId);

           }

            //todo: assign the rest of the fields here
            entity.UserId = modelObject.UserId;
                entity.SignalId = modelObject.SignalId;
                entity.Message = modelObject.Message;
                entity.Created = modelObject.Created;
                entity.Deleted = modelObject.Deleted;
                entity.IsPublished = modelObject.IsPublished;
                entity.IsPreSaleComment = modelObject.IsPreSaleComment;
                

           return entity;
       }

       public override CommentModel ToModel(Comment coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new CommentModel();

            //todo:Assign all properties below.
               model.CommentId = coreObject.CommentId;
                model.UserId = coreObject.UserId;
                model.SignalId = coreObject.SignalId;
                model.Message = coreObject.Message;
                model.Created = coreObject.Created;
                model.Deleted = coreObject.Deleted;
                model.IsPublished = coreObject.IsPublished;
                model.IsPreSaleComment = coreObject.IsPreSaleComment;
                
           return model;
       }

       public override List<string> Validate(CommentModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public CommentModel Save(CommentModel commentModel)
       {
           return ProcessAPost(commentModel);
       }

       public CommentModel GetById(Guid commentid)
       {
           return Get(a => a.CommentId == commentid);
       }

       public IEnumerable<CommentModel> GetAll()
       {
           return GetEnumerable(a => true);
       }

       public IEnumerable<CommentModel> GetBySignalId(Guid signalid)
       {
           return GetEnumerable(a => a.SignalId == signalid);
       }
       public IEnumerable<CommentModel> GetByUserId(Guid userid)
       {
           return GetEnumerable(a => a.UserId == userid);
       }    
    }
}
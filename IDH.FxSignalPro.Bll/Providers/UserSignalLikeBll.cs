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
    public  class UserSignalLikeBll:BLLBaseGetAndPost<UserSignalLike, UserSignalLikeModel, UserSignalLikeModel>,IUserSignalLikeBll
    {
        private Repository<Signal> _signalDal;
        private Repository<User> _userDal;
        private Repository<UserSignalLike> _usersignallikeDal;
        public UserSignalLikeBll(Repository<Signal> signalDal,Repository<User> userDal,Repository<UserSignalLike> usersignallikeDal)
        {
            _signalDal = signalDal;

            _userDal = userDal;

            _usersignallikeDal = usersignallikeDal;

            
              
        }
         
       public override UserSignalLike EntityLogic(UserSignalLike coreObject, UserSignalLikeModel model)
        {
            return _usersignallikeDal.Save(coreObject);
        }

       public override UserSignalLike ProcessAGet(System.Linq.Expressions.Expression<Func<UserSignalLike, bool>> condition)
       {
           return _usersignallikeDal.Get(condition);
       }

       public override IEnumerable<UserSignalLike> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<UserSignalLike, bool>> condition)
       {
           return _usersignallikeDal.GetQueryable(condition).ToList();
       }

       public override UserSignalLike ToEntity(UserSignalLikeModel modelObject)
       {
           var entity = default(UserSignalLike);

           if (modelObject.UserId == Guid.Empty)
           {
               entity = new UserSignalLike();
               entity.UserId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _usersignallikeDal.Get(a => a.UserId == modelObject.UserId);

           }

            //todo: assign the rest of the fields here
            entity.SignalID = modelObject.SignalID;
                entity.Created = modelObject.Created;
                

           return entity;
       }

       public override UserSignalLikeModel ToModel(UserSignalLike coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new UserSignalLikeModel();

            //todo:Assign all properties below.
               model.UserId = coreObject.UserId;
                model.SignalID = coreObject.SignalID;
                model.Created = coreObject.Created;
                
           return model;
       }

       public override List<string> Validate(UserSignalLikeModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public UserSignalLikeModel Save(UserSignalLikeModel usersignallikeModel)
       {
           return ProcessAPost(usersignallikeModel);
       }

       public UserSignalLikeModel GetById(Guid userid)
       {
           return Get(a => a.UserId == userid);
       }

       public IEnumerable<UserSignalLikeModel> GetAll()
       {
           return GetEnumerable(a => true);
       }

       public IEnumerable<UserSignalLikeModel> GetBySignalId(Guid signalid)
       {
           return GetEnumerable(a => a.SignalID == signalid);
       }
       public IEnumerable<UserSignalLikeModel> GetByUserId(Guid userid)
       {
           return GetEnumerable(a => a.UserId == userid);
       }    
    }
}
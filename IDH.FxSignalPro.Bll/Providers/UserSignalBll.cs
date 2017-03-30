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
    public  class UserSignalBll:BLLBaseGetAndPost<UserSignal, UserSignalModel, UserSignalModel>,IUserSignalBll
    {
        private Repository<Signal> _signalDal;
        private Repository<User> _userDal;
        private Repository<UserSignal> _usersignalDal;
        public UserSignalBll(Repository<Signal> signalDal,Repository<User> userDal,Repository<UserSignal> usersignalDal)
        {
            _signalDal = signalDal;

            _userDal = userDal;

            _usersignalDal = usersignalDal;

            
              
        }
         
       public override UserSignal EntityLogic(UserSignal coreObject, UserSignalModel model)
        {
            return _usersignalDal.Save(coreObject);
        }

       public override UserSignal ProcessAGet(System.Linq.Expressions.Expression<Func<UserSignal, bool>> condition)
       {
           return _usersignalDal.Get(condition);
       }

       public override IEnumerable<UserSignal> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<UserSignal, bool>> condition)
       {
           return _usersignalDal.GetQueryable(condition).ToList();
       }

       public override UserSignal ToEntity(UserSignalModel modelObject)
       {
           var entity = default(UserSignal);

           if (modelObject.UserId == Guid.Empty)
           {
               entity = new UserSignal();
               entity.UserId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _usersignalDal.Get(a => a.UserId == modelObject.UserId);

           }

            //todo: assign the rest of the fields here
            entity.SignalId = modelObject.SignalId;
                entity.IsAccurate = modelObject.IsAccurate;
                entity.Created = modelObject.Created;
                

           return entity;
       }

       public override UserSignalModel ToModel(UserSignal coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new UserSignalModel();

            //todo:Assign all properties below.
               model.UserId = coreObject.UserId;
                model.SignalId = coreObject.SignalId;
                model.IsAccurate = coreObject.IsAccurate;
                model.Created = coreObject.Created;
                
           return model;
       }

       public override List<string> Validate(UserSignalModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public UserSignalModel Save(UserSignalModel usersignalModel)
       {
           return ProcessAPost(usersignalModel);
       }

       public UserSignalModel GetById(Guid userid)
       {
           return Get(a => a.UserId == userid);
       }

       public IEnumerable<UserSignalModel> GetAll()
       {
           return GetEnumerable(a => true);
       }

       public IEnumerable<UserSignalModel> GetBySignalId(Guid signalid)
       {
           return GetEnumerable(a => a.SignalId == signalid);
       }
       public IEnumerable<UserSignalModel> GetByUserId(Guid userid)
       {
           return GetEnumerable(a => a.UserId == userid);
       }    
    }
}
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
    public  class UserBll:BLLBaseGetAndPost<User, UserModel, UserModel>,IUserBll
    {
        private Repository<User> _userDal;
        public UserBll(Repository<User> userDal)
        {
            _userDal = userDal;

            
              
        }
         
       public override User EntityLogic(User coreObject, UserModel model)
        {
            return _userDal.Save(coreObject);
        }

       public override User ProcessAGet(System.Linq.Expressions.Expression<Func<User, bool>> condition)
       {
           return _userDal.Get(condition);
       }

       public override IEnumerable<User> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<User, bool>> condition)
       {
           return _userDal.GetQueryable(condition).ToList();
       }

       public override User ToEntity(UserModel modelObject)
       {
           var entity = default(User);

           if (modelObject.UserId == Guid.Empty)
           {
               entity = new User();
               entity.UserId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _userDal.Get(a => a.UserId == modelObject.UserId);

           }

            //todo: assign the rest of the fields here
            

           return entity;
       }

       public override UserModel ToModel(User coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new UserModel();

            //todo:Assign all properties below.
               model.UserId = coreObject.UserId;
                
           return model;
       }

       public override List<string> Validate(UserModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public UserModel Save(UserModel userModel)
       {
           return ProcessAPost(userModel);
       }

       public UserModel GetById(Guid userid)
       {
           return Get(a => a.UserId == userid);
       }

       public IEnumerable<UserModel> GetAll()
       {
           return GetEnumerable(a => true);
       }
    
    }
}
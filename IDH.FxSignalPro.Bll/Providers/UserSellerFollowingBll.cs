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
    public  class UserSellerFollowingBll:BLLBaseGetAndPost<UserSellerFollowing, UserSellerFollowingModel, UserSellerFollowingModel>,IUserSellerFollowingBll
    {
        private Repository<SellerProfile> _sellerprofileDal;
        private Repository<User> _userDal;
        private Repository<UserSellerFollowing> _usersellerfollowingDal;
        public UserSellerFollowingBll(Repository<SellerProfile> sellerprofileDal,Repository<User> userDal,Repository<UserSellerFollowing> usersellerfollowingDal)
        {
            _sellerprofileDal = sellerprofileDal;

            _userDal = userDal;

            _usersellerfollowingDal = usersellerfollowingDal;

            
              
        }
         
       public override UserSellerFollowing EntityLogic(UserSellerFollowing coreObject, UserSellerFollowingModel model)
        {
            return _usersellerfollowingDal.Save(coreObject);
        }

       public override UserSellerFollowing ProcessAGet(System.Linq.Expressions.Expression<Func<UserSellerFollowing, bool>> condition)
       {
           return _usersellerfollowingDal.Get(condition);
       }

       public override IEnumerable<UserSellerFollowing> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<UserSellerFollowing, bool>> condition)
       {
           return _usersellerfollowingDal.GetQueryable(condition).ToList();
       }

       public override UserSellerFollowing ToEntity(UserSellerFollowingModel modelObject)
       {
           var entity = default(UserSellerFollowing);

           if (modelObject.UserId == Guid.Empty)
           {
               entity = new UserSellerFollowing();
               entity.UserId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _usersellerfollowingDal.Get(a => a.UserId == modelObject.UserId);

           }

            //todo: assign the rest of the fields here
            entity.SellerProfileId = modelObject.SellerProfileId;
                entity.Created = modelObject.Created;
                entity.NotificationSubscribe = modelObject.NotificationSubscribe;
                

           return entity;
       }

       public override UserSellerFollowingModel ToModel(UserSellerFollowing coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new UserSellerFollowingModel();

            //todo:Assign all properties below.
               model.UserId = coreObject.UserId;
                model.SellerProfileId = coreObject.SellerProfileId;
                model.Created = coreObject.Created;
                model.NotificationSubscribe = coreObject.NotificationSubscribe;
                
           return model;
       }

       public override List<string> Validate(UserSellerFollowingModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public UserSellerFollowingModel Save(UserSellerFollowingModel usersellerfollowingModel)
       {
           return ProcessAPost(usersellerfollowingModel);
       }

       public UserSellerFollowingModel GetById(Guid userid)
       {
           return Get(a => a.UserId == userid);
       }

       public IEnumerable<UserSellerFollowingModel> GetAll()
       {
           return GetEnumerable(a => true);
       }

       public IEnumerable<UserSellerFollowingModel> GetBySellerProfileId(Guid sellerprofileid)
       {
           return GetEnumerable(a => a.SellerProfileId == sellerprofileid);
       }
       public IEnumerable<UserSellerFollowingModel> GetByUserId(Guid userid)
       {
           return GetEnumerable(a => a.UserId == userid);
       }    
    }
}
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
    public  class SellerProfileBll:BLLBaseGetAndPost<SellerProfile, SellerProfileModel, SellerProfileModel>,ISellerProfileBll
    {
        private Repository<SellerProfile> _sellerprofileDal;
        public SellerProfileBll(Repository<SellerProfile> sellerprofileDal)
        {
            _sellerprofileDal = sellerprofileDal;

            
              
        }
         
       public override SellerProfile EntityLogic(SellerProfile coreObject, SellerProfileModel model)
        {
            return _sellerprofileDal.Save(coreObject);
        }

       public override SellerProfile ProcessAGet(System.Linq.Expressions.Expression<Func<SellerProfile, bool>> condition)
       {
           return _sellerprofileDal.Get(condition);
       }

       public override IEnumerable<SellerProfile> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<SellerProfile, bool>> condition)
       {
           return _sellerprofileDal.GetQueryable(condition).ToList();
       }

       public override SellerProfile ToEntity(SellerProfileModel modelObject)
       {
           var entity = default(SellerProfile);

           if (modelObject.SellerProfileId == Guid.Empty)
           {
               entity = new SellerProfile();
               entity.SellerProfileId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _sellerprofileDal.Get(a => a.SellerProfileId == modelObject.SellerProfileId);

           }

            //todo: assign the rest of the fields here
            entity.SellerName = modelObject.SellerName;
                entity.Created = modelObject.Created;
                entity.Deleted = modelObject.Deleted;
                entity.Modified = modelObject.Modified;
                entity.ModifiledBy = modelObject.ModifiledBy;
                

           return entity;
       }

       public override SellerProfileModel ToModel(SellerProfile coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new SellerProfileModel();

            //todo:Assign all properties below.
               model.SellerProfileId = coreObject.SellerProfileId;
                model.SellerName = coreObject.SellerName;
                model.Created = coreObject.Created;
                model.Deleted = coreObject.Deleted;
                model.Modified = coreObject.Modified;
                model.ModifiledBy = coreObject.ModifiledBy;
                
           return model;
       }

       public override List<string> Validate(SellerProfileModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public SellerProfileModel Save(SellerProfileModel sellerprofileModel)
       {
           return ProcessAPost(sellerprofileModel);
       }

       public SellerProfileModel GetById(Guid sellerprofileid)
       {
           return Get(a => a.SellerProfileId == sellerprofileid);
       }

       public IEnumerable<SellerProfileModel> GetAll()
       {
           return GetEnumerable(a => true);
       }
    
    }
}
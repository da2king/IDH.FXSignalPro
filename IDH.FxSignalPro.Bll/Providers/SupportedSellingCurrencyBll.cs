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
    public  class SupportedSellingCurrencyBll:BLLBaseGetAndPost<SupportedSellingCurrency, SupportedSellingCurrencyModel, SupportedSellingCurrencyModel>,ISupportedSellingCurrencyBll
    {
        private Repository<SupportedSellingCurrency> _supportedsellingcurrencyDal;
        public SupportedSellingCurrencyBll(Repository<SupportedSellingCurrency> supportedsellingcurrencyDal)
        {
            _supportedsellingcurrencyDal = supportedsellingcurrencyDal;

            
              
        }
         
       public override SupportedSellingCurrency EntityLogic(SupportedSellingCurrency coreObject, SupportedSellingCurrencyModel model)
        {
            return _supportedsellingcurrencyDal.Save(coreObject);
        }

       public override SupportedSellingCurrency ProcessAGet(System.Linq.Expressions.Expression<Func<SupportedSellingCurrency, bool>> condition)
       {
           return _supportedsellingcurrencyDal.Get(condition);
       }

       public override IEnumerable<SupportedSellingCurrency> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<SupportedSellingCurrency, bool>> condition)
       {
           return _supportedsellingcurrencyDal.GetQueryable(condition).ToList();
       }

       public override SupportedSellingCurrency ToEntity(SupportedSellingCurrencyModel modelObject)
       {
           var entity = default(SupportedSellingCurrency);

           if (modelObject.SupportedSellingCurrencyId == Guid.Empty)
           {
               entity = new SupportedSellingCurrency();
               entity.SupportedSellingCurrencyId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _supportedsellingcurrencyDal.Get(a => a.SupportedSellingCurrencyId == modelObject.SupportedSellingCurrencyId);

           }

            //todo: assign the rest of the fields here
            entity.ShortName = modelObject.ShortName;
                entity.LongName = modelObject.LongName;
                entity.Symbol = modelObject.Symbol;
                entity.Created = modelObject.Created;
                entity.Deleted = modelObject.Deleted;
                entity.Modified = modelObject.Modified;
                entity.ModifiedBy = modelObject.ModifiedBy;
                

           return entity;
       }

       public override SupportedSellingCurrencyModel ToModel(SupportedSellingCurrency coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new SupportedSellingCurrencyModel();

            //todo:Assign all properties below.
               model.SupportedSellingCurrencyId = coreObject.SupportedSellingCurrencyId;
                model.ShortName = coreObject.ShortName;
                model.LongName = coreObject.LongName;
                model.Symbol = coreObject.Symbol;
                model.Created = coreObject.Created;
                model.Deleted = coreObject.Deleted;
                model.Modified = coreObject.Modified;
                model.ModifiedBy = coreObject.ModifiedBy;
                
           return model;
       }

       public override List<string> Validate(SupportedSellingCurrencyModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public SupportedSellingCurrencyModel Save(SupportedSellingCurrencyModel supportedsellingcurrencyModel)
       {
           return ProcessAPost(supportedsellingcurrencyModel);
       }

       public SupportedSellingCurrencyModel GetById(Guid supportedsellingcurrencyid)
       {
           return Get(a => a.SupportedSellingCurrencyId == supportedsellingcurrencyid);
       }

       public IEnumerable<SupportedSellingCurrencyModel> GetAll()
       {
           return GetEnumerable(a => true);
       }
    
    }
}
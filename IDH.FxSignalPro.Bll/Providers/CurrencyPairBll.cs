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
    public  class CurrencyPairBll:BLLBaseGetAndPost<CurrencyPair, CurrencyPairModel, CurrencyPairModel>,ICurrencyPairBll
    {
        private Repository<CurrencyPair> _currencypairDal;
        public CurrencyPairBll(Repository<CurrencyPair> currencypairDal)
        {
            _currencypairDal = currencypairDal;

            
              
        }
         
       public override CurrencyPair EntityLogic(CurrencyPair coreObject, CurrencyPairModel model)
        {
            return _currencypairDal.Save(coreObject);
        }

       public override CurrencyPair ProcessAGet(System.Linq.Expressions.Expression<Func<CurrencyPair, bool>> condition)
       {
           return _currencypairDal.Get(condition);
       }

       public override IEnumerable<CurrencyPair> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<CurrencyPair, bool>> condition)
       {
           return _currencypairDal.GetQueryable(condition).ToList();
       }

       public override CurrencyPair ToEntity(CurrencyPairModel modelObject)
       {
           var entity = default(CurrencyPair);

           if (modelObject.CurrencyPairId == Guid.Empty)
           {
               entity = new CurrencyPair();
               entity.CurrencyPairId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _currencypairDal.Get(a => a.CurrencyPairId == modelObject.CurrencyPairId);

           }

            //todo: assign the rest of the fields here
            entity.ShortName = modelObject.ShortName;
                entity.LongName = modelObject.LongName;
                entity.Created = modelObject.Created;
                entity.Deleted = modelObject.Deleted;
                entity.Modified = modelObject.Modified;
                entity.ModifiedBy = modelObject.ModifiedBy;
                

           return entity;
       }

       public override CurrencyPairModel ToModel(CurrencyPair coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new CurrencyPairModel();

            //todo:Assign all properties below.
               model.CurrencyPairId = coreObject.CurrencyPairId;
                model.ShortName = coreObject.ShortName;
                model.LongName = coreObject.LongName;
                model.Created = coreObject.Created;
                model.Deleted = coreObject.Deleted;
                model.Modified = coreObject.Modified;
                model.ModifiedBy = coreObject.ModifiedBy;
                
           return model;
       }

       public override List<string> Validate(CurrencyPairModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public CurrencyPairModel Save(CurrencyPairModel currencypairModel)
       {
           return ProcessAPost(currencypairModel);
       }

       public CurrencyPairModel GetById(Guid currencypairid)
       {
           return Get(a => a.CurrencyPairId == currencypairid);
       }

       public IEnumerable<CurrencyPairModel> GetAll()
       {
           return GetEnumerable(a => true);
       }
    
    }
}
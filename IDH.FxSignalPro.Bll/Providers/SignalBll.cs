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
    public  class SignalBll:BLLBaseGetAndPost<Signal, SignalModel, SignalModel>,ISignalBll
    {
        private Repository<CurrencyPair> _currencypairDal;
        private Repository<SellerProfile> _sellerprofileDal;
        private Repository<SupportedSellingCurrency> _supportedsellingcurrencyDal;
        private Repository<TimeFrame> _timeframeDal;
        private Repository<Signal> _signalDal;
        public SignalBll(Repository<CurrencyPair> currencypairDal,Repository<SellerProfile> sellerprofileDal,Repository<SupportedSellingCurrency> supportedsellingcurrencyDal,Repository<TimeFrame> timeframeDal,Repository<Signal> signalDal)
        {
            _currencypairDal = currencypairDal;

            _sellerprofileDal = sellerprofileDal;

            _supportedsellingcurrencyDal = supportedsellingcurrencyDal;

            _timeframeDal = timeframeDal;

            _signalDal = signalDal;

            
              
        }
         
       public override Signal EntityLogic(Signal coreObject, SignalModel model)
        {
            return _signalDal.Save(coreObject);
        }

       public override Signal ProcessAGet(System.Linq.Expressions.Expression<Func<Signal, bool>> condition)
       {
           return _signalDal.Get(condition);
       }

       public override IEnumerable<Signal> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<Signal, bool>> condition)
       {
           return _signalDal.GetQueryable(condition).ToList();
       }

       public override Signal ToEntity(SignalModel modelObject)
       {
           var entity = default(Signal);

           if (modelObject.SignalId == Guid.Empty)
           {
               entity = new Signal();
               entity.SignalId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _signalDal.Get(a => a.SignalId == modelObject.SignalId);

           }

            //todo: assign the rest of the fields here
            entity.SellerProfileId = modelObject.SellerProfileId;
                entity.CurrencyPairId = modelObject.CurrencyPairId;
                entity.SupportedSellCurrencyId = modelObject.SupportedSellCurrencyId;
                entity.TimeFrameId = modelObject.TimeFrameId;
                entity.ExpectedStartDate = modelObject.ExpectedStartDate;
                entity.ExpectedEndDate = modelObject.ExpectedEndDate;
                entity.StopLoss = modelObject.StopLoss;
                entity.EntryPoint = modelObject.EntryPoint;
                entity.TakeProfit = modelObject.TakeProfit;
                entity.SellingAmount = modelObject.SellingAmount;
                entity.PreSaleDescription = modelObject.PreSaleDescription;
                entity.PostSaleDescription = modelObject.PostSaleDescription;
                entity.IsPublished = modelObject.IsPublished;
                entity.Created = modelObject.Created;
                entity.Deleted = modelObject.Deleted;
                entity.Modified = modelObject.Modified;
                entity.ModifiedBy = modelObject.ModifiedBy;
                

           return entity;
       }

       public override SignalModel ToModel(Signal coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new SignalModel();

            //todo:Assign all properties below.
               model.SignalId = coreObject.SignalId;
                model.SellerProfileId = coreObject.SellerProfileId;
                model.CurrencyPairId = coreObject.CurrencyPairId;
                model.SupportedSellCurrencyId = coreObject.SupportedSellCurrencyId;
                model.TimeFrameId = coreObject.TimeFrameId;
                model.ExpectedStartDate = coreObject.ExpectedStartDate;
                model.ExpectedEndDate = coreObject.ExpectedEndDate;
                model.StopLoss = coreObject.StopLoss;
                model.EntryPoint = coreObject.EntryPoint;
                model.TakeProfit = coreObject.TakeProfit;
                model.SellingAmount = coreObject.SellingAmount;
                model.PreSaleDescription = coreObject.PreSaleDescription;
                model.PostSaleDescription = coreObject.PostSaleDescription;
                model.IsPublished = coreObject.IsPublished;
                model.Created = coreObject.Created;
                model.Deleted = coreObject.Deleted;
                model.Modified = coreObject.Modified;
                model.ModifiedBy = coreObject.ModifiedBy;
                
           return model;
       }

       public override List<string> Validate(SignalModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public SignalModel Save(SignalModel signalModel)
       {
           return ProcessAPost(signalModel);
       }

       public SignalModel GetById(Guid signalid)
       {
           return Get(a => a.SignalId == signalid);
       }

       public IEnumerable<SignalModel> GetAll()
       {
           return GetEnumerable(a => true);
       }

       public IEnumerable<SignalModel> GetByCurrencyPairId(Guid currencypairid)
       {
           return GetEnumerable(a => a.CurrencyPairId == currencypairid);
       }
       public IEnumerable<SignalModel> GetBySellerProfileId(Guid sellerprofileid)
       {
           return GetEnumerable(a => a.SellerProfileId == sellerprofileid);
       }
       public IEnumerable<SignalModel> GetBySupportedSellingCurrencyId(Guid supportedsellingcurrencyid)
       {
           return GetEnumerable(a => a.SupportedSellCurrencyId == supportedsellingcurrencyid);
       }
       public IEnumerable<SignalModel> GetByTimeFrameId(Guid timeframeid)
       {
           return GetEnumerable(a => a.TimeFrameId == timeframeid);
       }    
    }
}
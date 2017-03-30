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
    public  class TimeFrameBll:BLLBaseGetAndPost<TimeFrame, TimeFrameModel, TimeFrameModel>,ITimeFrameBll
    {
        private Repository<TimeFrame> _timeframeDal;
        public TimeFrameBll(Repository<TimeFrame> timeframeDal)
        {
            _timeframeDal = timeframeDal;

            
              
        }
         
       public override TimeFrame EntityLogic(TimeFrame coreObject, TimeFrameModel model)
        {
            return _timeframeDal.Save(coreObject);
        }

       public override TimeFrame ProcessAGet(System.Linq.Expressions.Expression<Func<TimeFrame, bool>> condition)
       {
           return _timeframeDal.Get(condition);
       }

       public override IEnumerable<TimeFrame> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<TimeFrame, bool>> condition)
       {
           return _timeframeDal.GetQueryable(condition).ToList();
       }

       public override TimeFrame ToEntity(TimeFrameModel modelObject)
       {
           var entity = default(TimeFrame);

           if (modelObject.TimeFrameId == Guid.Empty)
           {
               entity = new TimeFrame();
               entity.TimeFrameId = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _timeframeDal.Get(a => a.TimeFrameId == modelObject.TimeFrameId);

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

       public override TimeFrameModel ToModel(TimeFrame coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new TimeFrameModel();

            //todo:Assign all properties below.
               model.TimeFrameId = coreObject.TimeFrameId;
                model.ShortName = coreObject.ShortName;
                model.LongName = coreObject.LongName;
                model.Created = coreObject.Created;
                model.Deleted = coreObject.Deleted;
                model.Modified = coreObject.Modified;
                model.ModifiedBy = coreObject.ModifiedBy;
                
           return model;
       }

       public override List<string> Validate(TimeFrameModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public TimeFrameModel Save(TimeFrameModel timeframeModel)
       {
           return ProcessAPost(timeframeModel);
       }

       public TimeFrameModel GetById(Guid timeframeid)
       {
           return Get(a => a.TimeFrameId == timeframeid);
       }

       public IEnumerable<TimeFrameModel> GetAll()
       {
           return GetEnumerable(a => true);
       }
    
    }
}
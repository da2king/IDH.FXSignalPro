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
    public  class sysdiagramBll:BLLBaseGetAndPost<sysdiagram, sysdiagramModel, sysdiagramModel>,IsysdiagramBll
    {
        private Repository<sysdiagram> _sysdiagramDal;
        public sysdiagramBll(Repository<sysdiagram> sysdiagramDal)
        {
            _sysdiagramDal = sysdiagramDal;

            
              
        }
         
       public override sysdiagram EntityLogic(sysdiagram coreObject, sysdiagramModel model)
        {
            return _sysdiagramDal.Save(coreObject);
        }

       public override sysdiagram ProcessAGet(System.Linq.Expressions.Expression<Func<sysdiagram, bool>> condition)
       {
           return _sysdiagramDal.Get(condition);
       }

       public override IEnumerable<sysdiagram> ProcessAGetEnumerable(System.Linq.Expressions.Expression<Func<sysdiagram, bool>> condition)
       {
           return _sysdiagramDal.GetQueryable(condition).ToList();
       }

       public override sysdiagram ToEntity(sysdiagramModel modelObject)
       {
           var entity = default(sysdiagram);

           if (modelObject.diagram_id == Guid.Empty)
           {
               entity = new sysdiagram();
               entity.diagram_id = Guid.NewGuid();
            //todo:Attach foreign key dependencies here

           }
           else
           {
               entity = _sysdiagramDal.Get(a => a.diagram_id == modelObject.diagram_id);

           }

            //todo: assign the rest of the fields here
            entity.principal_id = modelObject.principal_id;
                entity.diagram_id = modelObject.diagram_id;
                entity.version = modelObject.version;
                entity.definition = modelObject.definition;
                

           return entity;
       }

       public override sysdiagramModel ToModel(sysdiagram coreObject)
       {
            if(coreObject == null)
                return null;

           var model = new sysdiagramModel();

            //todo:Assign all properties below.
               model.name = coreObject.name;
                model.principal_id = coreObject.principal_id;
                model.diagram_id = coreObject.diagram_id;
                model.version = coreObject.version;
                model.definition = coreObject.definition;
                
           return model;
       }

       public override List<string> Validate(sysdiagramModel model)
       {
           var result = new List<string>();
               
               //todo: make all validations below

               //if (model.ProductCost == 0)
               //{
               //    result.Add("Product cost to retailer must be defined");
               //}


           return result;
       }

       public sysdiagramModel Save(sysdiagramModel sysdiagramModel)
       {
           return ProcessAPost(sysdiagramModel);
       }

       public sysdiagramModel GetById(Guid diagram_id)
       {
           return Get(a => a.diagram_id == diagram_id);
       }

       public IEnumerable<sysdiagramModel> GetAll()
       {
           return GetEnumerable(a => true);
       }
    
    }
}
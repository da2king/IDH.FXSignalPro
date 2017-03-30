using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class UserSignalModel
    {
        public UserSignalModel()
        {
            
              
        }
         
				public Guid UserId {get; set;}


				public Guid SignalId {get; set;}


				public Boolean? IsAccurate {get; set;}


				public DateTime Created {get; set;}

    
    }
}
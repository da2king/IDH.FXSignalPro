using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class UserSignalLikeModel
    {
        public UserSignalLikeModel()
        {
            
              
        }
         
				public Guid UserId {get; set;}


				public Guid SignalID {get; set;}


				public DateTime Created {get; set;}

    
    }
}
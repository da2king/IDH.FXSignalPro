using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class UserSellerFollowingModel
    {
        public UserSellerFollowingModel()
        {
            
              
        }
         
				public Guid UserId {get; set;}


				public Guid SellerProfileId {get; set;}


				public DateTime Created {get; set;}


				public Boolean NotificationSubscribe {get; set;}

    
    }
}
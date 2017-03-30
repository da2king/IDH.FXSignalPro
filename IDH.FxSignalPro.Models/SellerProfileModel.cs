using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class SellerProfileModel
    {
        public SellerProfileModel()
        {
            
              
        }
         
				public Guid SellerProfileId {get; set;}


				public String SellerName {get; set;}


				public DateTime Created {get; set;}


				public DateTime Deleted {get; set;}


				public DateTime Modified {get; set;}


				public String ModifiledBy {get; set;}

    
    }
}
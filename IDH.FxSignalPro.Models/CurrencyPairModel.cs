using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class CurrencyPairModel
    {
        public CurrencyPairModel()
        {
            
              
        }
         
				public Guid CurrencyPairId {get; set;}


				public String ShortName {get; set;}


				public String LongName {get; set;}


				public DateTime Created {get; set;}


				public DateTime Deleted {get; set;}


				public DateTime Modified {get; set;}


				public String ModifiedBy {get; set;}

    
    }
}
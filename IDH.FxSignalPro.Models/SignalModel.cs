using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class SignalModel
    {
        public SignalModel()
        {
            
              
        }
         
				public Guid SignalId {get; set;}


				public Guid SellerProfileId {get; set;}


				public Guid CurrencyPairId {get; set;}


				public Guid SupportedSellCurrencyId {get; set;}


				public Guid TimeFrameId {get; set;}


				public DateTime ExpectedStartDate {get; set;}


				public DateTime ExpectedEndDate {get; set;}


				public Decimal StopLoss {get; set;}


				public Decimal EntryPoint {get; set;}


				public Decimal TakeProfit {get; set;}


				public Decimal SellingAmount {get; set;}


				public String PreSaleDescription {get; set;}


				public String PostSaleDescription {get; set;}


				public Boolean IsPublished {get; set;}


				public DateTime Created {get; set;}


				public DateTime Deleted {get; set;}


				public DateTime Modified {get; set;}


				public String ModifiedBy {get; set;}

    
    }
}
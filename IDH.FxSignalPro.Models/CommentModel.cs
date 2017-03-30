using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IDH.FxSignalPro.Models
{
    public  class CommentModel
    {
        public CommentModel()
        {
            
              
        }
         
				public Guid CommentId {get; set;}


				public Guid UserId {get; set;}


				public Guid SignalId {get; set;}


				public String Message {get; set;}


				public DateTime Created {get; set;}


				public DateTime Deleted {get; set;}


				public Boolean IsPublished {get; set;}


				public Boolean IsPreSaleComment {get; set;}

    
    }
}
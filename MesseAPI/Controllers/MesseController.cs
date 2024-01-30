using Microsoft.AspNetCore.Mvc;

namespace MesseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MesseController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        //Insert Database or something else here :)
        List<InfoItem> debugList = new List<InfoItem>();
        
       
        [HttpPost]
        public InfoItem Post(InfoItem requestItem)

        {
            InfoItem confirmItem = new InfoItem();


            debugList.Add(requestItem);


            if (!string.IsNullOrEmpty(requestItem.Nachname) && !string.IsNullOrEmpty(requestItem.Vorname))
            {
               confirmItem.Username= requestItem.Vorname+"."+requestItem.Nachname; 
               confirmItem.Confirmed= true;
            }
            else
            {
                confirmItem.Confirmed = false;
            }

            return confirmItem;
        }

    }
}
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
       
       
        [HttpPost]
        public InfoItem Post(InfoItem requestItem)

        {
            InfoItem confirmItem = new InfoItem();

            //Insert Database or something else here :)
            List<InfoItem> debugList = new List<InfoItem>();
            debugList.Add(requestItem);


            if (!string.IsNullOrEmpty(requestItem.Nachname) && !string.IsNullOrEmpty(requestItem.Vorname))
            {
               confirmItem.Username= requestItem.Vorname+"."+requestItem.Nachname; 
               confirmItem.Confirmed= true;
               confirmItem.RequestTime = requestItem.RequestTime;
            }
            else
            {
                confirmItem.Confirmed = false;
            }

            return confirmItem;
        }

    }
}
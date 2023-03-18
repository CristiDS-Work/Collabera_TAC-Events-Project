using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Web.UI.WebControls;
using events.tac.local.Models;
using Sitecore.Mvc.Presentation;

namespace events.tac.local.Controllers
{
    public class EventIntroController : Controller
    {
        public static EventIntro CreateModel()
        {
            var item = RenderingContext.Current.ContextItem;
            return new EventIntro()
            {
                ContentHeading = new HtmlString(FieldRenderer.Render(item, "ContentHeading")),
                ContentBody = new HtmlString(FieldRenderer.Render(item, "ContentBody")),
                EventImage = new HtmlString(FieldRenderer.Render(item, "EventImage")),
                Highlights = new HtmlString(FieldRenderer.Render(item, "Highlights")),
                ContentIntro = new HtmlString(FieldRenderer.Render(item, "ContentIntro")),
                StartDate = new HtmlString(FieldRenderer.Render(item, "StartDate")),
                Duration = new HtmlString(FieldRenderer.Render(item, "Duration")),
                DifficultyLevel = new HtmlString(FieldRenderer.Render(item, "DifficultyLevel"))
            };
        }
        
        // GET: EventIntro
        public ActionResult Index()
        {
            return View(CreateModel());
        }
    }
}

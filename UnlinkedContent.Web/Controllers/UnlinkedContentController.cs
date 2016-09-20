using System.Web.Mvc;
using UnlinkedContent.Business.Model;
using UnlinkedContent.Business.Services;

namespace UnlinkedContent.Web.Controllers
{
    public class UnlinkedContentController : Controller
    {
        public ActionResult ShowUnlinkedContent()
        {
            return View(GenerateUnlinkedContentModel());
        }

        private static UnlinkedContentModel GenerateUnlinkedContentModel()
        {
            var unlinkedContent = UnlinkedContentService.GetUnlinkedContent();
            return new UnlinkedContentModel(unlinkedContent);
        }
    }
}
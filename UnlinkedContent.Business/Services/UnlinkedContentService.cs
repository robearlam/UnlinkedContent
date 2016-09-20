using System.Collections.Generic;
using System.Linq;
using Sitecore.Data.Items;

namespace UnlinkedContent.Business.Services
{
    public class UnlinkedContentService
    {
        public static IList<Item> GetUnlinkedContent()
        {
            var contentItem = Sitecore.Context.Database.GetItem(Constants.ContentIds.ContentNode);
            return Sitecore.Globals.LinkDatabase.GetReferrers(contentItem)
                .Select(i => i.GetSourceItem())
                .Where(i => i != null)
                .ToList();
        }
    }
}
using System.Collections.Generic;
using Sitecore.Data.Items;

namespace UnlinkedContent.Business.Model
{
    public class UnlinkedContentModel
    {
        public IList<Item> UnLinkedContent { get; set; }

        public UnlinkedContentModel(IList<Item> unlinkedContent)
        {
            UnLinkedContent = unlinkedContent;
        }
    }
}

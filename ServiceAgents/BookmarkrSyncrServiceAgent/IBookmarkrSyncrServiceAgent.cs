using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookmarkr.ServiceAgents.BookmarkrSyncrServiceAgent
{
    public interface IBookmarkrSyncrServiceAgent
    {
        Task<List<Bookmark>> Sync(List<Bookmark> localBookmarks);
    }
}
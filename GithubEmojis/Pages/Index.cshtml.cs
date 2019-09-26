using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GithubEmojis.Pages
{
    public class IndexModel : PageModel
    {
        private IGithubEmojiService _emojiService;

        public IndexModel(IGithubEmojiService emojiSvc)
        {
            _emojiService = emojiSvc;
        }

        public IList<Emoji> emojis {
            get;
            set;
        }

        public async Task OnGet()
        {
            emojis = await _emojiService.GetEmojis();
        }
    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookish.Models.Requests
{
    public class CreateBookRequest
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        [Url]
        public string? BookCoverUrl { get; set; }
        public int? Year { get; set; }
        public List<string>? AuthorNames { get; set; }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Andy Weir" },
            new SelectListItem { Value = "2", Text = "Iain Banks" },
            new SelectListItem { Value = "3", Text = "J. R. R. Tolkien"  },
        };
    }
}
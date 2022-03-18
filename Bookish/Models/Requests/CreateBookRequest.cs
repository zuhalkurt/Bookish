using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bookish.Services;

namespace Bookish.Models.Requests
{
    public class CreateBookRequest
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        [Url]
        public string? BookCoverUrl { get; set; }
        public int? Year { get; set; }
        public List<int>? AuthorIds { get; set; }
    }
}
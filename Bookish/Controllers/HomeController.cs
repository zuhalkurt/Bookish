using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;
using Bookish.Repositories;
using Bookish.Models.Requests;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookish.Controllers;

public class HomeController : Controller
{
    private readonly IBookService _bookService; 
    private readonly ILoanService _loanService;
    private readonly IAuthorService _authorService; 
    private readonly IMemberService _memberService; 
    private readonly ILogger<HomeController> _logger;

    public HomeController(
        ILogger<HomeController> logger,
        IBookService bookService,
        ILoanService loanService,
        IAuthorService authorService,
        IMemberService memberService
        )
    {

        _logger = logger;
        _bookService = bookService;
        _loanService = loanService;
        _authorService = authorService;
        _memberService = memberService;

    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult BookList()
    {
        var books = _bookService.GetAllBooks();
        return View(books);
    }
     public IActionResult CreateBookForm()
        {
            var authors = _authorService.GetAllAuthors();
            ViewBag.Authors = authors.Select(
                a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                }
            );
            return View();
        }

        [HttpPost]

        public IActionResult CreateBook(
            [FromForm] CreateBookRequest createBookRequest
        )
        {
            var newBook = _bookService.CreateBook(createBookRequest);
            return Created("/Home/BookList", newBook);
        }
    public IActionResult OnLoan()
    {
        var loans = _loanService.GetAllLoans();
        return View(loans);
    }
    public IActionResult AuthorList()
    {
        var authors = _authorService.GetAllAuthors();
        return View(authors);
    }
     public IActionResult MemberList()
    {
        var members = _memberService.GetAllMembers();
        return View(members);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;

public class HomeController : Controller
{
    private BookService _bookService = new BookService(); 
    private LoanService _loanService = new LoanService();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
    public IActionResult OnLoan()
    {
        var loans = _loanService.GetAllLoans();
        return View(loans);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

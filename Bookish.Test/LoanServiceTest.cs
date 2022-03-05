using System.Collections.Generic;
using NUnit.Framework;
using FakeItEasy;
using Bookish.Services;
using Bookish.Repositories;
using Bookish.Models.Database;
using System;


namespace Bookish.Test;

public class LoanServiceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void LoanService_ConvertsDbModelsToClasses()
    {
        //Arrange
        var fakeLoanRepo = A.Fake<ILoanRepo>();
        A.CallTo(() => fakeLoanRepo.GetAllLoans()).Returns(
            new List<LoanDbModel>
            {
                new LoanDbModel
                {
                    Members = new MemberDbModel
                    {
                        Name = "Tom Hardy"
                    },
                    Books = new BookDbModel
                    {
                        Authors = new List<AuthorDbModel>
                        {
                            new AuthorDbModel
                            {
                                Name = "Iain Banks",
                            },
                        },
                        Title = "The Wasp Factory",
                        BookCoverUrl = "https://en.wikipedia.org/wiki/The_Wasp_Factory#/media/File:WaspFactory.jpg",
                        Year = 1998
                    },
                    CheckedOut = DateTime.Parse("2022-02-02"),
                    DueBack = DateTime.Parse("2022-03-02"),
                    ReturnedOn = null
                },
                new LoanDbModel
                {
                    Members = new MemberDbModel
                    {
                        Name = "Chris Hemsworth"
                    },
                    Books = new BookDbModel
                    {
                        Title = "The Martian",
                        Authors = new List<AuthorDbModel>
                            {
                                new AuthorDbModel
                                {
                                    Name = "Andy Weir",
                                },
                            },
                        BookCoverUrl = "https://upload.wikimedia.org/wikipedia/en/7/71/The_Martian_%28Weir_novel%29.jpg",
                        Year = 1998
                    },
                    CheckedOut = DateTime.Parse("2022-01-01"),
                    DueBack = DateTime.Parse("2022-04-02"),
                    ReturnedOn = null
                },
                new LoanDbModel
                {
                    Members = new MemberDbModel
                    {
                        Name = "CS Lewis"
                    },
                    Books = new BookDbModel
                    {
                        Authors = new List<AuthorDbModel>
                        {
                            new AuthorDbModel
                            {
                                Name = "J. R. R. Tolkien",
                            },
                        },
                        Title = "Fellowship of the Ring",
                        BookCoverUrl = "https://en.wikipedia.org/wiki/The_Fellowship_of_the_Ring#/media/File:The_Fellowship_of_the_Ring_cover.gif",
                        Year = 1960
                    },
                    CheckedOut = DateTime.Parse("1965-01-01"),
                    DueBack = DateTime.Parse("1965-02-02"),
                    ReturnedOn = DateTime.Parse("1965-01-02")
                }
            }
        );
        var service = new LoanService(fakeLoanRepo);

        //Act

        var loans = service.GetAllLoans();

        //Assert
        Assert.That(loans, Has.Exactly(3).Items);
        Assert.That(loans[0].Book.Title, Is.EqualTo("The Wasp Factory"));
        Assert.That(loans[1].Book.Title, Is.EqualTo("The Martian"));
        Assert.That(loans[2].Book.Title, Is.EqualTo("Fellowship of the Ring"));
        
        Assert.That(loans[0].Member.Name, Is.EqualTo("Tom Hardy"));
        Assert.That(loans[1].Member.Name, Is.EqualTo("Chris Hemsworth"));
        Assert.That(loans[2].Member.Name, Is.EqualTo("CS Lewis"));

        Assert.That(loans[0].CheckedOut, Is.EqualTo(DateTime.Parse("2022-02-02")));
        Assert.That(loans[1].DueBack, Is.EqualTo(DateTime.Parse("2022-04-02")));
        Assert.That(loans[2].ReturnedOn, Is.EqualTo(DateTime.Parse("1965-01-02")));
    }
}
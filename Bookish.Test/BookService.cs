using System.Collections.Generic;
using NUnit.Framework;
using FakeItEasy;
using Bookish.Services;
using Bookish.Repositories;
using Bookish.Models.Database;


namespace Bookish.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BookService_ConvertsDbModelsToClasses()
    {
        //Arrange
        var fakeBookRepo = A.Fake<IBookRepo>();
        A.CallTo(() => fakeBookRepo.GetAllBooks()).Returns(
            new List<BookDbModel>
            {
                new BookDbModel
                {
                    Title = "Wasp Factory",
                    Authors = new List<AuthorDbModel>
                    {
                        new AuthorDbModel
                        {
                            Name = "Iain Banks",
                        },
                    },
                    BookCoverUrl = "https://en.wikipedia.org/wiki/The_Wasp_Factory#/media/File:WaspFactory.jpg",
                    Year = 1998
                },
                        new BookDbModel
                        {
                            Title = "Fellowship of the Ring",
                            Authors = new List<AuthorDbModel>
                            {
                                new AuthorDbModel
                                {
                                    Name = "J. R. R. Tolkien",
                                },
                            },
                            BookCoverUrl = "https://en.wikipedia.org/wiki/The_Fellowship_of_the_Ring#/media/File:The_Fellowship_of_the_Ring_cover.gif",
                            Year = 12011
                        },
                        new BookDbModel
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
                            Year = 12011
                        },
            }
        );
        var service = new BookService(fakeBookRepo);

        //Act

        var books = service.GetAllBooks();

        //Assert
        Assert.That(books, Has.Exactly(3).Items);
        Assert.That(books[0].Title, Is.EqualTo("Wasp Factory"));
        Assert.That(books[1].Title, Is.EqualTo("Fellowship of the Ring"));
        Assert.That(books[2].Title, Is.EqualTo("The Martian"));
        
    }
}
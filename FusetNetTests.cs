using System;
using System.Collections.Generic;
using Fuse.NET;
using Xunit;

namespace Fuset.NET.Tests
{
    public class FusetNetTests
    {
        public struct Book
        {
            public string title;
            public string author;
        }

        //[Fact]
        public void Test()
        {
            /*
            var input = new List<Book>();

            input.Add(new Book
            {
                title = "The Code of The Wooster",
                author = "Bob James"
            });

            input.Add(new Book
            {
                title = "The Wooster Code",
                author = "Rick Martin"
            });

            input.Add(new Book
            {
                title = "The Code",
                author = "Jimmy Charles"
            });

            input.Add(new Book
            {
                title = "Old Man's War",
                author = "John Scalzi"
            });

            input.Add(new Book
            {
                title = "The Lock Artist",
                author = "Steve Hamilton"
            });

            var opt = new FuseOptions<Book>();

            opt.includeMatches = true;
            opt.includeScore = true;

            // Here we search through a list of `Book` types but you could search through just a list of strings.
            var fuse = new Fuse<Book>(input, opt);

            fuse.AddKey("title");
            fuse.AddKey("author");

            var output = fuse.Search("woo");
            Assert.False(output.Count == 0);
            */
        }
    }
}

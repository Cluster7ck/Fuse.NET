using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Fuse.NET.Tests
{
    public class UnitTest1
    {
        public struct Book
        {
            public string title;
            public string author;
        }
        [Fact]
        public void Test1()
        {
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
            opt.keys.Add(new SearchKey<Book>{
                getter = b => b.author,
                weight = 1
            });
            opt.keys.Add(new SearchKey<Book>{
                getter = b => b.title,
                weight = 1
            });

            System.Diagnostics.Debugger.Launch();
            //var output = Fuse<Book>.Search(input, "wooster", opt);
            var output = input.FuseSearch("wooster", opt);
            Assert.True(output.Count == 5);
        }
    }
}

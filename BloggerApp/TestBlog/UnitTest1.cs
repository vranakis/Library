using BloggerApp.Handlers;
using BloggerApp.Models;

namespace TestBlog
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var post = new Post();

            int days = BlogHandler.DaysElapsed(post);
            Assert.Equal(0, days);
        }
    }
}
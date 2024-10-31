using BloggerApp.Models;

namespace BloggerApp.Handlers;

public static class BlogHandler
{
    /// <summary>
    /// Calculates the time period in days between today and the post creation
    /// </summary>
    /// <param name="post"></param>
    /// <returns></returns>
    public static int DaysElapsed(Post post) //static - epeidi den xrisimopoioume kamia eksoteriki metavliti
    {
        //return (DateTime.Today - post.Created).Days;
        return post.Created.Subtract(DateTime.Today).Days;
    }
}

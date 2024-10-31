using BloggerApp.Handlers;
using BloggerApp.Models;
using BloggerApp.Repository;
using BloggerApp.Services;

var post = new NewsPost()
{
    Title = "This is my post",
    Description = "This is the description of my post",
    Created = DateTime.Now,
    Id = 300,
    Amount = 0,
    Author = new Author {Name = "Dimitris" }
};

//post.Title = "This is my post";
//post.Description = "This is the description of my post";
//post.Created = DateTime.Now;


var postRepository = new PostRepository();
var blogService = new BlogService(postRepository);
blogService.CreatePost(post);

Console.WriteLine(blogService.ReadPost());

int days = BlogHandler.DaysElapsed(post);
Console.WriteLine(days);

List<int> intslist = new();
intslist.Add(1);
intslist.Add(2);
intslist.Contains(1);
intslist.Remove(1);
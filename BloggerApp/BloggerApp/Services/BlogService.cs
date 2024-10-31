using BloggerApp.Models;
using BloggerApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Services;

public class BlogService
{
    private PostRepository _repository;

    //internal, protected
    public BlogService(PostRepository repository)
    {
        _repository = repository;
    }

    public void CreatePost(Post post) 
    {
        if (post.Author == null) {return; }
        this._repository.CreatePost(post);
    }
    public Post ReadPost() {
        return this._repository.ReadPost();
    }
    public void UpdatePost(Post post) {

        _repository.UpdatePost(post);
    }
    public void DeletePost() {
        _repository.DeletePost();
    }
}

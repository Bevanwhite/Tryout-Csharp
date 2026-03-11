using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts(int id);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(Post post);

        Task<bool> SaveChangesAsync();
    }
}



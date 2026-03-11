using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Data.Repository
{
    public class Repository : IRepository
    {

        private AppDbContext _repo;

        public Repository(AppDbContext repo)
        {
            _repo = repo;
        }

        public void AddPost(Post post)
        {
            _repo.Posts.Add(post);
        }

        public List<Post> GetAllPosts(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _repo.SaveChangesAsync() > 0)
                return true;

            return false;
        }

    }

}



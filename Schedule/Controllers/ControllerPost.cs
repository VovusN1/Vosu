using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schedule.Context;
using Schedule.Models.ReferenceBooksModule;
using Schedule.Models.ReferenceBookModule;
using Schedule.Models.ContingentModule;
using Schedule.Models.GeneralModule;

namespace Schedule.Controllers
{
    public class ControllerPost
    {
        private MainContext _dbContext;

        public ControllerPost(MainContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Post> GetAll()
        {
            return _dbContext.Post.ToList();
        }

        public void Add(Post post)
        {
            _dbContext.Post.Add(post);
            _dbContext.SaveChanges();
        }

        public void Update(Post post)
        {
            _dbContext.Post.Update(post);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = _dbContext.Post.Find(id);
            if (post != null)
            {
                _dbContext.Post.Remove(post);
                _dbContext.SaveChanges();
            }
        }
    }
}

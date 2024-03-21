using DevOps_Demo1.Models;
using System.Collections.Generic;
namespace DevOps_Demo1.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
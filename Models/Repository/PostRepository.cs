﻿using DevOps_Demo1.Models;
using System.Collections.Generic;
namespace DevOps_Demo1.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel> {
new PostViewModel(){ PostId =101, Title = "DevOps Demo Title 1", Description ="DevOps Demo Description 1", Author="Mukesh Kumar"},
new PostViewModel(){ PostId =102, Title = "DevOps Demo Title 2", Description ="DevOps Demo Description 2", Author="Banky Chamber"},
new PostViewModel(){ PostId =103, Title = "DevOps Demo Title 3", Description ="DevOps Demo Description 3", Author="Rahul Rathor"},
};
            return posts;
        }
    }
}
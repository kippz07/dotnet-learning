using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Hello", "World");
            System.Console.WriteLine($"{post.Title} {post.Description} {post.TimeCreated} {post.Score}");
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Downvote();
            System.Console.WriteLine($"{post.Title} {post.Description} {post.TimeCreated} {post.Score}");
            post.Downvote();
            post.Downvote();
            post.Downvote();
            post.Downvote();
            System.Console.WriteLine($"{post.Title} {post.Description} {post.TimeCreated} {post.Score}");
        }
    }
}

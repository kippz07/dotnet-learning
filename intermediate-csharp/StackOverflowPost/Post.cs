using System;

namespace StackOverflowPost
{
    public class Post{

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; private set; }
        public int Score { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.TimeCreated = DateTime.Now;
            this.Score = 0;
        }

        public void Upvote()
        {
            Score++;
        }

        public void Downvote()
        {
            Score--;
        }
    }
}
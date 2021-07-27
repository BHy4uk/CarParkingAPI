using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ImagePost: Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageUrl, bool isPublic)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageUrl = imageUrl;      
        }

        public override string ToString()
        {
            return String.Format("{0}- {1} i {2} want to show {3}", this.Id, this.Title, this.SendByUsername, this.ImageUrl );
        }
    }
}

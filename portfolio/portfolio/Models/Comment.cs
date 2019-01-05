using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolio.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string publisherName { get; set; }
        public string contentOfComment{ get; set; }

        public override string ToString()
        {
            return "id: " + this.id + " publisherName: " + this.publisherName + " " + "contentOfComment: " + this.contentOfComment;
        }

    }
}
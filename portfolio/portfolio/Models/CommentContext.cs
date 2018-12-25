using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace portfolio.Models
{
    public class CommentContext : DbContext
    {
        public CommentContext()
            : base("Comment")
        { }
        public DbSet<Comment> Entries { get; set; }
    }
}
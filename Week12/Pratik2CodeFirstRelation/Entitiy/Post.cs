using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik2CodeFirstRelation.Entitiy
{
    public class Post
    {
        int id;
        string title;
        string content;
        User user;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public User User { get => user; set => user = value; }
    }
}

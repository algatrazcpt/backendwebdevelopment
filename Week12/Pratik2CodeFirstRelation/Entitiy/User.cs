
namespace Pratik2CodeFirstRelation.Entitiy
{
    public class User
    {
        int id;
        string userName;
        string email;
        List<Post> posts;
        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public List<Post> Posts { get => posts; set => posts = value; }

    }
}

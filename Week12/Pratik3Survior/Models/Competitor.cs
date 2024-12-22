using System.Text.Json.Serialization;

namespace Pratik3Survior.Models
{
    public class Competitor
    {
        int id;
        DateTime createdDate;
        DateTime modifiedDate;
        bool isDeleted;
        string firstName;
        string lastName;
        int categoryId;
        [JsonConstructor]
        public Competitor(string firstName, string lastName, int categoryId)
        {
            FirstName = firstName;
            LastName = lastName;
            CategoryId = categoryId;
        }
        public Competitor(int ıd, DateTime createdDate, DateTime modifiedDate, bool ısDeleted, string firstName, string lastName, int categoryId)
        {
            Id = ıd;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            IsDeleted = ısDeleted;
            FirstName = firstName;
            LastName = lastName;
            CategoryId = categoryId;
        }
        public int Id { get => id; set => id = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
    }
}

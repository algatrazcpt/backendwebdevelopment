using System.Text.Json.Serialization;

namespace Pratik3Survior.Models
{
    public class Category
    {

        int id;
        DateTime createdDate;
        DateTime modifiedDate;
        bool isDeleted;
        string name;
        [JsonConstructor]
        public Category(string name)
        {
            Name = name;
        }
        public Category(int ıd, DateTime createdDate, DateTime modifiedDate, bool ısDeleted, string name)
        {
            Id = ıd;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            IsDeleted = ısDeleted;
            Name = name;
        }
        public int Id { get => id; set => id = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public string Name { get => name; set => name = value; }
    }
}

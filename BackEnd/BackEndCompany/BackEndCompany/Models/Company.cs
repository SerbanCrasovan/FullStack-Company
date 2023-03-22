namespace BackEndCompany.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

    }
}

namespace BackEndCompany.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; } = null;
    
    }
}

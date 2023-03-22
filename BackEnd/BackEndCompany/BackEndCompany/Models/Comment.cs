﻿namespace BackEndCompany.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; } = null;
    
    }
}

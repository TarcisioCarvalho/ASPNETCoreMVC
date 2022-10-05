using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(70)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(70)]
        public string Subject { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Message { get; set; }

     

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Subject: {Subject}, message: {Message}";
        }
    }
}

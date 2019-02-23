using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda_de_contatos.Domain
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        [ForeignKey("Contact")]
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
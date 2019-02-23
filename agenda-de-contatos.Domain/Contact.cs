using agenda_de_contatos.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda_de_contatos.Domain
{
    public class Contact
    {
        public Contact()
        {
            ContactTelephones = new List<ContactTelephone>();
        }

        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string InstantMessaging { get; set; }

        [MaxLength(400)]
        public string Site { get; set; }

        [Required]
        public virtual List<ContactTelephone> ContactTelephones { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
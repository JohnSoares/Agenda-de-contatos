using agenda_de_contatos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda_de_contatos.Domain
{
    public class ContactTelephone
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string NumberTelephone { get; set; }

        [Required]
        public List<TypeContactTelephone> TypeContactTelephone { get; set; }

        [Required]
        [ForeignKey("Contact")]
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}

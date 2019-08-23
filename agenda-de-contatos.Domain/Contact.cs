using agenda_de_contatos.Domain.Enums;
using System.Collections.Generic;
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
        [Display(Name = "Nome")]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        [Display(Name = "Aplicativo de Mensagens")]
        public string InstantMessaging { get; set; }
        
        [MaxLength(400)]
        public string Site { get; set; }

        [Display(Name = "Telefones")]
        public virtual List<ContactTelephone> ContactTelephones { get; set; }

        [Display(Name = "Tipo do Contato")]
        [Required]
        public TypeContact TypeContact { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
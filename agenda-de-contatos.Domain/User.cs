using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda_de_contatos.Domain
{
    [Table("Users")]
    public class User
    {
        public User()
        {
            Address = new List<Address>();
            Contacts = new List<Contact>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Usuário")]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [MaxLength(20)]
        public string Password { get; set; }

        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateBirth { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual List<Address> Address { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }
}
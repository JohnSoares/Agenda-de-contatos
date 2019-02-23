using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using agenda_de_contatos.Enums;

namespace agenda_de_contatos.Domain
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [MaxLength(20)]
        public string Number { get; set; }

        [MaxLength(200)]
        public string Complement { get; set; }

        [Required]
        public TypeAddressEnum TypeAddress { get; set; }

        [Required]
        [MaxLength(200)]
        public string Neighborhood { get; set; }

        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string State { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
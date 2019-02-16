using agenda_de_contatos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace agenda_de_contatos.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public List<TypeContactTelephone> TypeContactTelephone { get; set; }

        public string Email { get; set; }

        public string InstantMessaging { get; set; }

        public string Site { get; set; }
    }
}
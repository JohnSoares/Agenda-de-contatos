using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace agenda_de_contatos.ViewModels
{
    public class CreateUserViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(150, ErrorMessage = "O nome deve ter até 150 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe seu login")]
        [MaxLength(50, ErrorMessage = "O login deve ter até 50 caracteres")]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Password { get; set; }

        [Display(Name = "Confirmação de senha")]
        [Required(ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        [Compare(nameof(Password), ErrorMessage = "A senha e a confirmação não estão iguais")]
        public string ConfirmPassword { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    public class UsuariosDomain
    {
        public int ID_Usuario { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo senha precisa ter no minimo 3 caracteres")]
        public string Senha { get; set; }

        public int ID_TipoUsuario { get; set; }
    }
}

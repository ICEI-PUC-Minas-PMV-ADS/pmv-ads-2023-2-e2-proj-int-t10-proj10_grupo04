﻿using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace LavaADomicilio.API.Api.Models
{
    public class UsuarioChangePasswordInput
    {
        [Required]
        public string Senha { get; set; }
        [Required]
        public string ConfirmacaoSenha { get; set; }

    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace farmacia.api.Models

{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

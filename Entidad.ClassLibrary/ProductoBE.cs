﻿

using System.ComponentModel.DataAnnotations;

namespace Entidad.ClassLibrary
{
   public class ProductoBE
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string UrlSeo { get; set; }
        [Required]
        public int Stock { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Wiky_ASP_CodeFirst.Models
{
    public class Commentaire
    {
        [Key]
        public int Id_Commentaire { get; set; }

        [Required]
        public string Auteur { get; set; }
        public DateTime DateComentaire { get; set; }
        [Required]
        public string Contenu { get; set; }

        [ForeignKey("Article")]
        public int Com_Id_Article { get; set; }
        public virtual Article Article { get; set; }
    }
}
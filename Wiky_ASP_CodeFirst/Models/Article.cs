using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wiky_ASP_CodeFirst.Models
{
    public class Article
    {
        [Key]
        public int Id_Article { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="Le Thème est trop long (max 20 caractères)")]
        [Remote("Verifier", "Articles", ErrorMessage = "Le Theme est déja pris")]
        public string Theme { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Le Thème est trop long (max 20 caractères)")]
        public string Auteur { get; set; }

        public DateTime DateCreation { get; set; }
        public string Image { get; set; }
        [Required]
        public string Contenu { get; set; }
        public virtual ObservableCollection<Commentaire> Commentaires { get; set; }
    }
}
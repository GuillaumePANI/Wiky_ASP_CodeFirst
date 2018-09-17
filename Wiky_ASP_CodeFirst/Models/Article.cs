using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wiky_ASP_CodeFirst.Models
{
    public class Article
    {
        [Key]
        public int Id_Article { get; set; }
        public string Theme { get; set; }
        public string Auteur { get; set; }
        public DateTime DateCreation { get; set; }
        public string Image { get; set; }
        public string Contenu { get; set; }
        public virtual ObservableCollection<Commentaire> Commentaires { get; set; }
    }
}
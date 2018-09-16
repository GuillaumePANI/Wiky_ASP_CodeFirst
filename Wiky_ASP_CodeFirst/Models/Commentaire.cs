using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wiky_ASP_CodeFirst.Models
{
    public class Commentaire
    {
        public int Id_Commentaire { get; set; }
        public string Auteur { get; set; }
        public DateTime DateComentaire { get; set; }
        public string Contenu { get; set; }
    }
}
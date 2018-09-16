using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wiky_ASP_CodeFirst.BDD_CF
{
    public class DBLocator
    {
        private static Wiky_CF dbContext;
        public static Wiky_CF DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new Wiky_CF();
                }
                return dbContext;
            }
        }
    }
}
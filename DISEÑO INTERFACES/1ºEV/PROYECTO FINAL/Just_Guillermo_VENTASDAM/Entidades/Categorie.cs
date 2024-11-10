using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Categorie
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public Categorie(int categoryID,string categoryName, string description, byte[] picture)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
                throw new ArgumentException("Category name can not be null");

            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }

        public Categorie()
        {
            CategoryID = 0;
            CategoryName = "";
            Description = "";
            Picture = null;
        }
    }
}

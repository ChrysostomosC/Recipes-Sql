using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Database
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Ingredients { get; set; }

        public string Directions { get; set; }
    }
}

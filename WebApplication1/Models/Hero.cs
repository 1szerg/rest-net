using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Hero
    {
        public int id { get; set; }
        public string name { get; set; }

        public static Hero build(int _id, string _name)
        {
            Hero h = new Hero();
            h.id = _id;
            h.name = _name;
            return h;
        }
    }

}
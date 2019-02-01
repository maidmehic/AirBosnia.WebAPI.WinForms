using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Sjedista_IndexVM
    {
        public class Rows
        {
            public int SjedisteID { get; set; }
            public string Oznaka { get; set; }
            public int LetID { get; set; }
            public bool isProzor { get; set; }
        }

        public List<Rows> sjedista { get; set; }
    }
}
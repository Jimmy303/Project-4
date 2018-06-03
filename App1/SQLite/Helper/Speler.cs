using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SQLite.Helper
{
    public class Speler
    {   
        [PrimaryKey]
        public string Club { get; set; }
        public string Naam { get; set; }
        public string Leeftijd { get; set; }
        public string Lengte { get; set; }
        public string Positie { get; set; }
        public string Marktwaarde { get; set; }

    }
}
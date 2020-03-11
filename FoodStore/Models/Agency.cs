using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class Agency
    {
        public int Id { get; set; }
        public int? Position { get; set; }
        public string AgencyMain { get; set; }
        public string Comiss { get; set; }
        public string YearP { get; set; }
        public string Insp { get; set; }
    }
}

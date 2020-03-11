using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class Events
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Agency { get; set; }
        public string Section { get; set; }
        public string SubSection { get; set; }
        public string Type { get; set; }
        public string Work { get; set; }
        public int? Quantity { get; set; }
        public float? BMoney { get; set; }
        public float? ExbMoney { get; set; }
        public string Eventscol { get; set; }
        public string Note { get; set; }
        public string WhoInv { get; set; }
        public string WhoConf { get; set; }
        public string Test { get; set; }
        public string YearP { get; set; }
        public string Comment { get; set; }
    }
}

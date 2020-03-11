using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class Tso
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public string Performance { get; set; }
        public int Yoi { get; set; }
        public string Cond { get; set; }
        public int RatedLife { get; set; }
        public DateTime? Commissioning { get; set; }
        public string Fixed { get; set; }
        public string Note { get; set; }
        public string Agency { get; set; }
        public string ExtraLife { get; set; }
        public string Who { get; set; }
    }
}

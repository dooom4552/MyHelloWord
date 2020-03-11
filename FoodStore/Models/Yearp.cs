using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class Yearp
    {
        public int Id { get; set; }
        public int? Point { get; set; }
        public string Agency { get; set; }
        public int? Year { get; set; }
        public string Section { get; set; }
        public string Subsection { get; set; }
        public string Type { get; set; }
        public string Work { get; set; }
        public string Note { get; set; }
        public int? _1kv { get; set; }
        public int? _2kv { get; set; }
        public int? _3kv { get; set; }
        public int? _4kv { get; set; }
        public int? ObVsego { get; set; }
        public int? Vip { get; set; }
        public int? VipNow { get; set; }
        public string WhoConf { get; set; }
        public string WhoInv { get; set; }
        public string WhoComp { get; set; }
        public string Comment { get; set; }
        public string Test { get; set; }
        public string Done { get; set; }
        public float? Vbsr { get; set; }
        public float? Bsr { get; set; }
        public float? B { get; set; }
        public float? V { get; set; }
        public DateTime? Donedate { get; set; }
    }
}

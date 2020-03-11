using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class CommissionSurveys
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public string Season { get; set; }
        public int? Point { get; set; }
        public DateTime? Term { get; set; }
        public DateTime? Donedate { get; set; }
        public string Resp { get; set; }
        public string Agency { get; set; }
        public string WhoComp { get; set; }
        public string WhoInv { get; set; }
        public string Done { get; set; }
        public string NeedReport { get; set; }
        public string NeedPhoto { get; set; }
        public string NeedVideo { get; set; }
        public string Note { get; set; }
        public string Test { get; set; }
        public string Comment { get; set; }
        public string WhoConf { get; set; }
        public DateTime? DateInv { get; set; }
        public DateTime? DateConf { get; set; }
    }
}

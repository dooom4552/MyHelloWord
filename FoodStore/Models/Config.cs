using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class Config
    {
        public int Id { get; set; }
        public string IpFtp { get; set; }
        public string FolderFtp { get; set; }
        public string LogFtp { get; set; }
        public string PassFtp { get; set; }
        public int? PortFtp { get; set; }
        public string NewVers { get; set; }
        public string NewVersNote { get; set; }
    }
}

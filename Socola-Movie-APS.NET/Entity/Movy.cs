namespace Socola_Movie_APS.NET.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movy
    {
        public int id { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string image { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string description { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string source { get; set; }

        public int category_id { get; set; }

        public DateTime time { get; set; }

        [Column(TypeName = "ntext")]
        public string acctors { get; set; }

        [Column(TypeName = "ntext")]
        public string length { get; set; }

        [Column(TypeName = "ntext")]
        public string language { get; set; }

        [Column(TypeName = "ntext")]
        public string country { get; set; }

        public virtual Category Category { get; set; }
    }
}

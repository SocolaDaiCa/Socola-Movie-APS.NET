namespace Socola_Movie_APS.NET.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string email { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string password { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "ntext")]
        public string name { get; set; }
    }
}

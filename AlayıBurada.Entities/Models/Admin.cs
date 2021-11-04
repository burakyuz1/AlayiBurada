namespace AlayıBurada.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int AdminId { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminUserName { get; set; }

        [Required]
        [StringLength(200)]
        public string AdminPassword { get; set; }

        public bool AdminStatus { get; set; }
    }
}

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Departments
    {
        [Key]
        [Column(Order = 0)]
        public long DepartmentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1000)]
        public string DepartmentName { get; set; }
    }
}

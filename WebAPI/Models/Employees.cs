namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        [Column(Order = 0)]
        public long EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1000)]
        public string EmployeeName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1000)]
        public string Department { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1000)]
        public string MailId { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime DOJ { get; set; }
    }
}

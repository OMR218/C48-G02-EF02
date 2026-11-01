using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace C48_G02_EF02.Module_Class
{
    [Table("Attendees")]
    public class Attendee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Street { get; set; }
        [Required]
        [MaxLength(100)]
        public string Ciry { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }
        [ForeignKey("Badge")]
        public int BadgeId { get; set; }
        public Badge Badge { get; set; }

    }
}

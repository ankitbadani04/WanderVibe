﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WanderVibe.Models
{
    public class TravelPackage
    {
        [Key]
        public int PackageId { get; set; }

        [Required]
        [StringLength(200)]
        public string? PackageName { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(200)]
        public string? Destination { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Range(0, int.MaxValue)]
        public int Availability { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}

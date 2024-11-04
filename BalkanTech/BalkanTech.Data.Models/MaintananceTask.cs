﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BalkanTech.Common.Constants;

namespace BalkanTech.Data.Models
{
    public class MaintananceTask
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(MaxValueDescriptionLength)]
        [MinLength(MinValueDescriptionLength)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;
        [Required]
        public DateTime DueDate { get; set; }
        public ICollection<AssignedTechnicianTask> AssignedTechniciansTasks { get; set; } = new List<AssignedTechnicianTask>();
    }
}
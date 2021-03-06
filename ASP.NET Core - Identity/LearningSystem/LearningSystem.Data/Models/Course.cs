﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CourceDescriptionMaxLength)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TrainerId { get; set; }

        public ApplicationUser Trainer { get; set; }

        public List<StudentCourse> Students { get; set; } = new List<StudentCourse>();
    }
}

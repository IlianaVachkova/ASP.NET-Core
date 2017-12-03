﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MinLength(UserNameMinLength)]
        [MaxLength(UserNameMaxLength)]
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();

        public List<Course> Trainings { get; set; } = new List<Course>();

        public List<StudentCourse> Courses { get; set; } = new List<StudentCourse>();
    }
}

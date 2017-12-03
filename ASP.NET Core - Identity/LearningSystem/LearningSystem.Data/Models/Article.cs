using System;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Data.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [MinLength(ArticleTitleMinLength)]
        [MaxLength(ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public ApplicationUser Author { get; set; }

        public string AuthorId { get; set; }
    }
}

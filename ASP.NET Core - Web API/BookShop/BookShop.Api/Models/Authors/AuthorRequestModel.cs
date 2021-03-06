﻿using System.ComponentModel.DataAnnotations;

using static BookShop.Data.DataConstants;

namespace BookShop.Api.Models.Authors
{
    public class AuthorRequestModel
    {
        [Required]
        [MaxLength(AuthorNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AuthorNameMaxLength)]
        public string LatsName { get; set; }
    }
}

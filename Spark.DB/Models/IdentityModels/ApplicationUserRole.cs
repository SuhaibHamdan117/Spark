﻿using Microsoft.AspNetCore.Identity;

namespace Spark.DB.Models.IdentityModels
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
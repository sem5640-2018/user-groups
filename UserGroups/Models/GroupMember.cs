﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserGroups.Models
{
    public class GroupMember
    {
        [Key]
        [JsonIgnore]
        public virtual int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 36, MinimumLength = 36)]
        public virtual string UserId { get; set; }

        [Required]
        [JsonIgnore]
        public virtual int GroupId { get; set; }
    }
}

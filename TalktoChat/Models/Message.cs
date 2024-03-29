﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TalktoChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }
        public string UserId { get; set; }
        public virtual AppUser Sender { get; set; }
    }
}

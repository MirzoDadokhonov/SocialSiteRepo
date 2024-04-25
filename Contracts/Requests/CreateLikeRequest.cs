﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreateLikeRequest
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
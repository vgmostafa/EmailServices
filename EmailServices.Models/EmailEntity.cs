﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServices.Models
{
    public class EmailEntity
    {
        public string From { get; set; }
        public List<string> To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}

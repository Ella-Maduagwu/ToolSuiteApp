﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolsuiteapp.Model
{
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl {  get; set; }
        public string ImageUrl { get; set; }
        public DateOnly LastReviewed { get; set; }
        public DateOnly LastDemoDate { get; set; }
        public string Category { get; set; }
    }
}

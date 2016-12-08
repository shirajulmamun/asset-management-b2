﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int  ParentId { get; set; }
        public Category Parent { get; set; }

    }
}

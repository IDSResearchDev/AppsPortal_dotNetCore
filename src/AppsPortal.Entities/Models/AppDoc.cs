﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Entities.Model
{
    public class AppDoc
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string PDFLink { get; set; }
    }
}

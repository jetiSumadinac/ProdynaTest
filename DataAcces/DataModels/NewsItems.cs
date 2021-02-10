﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
 

namespace DataAcces.DataModels
{
    public class NewsItems
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public int AuthorId { get; set; }
        public Authors ItemAuthor { get; set; }
        public int CreatedTimestamp { get; set; }
    }
}

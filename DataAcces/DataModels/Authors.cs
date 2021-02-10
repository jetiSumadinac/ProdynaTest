using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcces.DataModels
{
    public class Authors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NewsItems NewsItem { get; set; }
    }
}

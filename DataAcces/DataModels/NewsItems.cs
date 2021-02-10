using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
 

namespace DataAcces.DataModels
{
    public class NewsItems
    {
        [Key]
        [Required]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public int Category { get; set; }

        [ForeignKey("Id")]
        [Required]
        public int Author { get; set; }

        public int CreatedTimestamp { get; set; }
    }
}

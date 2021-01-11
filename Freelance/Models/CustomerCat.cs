using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freelance.Models
{
    [Table("customer_cats")]
    public class CustomerCat
    {
        [Key]
        [Column("cat_id")]
        public int ID
        {
            get; set;
        }

        [Required]
        [StringLength(100)]
        public string Name
        {
            get; set;
        }


        public string Description 

    }
}

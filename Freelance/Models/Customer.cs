using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance.Models
{
    public class Customer
    {



        [Key]
        [Column("customer_id")]
        public int ID
        {
            get; set;
        }

        [Required]
        [Column("customer_name")]
        [StringLenght(100)]
        [DataType(DataType.Text)]
        public string Name 
        { 
            get; set; 
        }

        [Required]
        [Column("customer_email")]
        [StringLenght(100)]
        [DataType(DataType.EmailAddress)]

        public string email
        {
            get; set;
        }






}
}

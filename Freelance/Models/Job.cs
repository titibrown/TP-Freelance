using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freelance.Models
{
    [Table("jobs")]
    public class Job
    {

       
      
        [Key]
        [Column("job_id")]
        public int ID
        {
            get; set;
        }

        public string Job_State
        {
            get; set;
        }

        public string Job_Title
        {
            get; set;
        }


          [DataType(DataType.Date)]
          public DateTime Start
        {
            get; set;
        }

        [DataType(DataType.Date)]
        public DateTime End
        {
            get; set;
        }

        public string Job_Description
        {
            get; set;
        }








        }


    }


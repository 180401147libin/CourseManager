using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public   partial class ActionLinks
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]

        public string Name { get; set; }
         
        [Required]
        [StringLength(20)]

        public string Controller {get; set;}

        [Required]
        [StringLength(20)]

        public string Action { get; set; }
    }
}
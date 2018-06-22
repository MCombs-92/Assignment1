using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application1.Models {

    public class Owner {

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(55)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        public Owner () { }

    }
}
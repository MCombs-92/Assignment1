using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Application1.Models {

    public class Vehicle {

        public int Id { get; set; }

        [Required]
        [StringLength(55)]
        [Index(IsUnique = true)]
        public string Vin { get; set; }

        [Required]
        [StringLength(30)]
        public string Make { get; set; }

        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        // GD: Actually Year should be an integer
        // Vehicle: Id (int), Vin (string), Make (string), Model (string), *Year (int)*
        [Required]
        [StringLength(4)]
        public string Year { get; set; }


        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public Vehicle () { }

    }
}

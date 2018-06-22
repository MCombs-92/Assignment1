using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application1.Models;

namespace Application1.ViewModels {

    public class VehiclesforOwner {

        public Owner Owner { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }

        public VehiclesforOwner() { }

    }
}
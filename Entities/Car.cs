﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CarSharing.Entities
{
    public partial class Car
    {
        public Car()
        {
            Inspections = new HashSet<Inspection>();
            Rentals = new HashSet<Rental>();
        }

        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string ImagePath { get; set; }
        public byte[] CarImage { get; set; }

        public virtual ICollection<Inspection> Inspections { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CarSharing.Entities
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int RentalId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual Rental Rental { get; set; }
    }
}
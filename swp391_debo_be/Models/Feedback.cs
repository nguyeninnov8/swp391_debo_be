﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace swp391_debo_be.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public Guid? CusId { get; set; }

    public int? TreatId { get; set; }

    public string Description { get; set; }

    public virtual User Cus { get; set; }

    public virtual ClinicTreatment Treat { get; set; }
}
﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace swp391_debo_be.Entity.Implement;

public partial class User
{
    public Guid Id { get; set; }

    public int? Role { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? Gender { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? DateOfBirthday { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Booking> BookingCreators { get; set; } = new List<Booking>();

    public virtual ICollection<Booking> BookingCus { get; set; } = new List<Booking>();

    public virtual ICollection<ClinicBranch> ClinicBranches { get; set; } = new List<ClinicBranch>();

    public virtual ICollection<ClinicTreatment> ClinicTreatments { get; set; } = new List<ClinicTreatment>();

    public virtual ICollection<CustomerRecord> CustomerRecords { get; set; } = new List<CustomerRecord>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Role? RoleNavigation { get; set; }
}
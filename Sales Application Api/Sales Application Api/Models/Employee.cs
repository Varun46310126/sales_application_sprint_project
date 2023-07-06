﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sales_Application_Api.Models;

public partial class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    public string FirstName { get; set; } = null!;

    public string? Title { get; set; }

    public string? TitleOfCourtesy { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? HireDate { get; set; }


    public string? Address { get; set; }


    public string? City { get; set; }


    public string? Region { get; set; }


    public string? PostalCode { get; set; }


    public string? Country { get; set; }


    public string? HomePhone { get; set; }
    public string? Extension { get; set; }

    public byte[]? Photo { get; set; }

    public string? Notes { get; set; }

    public int? ReportsTo { get; set; }

    public string? PhotoPath { get; set; }

 
    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new List<Employee>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    
    public virtual Employee? ReportsToNavigation { get; set; }

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}

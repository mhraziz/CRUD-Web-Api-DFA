using System;
using System.Collections.Generic;

namespace CRUD_Web_Api.Models;

public partial class Student
{
    public int? Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Addres { get; set; }
}

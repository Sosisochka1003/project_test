using System;
using System.Collections.Generic;

namespace test1;

public partial class Student
{
    public int Id { get; set; }
    public string? Sname { get; set; }
    public override string ToString()
    {
        return this.Id + ", " + this.Sname;
    }
}

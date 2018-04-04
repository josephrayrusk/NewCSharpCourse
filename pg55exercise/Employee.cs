using System;
using System.Collections.Generic;
namespace pg55exercise
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}

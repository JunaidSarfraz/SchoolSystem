//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Class : IComparable
    {
        public Class()
        {
            this.Courses = new HashSet<Course>();
            this.Sections = new HashSet<Section>();
        }
    
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Section> Sections { get; set; }

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo((obj as Class).Name);
        }
    }
}

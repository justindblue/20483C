//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grades.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grades
    {
        public int Id { get; set; }
        public string Assessment { get; set; }
        public string Comments { get; set; }
        public System.DateTime AssessmentDate { get; set; }
        public int SubjectId { get; set; }
        public System.Guid StudentUserId { get; set; }
    
        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
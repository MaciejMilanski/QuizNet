//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizNet.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questions
    {
        public int QID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<int> CORRECT_ANSWER_ID { get; set; }
    
        public virtual Answers Answers { get; set; }
    }
}
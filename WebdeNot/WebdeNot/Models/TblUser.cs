//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebdeNot.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUser
    {
        public TblUser()
        {
            this.TblNote = new HashSet<TblNote>();
        }
    
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public int ID { get; set; }
        public Nullable<bool> Existing { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
    
        public virtual ICollection<TblNote> TblNote { get; set; }
    }
}
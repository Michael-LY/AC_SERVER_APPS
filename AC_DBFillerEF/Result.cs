//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AC_DBFillerEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int DriverId { get; set; }
        public string Car { get; set; }
        public short StartPosition { get; set; }
        public short Position { get; set; }
        public int IncidentCount { get; set; }
        public int Distance { get; set; }
        public short LapCount { get; set; }
        public string Gap { get; set; }
        public short TopSpeed { get; set; }
    
        public virtual Session Session { get; set; }
        public virtual Driver Driver { get; set; }
    }
}

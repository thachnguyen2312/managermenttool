//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiWeather.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TWeather
    {
        public int C_id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string coord { get; set; }
        public Nullable<double> lon { get; set; }
        public Nullable<double> lat { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_APTA_CMS_DEMO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class organizer
    {
        
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public Nullable<int> approve { get; set; }
        public Nullable<int> conferenceId { get; set; }
        public Nullable<System.DateTime> reg_date { get; set; }
    
        public virtual conference_event conference_event { get; set; }
        [NotMapped]
        public List<conference_event> ConferenceCollection { get; set; }
    }
}

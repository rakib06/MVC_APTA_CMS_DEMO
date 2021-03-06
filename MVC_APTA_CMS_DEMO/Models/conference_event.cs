//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace MVC_APTA_CMS_DEMO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class conference_event
    {
        public conference_event()
        {
            this.teams_paper = new HashSet<teams_paper>();
            this.organizers = new HashSet<organizer>();
        }
        [DisplayName("Conference Name")]
        public string Name { get; set; }
        [DisplayName("Start Date")]
        public Nullable<System.DateTime> StartDate { get; set; }
        [DisplayName("End Date")]
        public Nullable<System.DateTime> EndDate { get; set; }

        public string Chairman { get; set; }
        public string Locations { get; set; }
        [DisplayName("Short Description")]
        public string short_description { get; set; }
        [DisplayName("Last Registration Date")]
        public Nullable<System.DateTime> last_reg_date { get; set; }
        public int conferenceID { get; set; }
        public Nullable<int> admin_id { get; set; }
    
        public virtual apta_admin apta_admin { get; set; }
        public virtual ICollection<teams_paper> teams_paper { get; set; }
        public virtual ICollection<organizer> organizers { get; set; }
    }
}

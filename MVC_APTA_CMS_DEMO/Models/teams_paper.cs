//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_APTA_CMS_DEMO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class teams_paper
    {
        public teams_paper()
        {
            this.members = new HashSet<member>();
        }
    
        public int DelegatesID { get; set; }
        public int ConferenceID { get; set; }
        public string OrganizationName { get; set; }
        public string TeamName { get; set; }
        public string OrganizationType { get; set; }
        public string PaperName { get; set; }
        public string PaperLink { get; set; }
        public string PaperInbrief { get; set; }
        public string PaperDomains { get; set; }
        public Nullable<int> approve { get; set; }
    
        public virtual conference_event conference_event { get; set; }
        public virtual ICollection<member> members { get; set; }
    }
}
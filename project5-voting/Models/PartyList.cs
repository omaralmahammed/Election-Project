//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project5_voting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartyList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartyList()
        {
            this.PartyCandidates = new HashSet<PartyCandidate>();
        }
    
        public int id { get; set; }
        public string partyName { get; set; }
        public string partyImage { get; set; }
        public Nullable<int> counter { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyCandidate> PartyCandidates { get; set; }
    }
}
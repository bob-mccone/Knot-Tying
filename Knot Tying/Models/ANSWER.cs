//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Knot_Tying.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ANSWER
    {
        public ANSWER()
        {
            this.CompetitionQuestions = new HashSet<CompetitionQuestion>();
            this.CompetitionEntries = new HashSet<CompetitionEntry>();
        }
    
        public int ID { get; set; }
        public string Answer_Text { get; set; }
        public Nullable<bool> IS_CORRECT { get; set; }
        public Nullable<int> CMQ_ID { get; set; }
    
        public virtual CompetitionQuestion CompetitionQuestion { get; set; }
        public virtual ICollection<CompetitionQuestion> CompetitionQuestions { get; set; }
        public virtual ICollection<CompetitionEntry> CompetitionEntries { get; set; }
    }
}

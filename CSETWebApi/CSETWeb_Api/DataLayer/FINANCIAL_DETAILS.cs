//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class FINANCIAL_DETAILS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FINANCIAL_DETAILS()
        {
            this.FINANCIAL_FFIEC_MAPPINGS = new HashSet<FINANCIAL_FFIEC_MAPPINGS>();
            this.FINANCIAL_QUESTIONS = new HashSet<FINANCIAL_QUESTIONS>();
            this.FINANCIAL_REQUIREMENTS = new HashSet<FINANCIAL_REQUIREMENTS>();
            this.FINANCIAL_TIERS = new HashSet<FINANCIAL_TIERS>();
        }
    
        public string Label { get; set; }
        public int StmtNumber { get; set; }
        public int DomainId { get; set; }
        public int AssessmentFactorId { get; set; }
        public int FinComponentId { get; set; }
        public int MaturityId { get; set; }
        public Nullable<double> Binary_Criteria_ID { get; set; }
        public string Maturity_Target { get; set; }
        public string CSC_________________Basic___________________1_6_ { get; set; }
        public string CSC_Foundational___7_16_ { get; set; }
        public string CSC_Organizational____________17_20_ { get; set; }
        public string CSC_Mapping { get; set; }
        public string NCUA_R_R_748_Mapping { get; set; }
        public string NCUA_R_R_749_Mapping { get; set; }
        public string FFIEC_Booklets_Mapping { get; set; }
    
        public virtual FINANCIAL_ASSESSMENT_FACTORS FINANCIAL_ASSESSMENT_FACTORS { get; set; }
        public virtual FINANCIAL_COMPONENTS FINANCIAL_COMPONENTS { get; set; }
        public virtual FINANCIAL_DOMAINS FINANCIAL_DOMAINS { get; set; }
        public virtual FINANCIAL_MATURITY FINANCIAL_MATURITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCIAL_FFIEC_MAPPINGS> FINANCIAL_FFIEC_MAPPINGS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCIAL_QUESTIONS> FINANCIAL_QUESTIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCIAL_REQUIREMENTS> FINANCIAL_REQUIREMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCIAL_TIERS> FINANCIAL_TIERS { get; set; }
    }
}

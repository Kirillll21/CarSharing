//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSharing
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.CarClients = new HashSet<CarClient>();
        }
    
        public int Id { get; set; }
        public string Class { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string GosNum { get; set; }
        public int CountDoor { get; set; }
        public string TypeKP { get; set; }
        public decimal ChargeForDay { get; set; }
        public decimal SumZalog { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarClient> CarClients { get; set; }
    }
}
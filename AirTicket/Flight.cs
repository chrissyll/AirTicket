//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirTicket
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.AirplainCabinDetails = new HashSet<AirplainCabinDetail>();
            this.FlightSeats = new HashSet<FlightSeat>();
            this.Orders = new HashSet<Order>();
        }
    
        public int Flight_ID { get; set; }
        public Nullable<int> Airplain_ID { get; set; }
        public Nullable<System.DateTime> Departure_Date { get; set; }
        public Nullable<System.DateTime> Arrival_date { get; set; }
        public Nullable<int> Country_ID { get; set; }
        public Nullable<int> Airport_ID { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
    
        public virtual Airplain Airplain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirplainCabinDetail> AirplainCabinDetails { get; set; }
        public virtual Airport Airport { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightSeat> FlightSeats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
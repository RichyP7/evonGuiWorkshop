namespace DAL.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DimDate")]
    public partial class DimDate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimDate()
        {
            FactCallCenter = new HashSet<FactCallCenter>();
            FactCurrencyRate = new HashSet<FactCurrencyRate>();
            FactFinance = new HashSet<FactFinance>();
            FactInternetSales = new HashSet<FactInternetSales>();
            FactInternetSales1 = new HashSet<FactInternetSales>();
            FactInternetSales2 = new HashSet<FactInternetSales>();
            FactProductInventory = new HashSet<FactProductInventory>();
            FactResellerSales = new HashSet<FactResellerSales>();
            FactResellerSales1 = new HashSet<FactResellerSales>();
            FactResellerSales2 = new HashSet<FactResellerSales>();
            FactSalesQuota = new HashSet<FactSalesQuota>();
            FactSurveyResponse = new HashSet<FactSurveyResponse>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DateKey { get; set; }

        [Column(TypeName = "date")]
        public DateTime FullDateAlternateKey { get; set; }

        public byte DayNumberOfWeek { get; set; }

        [Required]
        [StringLength(10)]
        public string EnglishDayNameOfWeek { get; set; }

        [Required]
        [StringLength(10)]
        public string SpanishDayNameOfWeek { get; set; }

        [Required]
        [StringLength(10)]
        public string FrenchDayNameOfWeek { get; set; }

        public byte DayNumberOfMonth { get; set; }

        public short DayNumberOfYear { get; set; }

        public byte WeekNumberOfYear { get; set; }

        [Required]
        [StringLength(10)]
        public string EnglishMonthName { get; set; }

        [Required]
        [StringLength(10)]
        public string SpanishMonthName { get; set; }

        [Required]
        [StringLength(10)]
        public string FrenchMonthName { get; set; }

        public byte MonthNumberOfYear { get; set; }

        public byte CalendarQuarter { get; set; }

        public short CalendarYear { get; set; }

        public byte CalendarSemester { get; set; }

        public byte FiscalQuarter { get; set; }

        public short FiscalYear { get; set; }

        public byte FiscalSemester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactCallCenter> FactCallCenter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactCurrencyRate> FactCurrencyRate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactFinance> FactFinance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactInternetSales> FactInternetSales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactInternetSales> FactInternetSales1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactInternetSales> FactInternetSales2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactProductInventory> FactProductInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactResellerSales> FactResellerSales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactResellerSales> FactResellerSales1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactResellerSales> FactResellerSales2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactSalesQuota> FactSalesQuota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactSurveyResponse> FactSurveyResponse { get; set; }
    }
}

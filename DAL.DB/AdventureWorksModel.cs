namespace DAL.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdventureWorksModel : DbContext
    {
        public AdventureWorksModel()
            : base("name=AdventureWorksModel")
        {
        }

        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<DimAccount> DimAccount { get; set; }
        public virtual DbSet<DimCurrency> DimCurrency { get; set; }
        public virtual DbSet<DimCustomer> DimCustomer { get; set; }
        public virtual DbSet<DimDate> DimDate { get; set; }
        public virtual DbSet<DimDepartmentGroup> DimDepartmentGroup { get; set; }
        public virtual DbSet<DimEmployee> DimEmployee { get; set; }
        public virtual DbSet<DimGeography> DimGeography { get; set; }
        public virtual DbSet<DimOrganization> DimOrganization { get; set; }
        public virtual DbSet<DimProduct> DimProduct { get; set; }
        public virtual DbSet<DimProductCategory> DimProductCategory { get; set; }
        public virtual DbSet<DimProductSubcategory> DimProductSubcategory { get; set; }
        public virtual DbSet<DimPromotion> DimPromotion { get; set; }
        public virtual DbSet<DimReseller> DimReseller { get; set; }
        public virtual DbSet<DimSalesReason> DimSalesReason { get; set; }
        public virtual DbSet<DimSalesTerritory> DimSalesTerritory { get; set; }
        public virtual DbSet<DimScenario> DimScenario { get; set; }
        public virtual DbSet<FactAdditionalInternationalProductDescription> FactAdditionalInternationalProductDescription { get; set; }
        public virtual DbSet<FactCallCenter> FactCallCenter { get; set; }
        public virtual DbSet<FactCurrencyRate> FactCurrencyRate { get; set; }
        public virtual DbSet<FactInternetSales> FactInternetSales { get; set; }
        public virtual DbSet<FactProductInventory> FactProductInventory { get; set; }
        public virtual DbSet<FactResellerSales> FactResellerSales { get; set; }
        public virtual DbSet<FactSalesQuota> FactSalesQuota { get; set; }
        public virtual DbSet<FactSurveyResponse> FactSurveyResponse { get; set; }
        public virtual DbSet<ProspectiveBuyer> ProspectiveBuyer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<FactFinance> FactFinance { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimAccount>()
                .HasMany(e => e.DimAccount1)
                .WithOptional(e => e.DimAccount2)
                .HasForeignKey(e => e.ParentAccountKey);

            modelBuilder.Entity<DimAccount>()
                .HasMany(e => e.FactFinance)
                .WithRequired(e => e.DimAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimCurrency>()
                .Property(e => e.CurrencyAlternateKey)
                .IsFixedLength();

            modelBuilder.Entity<DimCurrency>()
                .HasMany(e => e.FactCurrencyRate)
                .WithRequired(e => e.DimCurrency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimCurrency>()
                .HasMany(e => e.FactInternetSales)
                .WithRequired(e => e.DimCurrency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimCurrency>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimCurrency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimCustomer>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<DimCustomer>()
                .Property(e => e.YearlyIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimCustomer>()
                .Property(e => e.HouseOwnerFlag)
                .IsFixedLength();

            modelBuilder.Entity<DimCustomer>()
                .HasMany(e => e.FactInternetSales)
                .WithRequired(e => e.DimCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimCustomer>()
                .HasMany(e => e.FactSurveyResponse)
                .WithRequired(e => e.DimCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactCallCenter)
                .WithRequired(e => e.DimDate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactCurrencyRate)
                .WithRequired(e => e.DimDate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactFinance)
                .WithRequired(e => e.DimDate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactInternetSales)
                .WithRequired(e => e.DimDate)
                .HasForeignKey(e => e.OrderDateKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactInternetSales1)
                .WithRequired(e => e.DimDate1)
                .HasForeignKey(e => e.DueDateKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactInternetSales2)
                .WithRequired(e => e.DimDate2)
                .HasForeignKey(e => e.ShipDateKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactProductInventory)
                .WithRequired(e => e.DimDate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimDate)
                .HasForeignKey(e => e.OrderDateKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactResellerSales1)
                .WithRequired(e => e.DimDate1)
                .HasForeignKey(e => e.DueDateKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactResellerSales2)
                .WithRequired(e => e.DimDate2)
                .HasForeignKey(e => e.ShipDateKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactSalesQuota)
                .WithRequired(e => e.DimDate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDate>()
                .HasMany(e => e.FactSurveyResponse)
                .WithRequired(e => e.DimDate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimDepartmentGroup>()
                .HasMany(e => e.DimDepartmentGroup1)
                .WithOptional(e => e.DimDepartmentGroup2)
                .HasForeignKey(e => e.ParentDepartmentGroupKey);

            modelBuilder.Entity<DimDepartmentGroup>()
                .HasMany(e => e.FactFinance)
                .WithRequired(e => e.DimDepartmentGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimEmployee>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<DimEmployee>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<DimEmployee>()
                .Property(e => e.BaseRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimEmployee>()
                .HasMany(e => e.DimEmployee1)
                .WithOptional(e => e.DimEmployee2)
                .HasForeignKey(e => e.ParentEmployeeKey);

            modelBuilder.Entity<DimEmployee>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimEmployee>()
                .HasMany(e => e.FactSalesQuota)
                .WithRequired(e => e.DimEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimOrganization>()
                .HasMany(e => e.DimOrganization1)
                .WithOptional(e => e.DimOrganization2)
                .HasForeignKey(e => e.ParentOrganizationKey);

            modelBuilder.Entity<DimOrganization>()
                .HasMany(e => e.FactFinance)
                .WithRequired(e => e.DimOrganization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.DealerPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .HasMany(e => e.FactInternetSales)
                .WithRequired(e => e.DimProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimProduct>()
                .HasMany(e => e.FactProductInventory)
                .WithRequired(e => e.DimProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimProduct>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimPromotion>()
                .HasMany(e => e.FactInternetSales)
                .WithRequired(e => e.DimPromotion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimPromotion>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimPromotion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimReseller>()
                .Property(e => e.BusinessType)
                .IsUnicode(false);

            modelBuilder.Entity<DimReseller>()
                .Property(e => e.OrderFrequency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DimReseller>()
                .Property(e => e.AnnualSales)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimReseller>()
                .Property(e => e.MinPaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimReseller>()
                .Property(e => e.AnnualRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimReseller>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimReseller)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimSalesReason>()
                .HasMany(e => e.FactInternetSales)
                .WithMany(e => e.DimSalesReason)
                .Map(m => m.ToTable("FactInternetSalesReason").MapLeftKey("SalesReasonKey").MapRightKey(new[] { "SalesOrderNumber", "SalesOrderLineNumber" }));

            modelBuilder.Entity<DimSalesTerritory>()
                .HasMany(e => e.FactInternetSales)
                .WithRequired(e => e.DimSalesTerritory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimSalesTerritory>()
                .HasMany(e => e.FactResellerSales)
                .WithRequired(e => e.DimSalesTerritory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DimScenario>()
                .HasMany(e => e.FactFinance)
                .WithRequired(e => e.DimScenario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.ExtendedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.ProductStandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.TotalProductCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.SalesAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactInternetSales>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactProductInventory>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.ExtendedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.ProductStandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.TotalProductCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.SalesAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactResellerSales>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactSalesQuota>()
                .Property(e => e.SalesAmountQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProspectiveBuyer>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<ProspectiveBuyer>()
                .Property(e => e.YearlyIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProspectiveBuyer>()
                .Property(e => e.HouseOwnerFlag)
                .IsFixedLength();
        }
    }
}

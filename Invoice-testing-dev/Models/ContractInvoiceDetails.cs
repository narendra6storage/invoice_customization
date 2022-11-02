namespace Invoice_testing_dev.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ContractInvoiceDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractInvoiceDetails()
        {
            //TODO UNCOMMENT AND ADD 
            //ContractInvoiceCharges = new HashSet<ContractInvoiceCharges>();
            //ContractInvPaymentTransDetails = new HashSet<ContractInvPaymentTransDetails>();
            //ContractPaymentDetails = new HashSet<ContractPaymentDetails>();
            //ContractRefundMasterDetail = new HashSet<ContractRefundMasterDetail>();
        }

        public Guid id { get; set; }

        [Column("InvoiceNumber")]
        public long NewInvoiceNumber { get; set; }

        public Guid ClientId { get; set; }

        public long ContractId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime InvoiceDate { get; set; }


        public string Createdby { get; set; }


        public string Comment { get; set; }


        public string Category { get; set; }


        public string Customer_SSN { get; set; }

        public DateTime? InvoiceDueDate { get; set; }

        public DateTime? InvPeriodFrom { get; set; }

        public DateTime? InvPeriodTo { get; set; }


        public string Description { get; set; }

        public decimal? ContractBalance { get; set; }

        public decimal? InsuranceCharges { get; set; }

        public decimal? Deposit { get; set; }

        public decimal? Advance { get; set; }

        public decimal? AdditionalCharges { get; set; }

        public decimal? AddServiceDiscount { get; set; }

        public decimal? MerchandiseCharges { get; set; }

        public decimal? MerchandiseDiscount { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? RentTax { get; set; }

        public decimal? RentDiscount { get; set; }

        public decimal? RentDiscountTax { get; set; }

        public decimal? ReservationFee { get; set; }

        public decimal? ReservationTax { get; set; }

        public decimal? TaxCharges { get; set; }

        public decimal? TotalInvAmt { get; set; }

        public bool deleted { get; set; }

        public string InvoiceFilePath { get; set; }

        public decimal? OnAccountDebit { get; set; }
        /// <summary>
        /// InvTaxPercentage column sum of applied tax percentage
        /// Comments added by prakash during sprint 30 on 19-04-2019.
        /// refer invoice applied tax percentage table sum of invoiceitemcategory=='RENT'
        /// </summary>
        public decimal? InvTaxPercentage { get; set; }

        //TODO UNCOMMENT AND ADD CLASSES
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ContractInvoiceCharges> ContractInvoiceCharges { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ContractInvPaymentTransDetails> ContractInvPaymentTransDetails { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ContractPaymentDetails> ContractPaymentDetails { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ContractRefundMasterDetail> ContractRefundMasterDetail { get; set; }

        public decimal? AdditionalRent { get; set; }

        public string ClientInvoiceNumber { get; set; }

        public decimal InvoiceAdditionalDiscount { get; set; }

        public bool IsMergedInvoice { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string StaffComment { get; set; }

        public bool IsLateFeeWaved { get; set; }

        public decimal UnPaidBalance { get; set; }

        public decimal UnPaidLateFee { get; set; }

        public DateTime? LastPaidDate { get; set; }

        public decimal TotPaidAmt { get; set; }

        public decimal AppliedCreditAmount { get; set; }

        /// <summary>
        /// Added By nagur for Move out reversal invoice path
        /// </summary>
        public string ReversalInvoiceFilePath { get; set; }
        public bool IsReversalInvoiceExist { get; set; }
        /// <summary>
        /// adeed by prakash during sprint 22  for fixing round off value issue on 7-11-2018
        /// </summary>
        public decimal RoundOffValue { get; set; }
        public bool RoundOffEnabled { get; set; }
        public bool IsInvoiceCancelled { get; set; }
        public Guid? CreditNoteCancelledInvoiceId { get; set; }
        /// <summary>
        /// Prakash added this two new colmun (IsTransferMoveOutInvoice,IsTransferMoveInInvoice) during  sprint 25 for new transfer tenant changes
        /// on 27-12-2018.
        /// </summary>
        public bool IsTransferMoveOutInvoice { get; set; }

        public bool IsTransferMoveInInvoice { get; set; }
        public string ElectronicXMLFilePath { get; set; }
        /// <summary>
        ///  Prakash added this column for if IsMoveOutRefundAdjusted=<see langword="true"/>
        ///  then refund, reversal invoice should not generated.
        ///  check Story in Jira on sprint 33 03-07-2019.
        ///  https://sixstorage.atlassian.net/secure/RapidBoard.jspa?rapidView=1&projectKey=SIXPRODUCT&modal=detail&selectedIssue=SIXPRODUCT-2524
        /// </summary>
        public bool IsMoveOutRefundAdjusted { get; set; }
        public Guid ReversalInvoiceRefId { get; set; }
    }


    [Table("MergedInvoiceLeaseInfo")]
    public class MergedInvoiceLeaseInfo
    {
        public Guid id { get; set; }
        public Guid ClientId { get; set; }
        public Guid UserId { get; set; }
        public Guid InvoiceId { get; set; }
        public long Contractid { get; set; }
        public string AdminUserName { get; set; }
        public DateTime Createddate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string ModificationHistory { get; set; }
        public DateTime InvFromDate { get; set; }
        public DateTime InvToDate { get; set; }
        public decimal IndTotalInvAmount { get; set; }
        public bool IsActiveLease { get; set; }
    }


    public class MergedInvoiceGridLeaseInfo
    {
        public Guid id { get; set; }
        public Guid InvoiceGuid { get; set; }
        public long ContractId { get; set; }
        public string AdminUserName { get; set; }
        public string ClientContractNo { get; set; }
        public DateTime Createddate { get; set; }
        public string ClientInvoiceNo { get; set; }
        public string UnitNumber { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceTax { get; set; }
        public decimal UnitPriceWithTax { get; set; }
        public string UnitAndBuilding { get; set; }
        public string LicenseAgreementPath { get; set; }


    }

    [Table("MergedTenantLeaseInfo")]
    public class MergedTenantLeaseInfo
    {
        public Guid id { get; set; }
        public Guid ClientId { get; set; }
        public Guid UserId { get; set; }
        public long Contractid { get; set; }
        public string AdminUserName { get; set; }
        public DateTime Createddate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string ModificationHistory { get; set; }
        public bool IsActiveLease { get; set; }
        public bool IsMerged { get; set; }
        public long MergeGroupId { get; set; }

    }
 }


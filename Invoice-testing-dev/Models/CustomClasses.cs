using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_testing_dev.Models;

namespace SixStorage.AutoInvoice.WebApi.Shared.DTOs.AutoInvoice;

public partial class ClientOverallConfig
{
    // public CaddyClientDetail caddyclientdetail { get; set; }
    // public ClientExternalServicesconfig clientExternalServicesconfig { get; set; }
    public ClientApplicationmenuconfig clientApplicationmenuconfig { get; set; }
    public ClientAppAndDocumentConfig clientAppAndDocumentConfig { get; set; }

    public AccountSettingsTable4 AccountSettingsTable4 { get; set; }
    // public CaddyClientProductPlanDetial CaddyProductPlanDetail { get; set; }
    // public List<LanguagesDetails> LanguagesDetails { get; set; }
}

public class TransferTenantUnitDetail
{
    public long TransferFromContractId { get; set; }
    public long TransferToContractId { get; set; }
    public string TranferFromUnitNumber { get; set; }
    public string TransferToUnitNumber { get; set; }
    public Guid TransferFromUnitGuid { get; set; }
    public Guid TransferToUnitGuid { get; set; }
    public decimal TransferredInvoiceDue { get; set; }
    public decimal TransferAppliedCredit { get; set; }
    public decimal TransferRefundDue { get; set; }
}

public partial class UnitDetails
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public UnitDetails()
    {
    }

    public Guid id { get; set; }

    public string UnitNumber { get; set; }

    public decimal Unitprice { get; set; }

    public decimal? Width { get; set; }

    public decimal? Depth { get; set; }

    public decimal? Height { get; set; }

    public string UnitSize { get; set; }
    public string UnitCubicSize { get; set; }
}

public partial class TaxMaster
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }

    public string Category { get; set; }

    public decimal Tax1 { get; set; }

    public decimal? Tax2 { get; set; }

    public decimal? Tax3 { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public DateTime? EffectiveTo { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool Deleted { get; set; }

    public bool IsActive { get; set; }
    public Guid locationId { get; set; }

    //Added TaxName and IsDefault parameters for Multiple tax implementation
    public string TaxName { get; set; }
    public bool IsDefault { get; set; }
    // public virtual Location Location { get; set; } // by prakash on 12-02-2018.
    //public virtual CaddyClientDetail CaddyClientDetail { get; set; }
}

public class NewInvoicePDFModel
{
    public Guid? Id { get; set; }
    public Guid? ItemId { get; set; }
    public Guid? ItemServiceId { get; set; }
    public string Item { get; set; }
    public string SubCategory { get; set; }
    public string Description { get; set; }
    public decimal? Price { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Discount { get; set; }
    public decimal? DiscountTax { get; set; }
    public int ItemQty { get; set; }
    public decimal? totAmt { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int OrderNo { get; set; }//This we are using for Display in Invoice PDF Rent,Insurance,Merchandise and Services like this.
    public bool isThirdParty { get; set; }
    public string DescriptionInches { get; set; }
    public long ContractID { get; set; }
    public string DescriptionSquareMeter { get; set; }
    public string DescriptionCubicSize { get; set; }
    public string DescriptionCubicMeter { get; set; }
    public string DescriptionCubicFeet { get; set; }
    public bool callingForReceiptPdf { get; set; }
    public Guid? ItemMasterId { get; set; }
}

public partial class ContractDetails
{
    public ContractDetails()
    {
    }

    public long Id { get; set; }

    public Guid ContractGuid { get; set; }
    public string ClientContractNo { get; set; }
}

public partial class ContractBankDetails
{
    public ContractBankDetails()
    {
        this.CreatedDate = DateTime.Now;
        this.ModifiedDate = DateTime.Now;
        this.IsDeleted = false;
        this.Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }

    public long ContractId { get; set; }

    public string BankName { get; set; }

    public string NameOnAccount { get; set; }

    public string AccountNo { get; set; }

    public string SortCode { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string BankAddress { get; set; }

    public virtual ContractDetails ContractDetails { get; set; }
}

public class LeaseInvoicePastDue
{
    public string UnitNumber { get; set; }
    public long contractid { get; set; }
    public DateTime? InvoiceFromDate { get; set; }
    public DateTime? InvoiceToDate { get; set; }
    public DateTime? InvoiceDueDate { get; set; }
    public decimal? Balance { get; set; }
    public decimal? LatefeebyBalance { get; set; }
}

public partial class ContractInsurance
{
    public Guid ID { get; set; }

    public long ContractID { get; set; }

    public Guid InsPremiumId { get; set; }

    public string PolicyNumber { get; set; }

    public decimal InsuranceAmount { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public DateTime RenewalDate { get; set; }

    public bool IsExpired { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public bool Isdeleted { get; set; }

    public decimal Premium { get; set; }

    public string ModificationHistory { get; set; }

    public Guid? guidPayments { get; set; }
    /// <summary>
    /// IPTPercentage column sum of applied tax percentage
    /// Comments added by prakash during sprint 30 on 19-04-2019.
    /// refer invoice applied tax percentage table sum of invoiceitemcategory=='INSURANCE'
    /// </summary>
    public decimal? IPTPercentage { get; set; }

    public decimal? IPTAmount { get; set; }

    public Guid? InvoiceId { get; set; }

    //public virtual ContractDetails ContractDetails { get; set; }

    //public virtual InsurancePremiumMaster InsurancePremiumMaster { get; set; }

    public bool IsThirdParty { get; set; }
    //  public System.Guid InsCompanyID { get; set; }
    public bool IsInsuranceStopped { get; set; }
}
public class InvoiceAppliedTaxDetail
{
    public InvoiceAppliedTaxDetail()
    {
        DiscountTax = 0;
        IsActive = true;
        IsDeleted = false;
        CreatedDate = DateTime.UtcNow;
        ModifiedDate = DateTime.UtcNow;
        InvoiceTaxId = Guid.NewGuid();
        ContractId = 0;
    }
    public Guid InvoiceTaxId { get; set; }
    public Guid InvoiceId { get; set; }
    /// <summary>
    /// ContractID value should be zero for other than Lease based invoices.
    /// </summary>
    public long ContractId { get; set; }
    public Guid ClientId { get; set; }
    /// <summary>
    /// Category column value ex: LEASE,MERCHANDISE,RESERVATION;
    /// </summary>
    public string Category { get; set; }
    /// <summary>
    /// InvoiceItemCategory value ex: RENT,SERVICE,MERCHANDISE,RESERVATION,DEPOST,INSURANCE 
    /// </summary>
    public string InvoiceItemCategory { get; set; }
    public Guid? ItemServiceId { get; set; }
    public Guid? InvoiceItemId { get; set; }
    public Guid TaxMasterId { get; set; }
    public string TaxName { get; set; }
    public decimal TaxPercentage { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal DiscountTax { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}

public partial class ClientApplicationmenuconfig
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public string ClientSupportEmail { get; set; }
    public string ClientAdminEmail { get; set; }
    public bool IsReservationOptional { get; set; }
    public bool IsServiceOptional { get; set; }
    public bool IsMerchandiseOptinal { get; set; }
    public bool IsInsuranceOptinal { get; set; }
    public bool IsAdvanceOptinal { get; set; }
    public bool DisplayTax { get; set; }
    public bool IsSCSMoveinFileCreation { get; set; }
    public bool EnableMoveInEmail { get; set; }
    public bool EnablePaymentEmail { get; set; }
    public bool EnableInvoiceEmail { get; set; }
    public bool EnableReservationEmail { get; set; }
    public bool EnableMoveOutEmail { get; set; }
    public bool DisplayMerchandiseDesign { get; set; }
    public bool DisplayServicesDesign { get; set; }
    public bool DisplayUnitDesign { get; set; }
    public bool IsEnCultureEnabled { get; set; }
    public bool DisplayTransactionalDetails { get; set; }
    public bool IsGateAccessCodeMandatory { get; set; }
    public bool EnableSendMoveInLoginDetail { get; set; }
    public bool DisplayBankDetails { get; set; }
    public bool SendNoticeEmails { get; set; }
    public bool DisplayTransactionMenu { get; set; }
    public bool IsBluGoldLeaseDocument { get; set; }
    public bool DisplayBulkPaymentOption { get; set; }
    public string ClientCulture { get; set; }
    public string TenantIDPreFix { get; set; }
    public string CurrencyUnitValue { get; set; }
    public string CurrencySubUnitValue { get; set; }
    public string SiteLogoPath { get; set; }
    public string DisplayUnitBasedOn { get; set; }
    public bool DisplaySecurityQuestions { get; set; }
    public string LeaseInvoicePrefix { get; set; }
    public string LeaseInvoiceSuffix { get; set; }
    public string ReceiptPrefix { get; set; }
    public string ReservationNumberPrefix { get; set; }
    public string UnitMeasurementTypeIn { get; set; }
    public bool EnableMoveInInvoicePreview { get; set; }
    public bool EnableMoveInPrintLeasePreview { get; set; }
    public bool EnableBulkUploadsOption { get; set; }
    //public string DepositText { get; set; }
    public bool ClientAutoInvoiceScheduler { get; set; }
    public string LeaseAgreementText { get; set; }
    public bool EnableLateFee { get; set; }
    public bool DownloadLeaseDocuemntAfterPayment { get; set; }
    public bool CustomerPortalMoveInHeaderText { get; set; }
    public bool IsCollectingReservationFee { get; set; }
    public bool IsDisplayOnlyActiveLeads { get; set; }
    public int NoOfDaysForInvBeforeNBD { get; set; }
    public int NoOfDaysForGracePeriod { get; set; }
    public bool PayAdditionalRent { get; set; }
    public bool AddMonthsrent { get; set; }
    public bool DoCopyEmailToAdmin { get; set; }
    public bool MinimumLaterFeeValueIsPercentage { get; set; }
    public decimal MinimumLaterFeeValue { get; set; }

    /// <summary>
    /// Nagur : Sprint-16 for making invoices and receipts display by account setting level
    /// </summary>
    public bool IsDisplayInvoice { get; set; }
    public bool IsDisplayReceipt { get; set; }
    /// <summary>
    /// Added by nagur for Client AutoEmail Scheduler.
    /// </summary>
    public bool IsClientAutoEmailScheduler { get; set; }
    public bool IsReminderEmailCopytoAdmin { get; set; }
    public bool IsEnabledBatchPrinting { get; set; }//added by prakash during spring 17 on 12-06-2018
    public bool CustomerPortalEnableSitemap { get; set; }
    /// <summary>
    ///  added by prakash during sprint 20 on 02-08-2018 for Accounting version 2 changes.
    /// </summary>
    public bool EnabledAccountingVersion2 { get; set; }
    public bool DisplayReservationInCustomerPortal { get; set; }
    public bool DisplayOnlineMoveinCustomerPortal { get; set; }
    public bool EnableReservationWaitingList { get; set; }
    public bool EnableCustomerPortalPayLater { get; set; }
    public bool RollbackInvoiceWithSameInvoiceNumber { get; set; }
    public bool IsEmailActivityEnabled { get; set; }
    public bool IsEnableGrantAutomatic { get; set; }
    ///Added by chanakya for displaying the TimeZones in Customer Portal sprint21
    public bool DisplayTimeZoneInCustomerPortal { get; set; }
    ///<summary>
    ///Added by Chanakya for hiding the Occupied and Reserved Unit group in Customer Portal  during sprint-22        
    /// </summary>
    public bool HideOccupiedUnitsInCustomerPortal { get; set; }
    public bool HideReservedUnitsInCustomerPortal { get; set; }

    public bool EnabledCreditNoteOption { get; set; }
    public bool ClientAutoInvoiceSchedulerForAllLeases { get; set; }
    ///<summary>
    ///Added by Sella for Electronic Invoice XML     
    /// </summary>
    public bool EnableElectronicXMLInvoice { get; set; }
    public bool IsUnitsGroupBySizeInCustomerPortal { get; set; }
    /// <summary>
    /// Prakash added this conditional parameter for enable new accounting process into old client who is using old accounting procedures.
    /// added during sprint 27,28 on 15-03-2019.
    /// EnableAccount2ConceptToAccount1 operate below scenario.
    /// 1) Multiple invoice payment into single receipt.
    /// 2) Advance only receipt.
    /// 3) Move out refund and reversal invoice.
    /// 4) Advance based adjustment no receipt.
    /// 5) 
    /// </summary>
    public bool EnableAccount2ConceptToAccount1 { get; set; }
    /// <summary>
    /// EnableToCreateCreditInsteadReversalInvoice this boolean make to create credit invoice instead of reversal invoice.
    /// during move out. If it is <see langword="true"/> then pdf items will display with minus value.
    /// And this column only for Old accounting user and only for generating credit invoice with minus value or not.
    /// Do not use this any of the place other than reversal invoice pdf stored procedure and pdf file.
    /// </summary>
    public bool EnableToCreateCreditInsteadReversalInvoice { get; set; }
    /// <summary>
    /// EnableCreateNewLeaseInAccount2 this boolean will make all new lease and it's transaction grid will display with new accounting system.
    /// if EnableCreateNewLeaseInAccount2=true this only for displaying CL page transaction grid & statement should display Accounting V2 transaction  grid 
    /// </summary>
    public bool EnableCreateNewLeaseInAccount2 { get; set; }
    /// <summary>
    /// Prakash added this column for client who what to use multiple tax
    /// based this column all tax calculation process will work.
    /// and its having dependency with DisplayTax column
    /// If Display tax enabled then only this multiple tax functionality should work.
    /// </summary>
    public bool IsEnabledMultipleTax { get; set; }
    /// <summary>
    /// Added by Desala on 20-05-2019 because Accountstetting page if client enabled unitprice with tax 
    /// then this column need to update.based on this column only future invoice unit price will get.
    /// </summary>
    public bool IsEnabledUnitPriceWithTax { get; set; }
    // public bool IsDisplayUnitSizeRoundup { get; set; } // Removed by RLN Since we are not going to continue this feature for current release

    public bool IsScheduledMoveOutEnabled { get; set; }
    public bool IsInvoiceGenerationNotMovedOutEnabled { get; set; }
    public Int16 ScheduleMoveoutMinNoticePeriod { get; set; }
    public Int16 ScheduleMoveoutMaxNoticePeriod { get; set; }
    public bool IsTenantCanMoveOutAnyPointOfTimeEnabled { get; set; }
    public bool IsProrateMoveOutEnabled { get; set; }
    public bool IsChargeTenantOnMoveOutDayEnabled { get; set; }
    public bool IsAdjustDepositWithUnpaidBalanceEnabled { get; set; }
    public bool IsEnabledQuickBooks { get; set; }
    public bool OnlineMoveInEmail { get; set; }

}

public partial class Location
{
    public Guid id { get; set; }
    public Guid CountryID { get; set; }
    public Guid ClientId { get; set; }
    public string Location1 { get; set; }
    public string LocAddress { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool? deleted { get; set; }
    public string City { get; set; }
    public string Address2 { get; set; }
    public string Zipcode { get; set; }
    //public virtual CaddyClientDetail CaddyClientDetail { get; set; }
    //public virtual Country Country { get; set; }
    public string FacilityTaxId { get; set; }
    public string LocState { get; set; }
    public string CountryName { get; set; }
}

public partial class UnitWithStatus
{
    public Guid id { get; set; }
    public string Type { get; set; }
    public string Value { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid? ClientId { get; set; }
    public bool EnableWeightForthisCategory { get; set; }
    public string DisplayStorageTypeBasedOn_MetricSize { get; set; }
    public string DisplayStorageTypeWeightBasedOn_MetricSize { get; set; }
    public string DisplayStorageTypeMeasurementDimensionFormat { get; set; }
    public string DisplayAreaOrVolumeMeasurementFormat { get; set; }
    public bool IsMoveable { get; set; }
}

public class AccountSettingsTable4
{
    public Guid id { get; set; }
    public Guid ClientId { get; set; }
    public bool IsDigitalSignatureEnabled { get; set; }
    public string AdminSignaturePath { get; set; }
    public bool EnableAutoinvoiceEmail { get; set; }
    public bool EnableConsolidateEmailtoAdmin { get; set; }
    public bool Is28DaysPriceMonthly { get; set; }
    public string TextForTax { get; set; }
    public bool IsEmailMandatoryForPaymentGateway { get; set; }
    // Added by krisha for digital signature for customer portal ticket no :SIXPRODUCT-1993
    public bool IsDigitalSignatureCustomerPortalEnabled { get; set; }
    public bool DisplayLocBasedAddress { get; set; }
    public bool IsDisplayRentWithTaxCustomerPortal { get; set; }
    public bool IsSMSEnabledForAccount { get; set; }
    public bool SMSEnableforMoveincustomerportal { get; set; }
    public bool SMSEnableforPaynowcustomerportal { get; set; }
    public bool SMSEnableforReservationcustomerportal { get; set; }
    public bool SMSEnableforScheduledmoveoutAdmin { get; set; }
    public bool SMSEnableforRentreminder { get; set; }
    public bool SMSEnableforAutoInvoice { get; set; }
    public bool SMSEnableforAutopayment { get; set; }
    public bool SMSEnableforSaveCard { get; set; }
    public bool HideAdditionalMonthsInCustomerPortal { get; set; }
    public string ClientISOCountryCode { get; set; }
    /// <summary>
    /// Nagur added this column for enabling and disabling 6Storage gates
    /// </summary>
    public bool IsSixStorageSecurityGatesEnabled { get; set; }
    public bool IsAutoLockEnabled { get; set; }
    public bool IsAutoLockEmailEnabled { get; set; }
    public bool IsAutoLockSMSEnabled { get; set; }
    public int AutoLockGraceDays { get; set; }
    public bool IsScheduledMoveOutEnabled { get; set; }
    public bool IsActivateNewUI { get; set; }
    public bool EnableAutoPayInvoiceTenantEmail { get; set; }
    public bool EnableAutoPayReceiptTenantEmail { get; set; }
    public bool IsExistingCustomer { get; set; }
    //Added below for statistic purpose
    public bool IsActivatedNewPluginForTenantPortal { get; set; }
    public bool IsNokeGateEnabled { get; set; }
    public bool IsMoveInAutoPayMandatoryForCustomerPortal { get; set; }
    public bool IsStorageCalculatorEnabled { get; set; }
    public int DefaultOnlineMoveinAllowDaysCount { get; set; }
    public bool EnableNotification { get; set; }
    public Guid WebsiteTemplateId { get; set; }
    public bool IsTermsandConditionMandatory { get; set; }
    public bool StopAutoInvShedMoveOutExist { get; set; }


    public bool DisplayLocationInListingPage { get; set; }
    public bool DisplayBuildingInListingPage { get; set; }
    public bool DisplayMoveIndateInListingPage { get; set; }
    public bool DisplayAvailableSizesInListingPage { get; set; }
    public bool DisplayUnitTypeInListingPage { get; set; }
    public bool DisplayAmenitiesInListingPage { get; set; }

    public bool IsSentinelGatesEnabled { get; set; }
    public string SentinelVersionNumber { get; set; }
    public bool IsEnabledAccessCardNumber { get; set; }
    public bool DisplayTenantPortalGrouped { get; set; }
    public bool IsLocationSpecificPaymentGatewayEnabled { get; set; }
    public bool IsEnabledSharedUnits { get; set; }
    public bool IsSaltoGatesEnabled { get; set; }
    public string SaltoFileName { get; set; }
    public bool IsDirectDebitEnabled { get; set; }
    public bool IsSupremaGatesEnabled { get; set; }
    public decimal MinAmtForAutolock { get; set; }
    public string WebhookEndpoint { get; set; }
    public bool IsConfidentialSSN { get; set; }
    public string WebhookSecretKey { get; set; }
    public bool IsRequestInventoryV2 { get; set; }
    public bool IsActivatedInventoryV2 { get; set; }
    public bool IsSavedCardsByDefault { get; set; }
}

public class ClientFieldConfig
{
    public Guid id { get; set; }

    public Guid TableID { get; set; }

    public string UserOption { get; set; }

    public bool VisibleStatus { get; set; }

    public bool IsDeleted { get; set; }

    public string DisplayText { get; set; }

    public bool IsAdminMandatoryVisible { get; set; } //Manoj: Added for Admin mandatory

    public bool IsCustomerMandatoryVisible { get; set; }
}

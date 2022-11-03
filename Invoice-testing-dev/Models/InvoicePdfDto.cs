﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_testing_dev.Models;

namespace SixStorage.AutoInvoice.WebApi.Shared.DTOs.AutoInvoice;

public class InvoicePdfDto
{
    public InvoicePdfDto()
    {
        ClientDetails = new PersonalDetails();
        CustomerDetails = new PersonalDetails();
        RemitPaymentTo = new PersonalDetails();
        PastDueList = new List<PastDueDetails>();
        InvoiceItemList = new List<InvoiceItemDetails>();
        LanguageCustomizationList = new List<InvoiceLanguageCustomization>();
        DocumentConfig = new ClientAppAndDocumentConfig();
        clientPaymentMode = new List<ClientPaymentMode>();
        //InvoiceDetail = new ContractInvoiceDetails();
}

    public bool GetDictionaryVisibleStatus(string keyword)
    {
        return GetDictionaryVisibility(keyword);
    }

    public bool GetDictionaryVisibility(string keyword)
    {
        bool result = false;
        try
        {
            if (LanguageCustomizationList != null)
            {
                if (LanguageCustomizationList.Count > 0)
                {
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        keyword = keyword.Trim();
                        var firstData = LanguageCustomizationList.FirstOrDefault(x => x.KeywordName.ToLower() == keyword.ToLower());
                        if (firstData != null)
                        {
                            result = firstData.VisibleStatus;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            //objCommon.WriteExceptionLog(ex, "GetDicionaryVisibleStatus");
            return false;
        }
        return result;
    }
    public string GetDictionaryItem(string keywordName)
    {
        string result = string.Empty;
        try
        {
            if (LanguageCustomizationList.Count > 0)
            {
                if (!string.IsNullOrEmpty(keywordName))
                {
                    keywordName = keywordName.Trim();
                    var firstData = LanguageCustomizationList.FirstOrDefault(x => x.KeywordName.ToLower() == keywordName.ToLower());
                    if (firstData != null)
                    {
                        result = firstData.CustomValue;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            //objCommon.WriteExceptionLog(ex, "GetDictionaryItem");
            return String.Empty;
        }
        return result;
    }
    public string DateFormat
    {
        get
        {
            return "MM/dd/yyyy";
        }
    }
    public string CurrentDateStr
    {
        get
        {
            return DateTime.Today.ToString(DateFormat);
        }
    }

    public bool RoundOffEnabled { get; set; }
    public decimal InvTaxPercentage { get; set; }
    public bool DisplayTax { get; set; }//objOverallConfigData.clientApplicationmenuconfig.DisplayTax
    public bool IsMergedInvoice { get; set; }
    public Guid InvoiceIdGuid { get; set; }
    public long InvoiceIdNum { get; set; }
    public string? InvoiceNumber { get; set; }
    public Guid UnitIdGuid { get; set; }
    public string? UnitNumber { get; set; }
    public string? InvoiceCategory { get; set; }
    public long ContractId { get; set; }
    public string? ClientLogoPath { get; set; }
    public DateTime InvoiceDate { get; set; }
    public Location UnitLocationInfo { get; set; }
    public string InvoiceDateStr
    {
        get
        {
            return InvoiceDate.ToString(DateFormat);
        }
    }
    public string Paymenttype { get; set; }
    public string? BillingCycle { get; set; }
    public bool IsEnabledMultipleTax { get; set; }
    public string? BillingCycleType { get; set; }
    public DateTime BillingPeriodFrom { get; set; }
    public DateTime BillingPeriodTo { get; set; }
    public string BillingPeriodFromStr
    {
        get
        {
            return BillingPeriodFrom.ToString(DateFormat);
        }
    }
    public string BillingPeriodToStr
    {
        get
        {
            return BillingPeriodTo.ToString(DateFormat);
        }
    }
    public DateTime? ScheduledMoveOut { get; set; }
    public string ScheduledMoveOutStr
    {
        get
        {
            return ScheduledMoveOut?.ToString(DateFormat) ?? string.Empty;
        }
    }
    public DateTime PaymentDueDate { get; set; }
    public string PaymentDueDateStr
    {
        get
        {
            return PaymentDueDate.ToString(DateFormat);
        }
    }

    public decimal PastDueBlanceTotal
    {
        get
        {
            return PastDueList?.Sum(t => t.TotalDue) ?? 0;
        }
    }

    public decimal InvoiceSubTotal
    {
        get
        {
            return InvoiceItemList?.Sum(t => t.GrossCost) ?? 0;
        }
    }

    public decimal InvoiceTaxTotal { get; set; }
    public decimal InvoiceCurrentDue
    {
        get
        {
            return InvoiceSubTotal + InvoiceTaxTotal;
        }
    }
    public decimal InvoiceTotalDue
    {
        get
        {
            return InvoiceCurrentDue + PastDueBlanceTotal;
        }
    }

    public decimal Insurance { get; set; } //TODO added newly
    public decimal lateFeeAmount { get; set; } //TODO added newly

    public string? FooterText1 { get; set; }
    public string? FooterText2 { get; set; }

    public string TenantId { get; set; } // TODO is it string or GUID?

    public string CultureCurrencySymbol { get; set; }

    public string Building { get; set; }

    public string hideandshow { get; set; }
    public string exportHideandshow { get; set; }

    public CultureInfo CurrentCulture { get; set; }
    public UnitWithStatus UnitStorageTypeInfo { get; set; }
    public PersonalDetails ClientDetails { get; set; }
    public PersonalDetails CustomerDetails { get; set; }
    public PersonalDetails RemitPaymentTo { get; set; }
    public List<PastDueDetails> PastDueList { get; set; }
    public List<InvoiceItemDetails> InvoiceItemList { get; set; }
    public List<InvoiceLanguageCustomization> LanguageCustomizationList { get; set; }
    public ClientAppAndDocumentConfig DocumentConfig { get; set; }
    public List<ClientPaymentMode> clientPaymentMode { get; set; }
    public ContractInvoiceDetails InvoiceDetail { get; set; }
    public List<InvoiceAppliedTaxDetail> InvoiceAppliedTaxDetails { get; set; }

    public List<ClientFieldConfig> optionalFields { get; set; }
    public ClientOverallConfig ConfigurationData { get; set; }
}

public class PersonalDetails
{
    public Guid Id { get; set; }
    public string? CompanyName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? Zipcode { get; set; }
    public string? MobileNumber { get; set; }
    public string? EmailAddress { get; set; }
    public string? TaxNumber { get; set; }
}

public class PastDueDetails
{
    public Guid InvoiceIdGuid { get; set; }
    public long InvoiceIdNum { get; set; }
    public long ContractIdNum { get; set; }
    public string? UnitNumber { get; set; }
    public DateTime BillingPeriodFrom { get; set; }
    public DateTime BillingPeriodTo { get; set; }
    public string BillingPeriodStr
    {
        get
        {
            string dateFormat = new InvoicePdfDto().DateFormat;
            return $"{BillingPeriodFrom.ToString(dateFormat)} - {BillingPeriodTo.ToString(dateFormat)}";
        }
    }
    public decimal Balance { get; set; }
    public decimal LateFee { get; set; }
    public decimal TotalDue
    {
        get
        {
            return Balance + LateFee;
        }
    }
}

public class InvoiceItemDetails
{
    public Guid InvoiceIdGuid { get; set; }
    public long InvoiceIdNum { get; set; }
    public string? ItemDescription { get; set; }
    public int Quantity { get; set; }
    public decimal GrossCost { get; set; }
}

public static class CurrencyHelper
{
    public static string GetStringValue(decimal amount)
    {
        return $"${amount.ToString("0.00")}";
    }
}

public class InvoiceLanguageCustomization
{
    public string KeywordName { get; set; }
    public string CustomValue { get; set; }
    public bool VisibleStatus { get; set; }
}


using System.ComponentModel.DataAnnotations;

namespace Invoice_testing_dev.Models
{
    public partial class ClientAppAndDocumentConfig
    {
        public ClientAppAndDocumentConfig()
        {
            this.IsDeleted = false;
            this.CreatedDate = DateTime.Now;
            this.ModifiedDate = DateTime.Now;
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }
        public string InvoiceTopCompanyName { get; set; }
        public string InvoiceTopAddress { get; set; }
        public string InvoiceTopZipcode { get; set; }
        public string InvoiceTopMobile { get; set; }
        public string InvioceTopEmail { get; set; }
        public string InvoicePermitPayCompanyName { get; set; }
        public string InvoicePermitPayAddress { get; set; }
        public string InvoicePermitZipcode { get; set; }
        public string InvoicePermitMobileNo { get; set; }
        public string InvoiceBankName { get; set; }
        public string InvoiceAccountNumber { get; set; }
        public string InvoiceSortCode { get; set; }
        public string InvoiceSwiftOrBIC { get; set; }
        public string InvoiceIBAN { get; set; }
        public string InvoiceFooterText1 { get; set; }
        public string InvoiceFooterText2 { get; set; }
        public string InvoiceVATNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string LogfilePath { get; set; }
        public string DocumentLogoPath { get; set; }

        public string SiteLandingURL { get; set; }
        // public long InvoiceNo { get; set; }

        public string StorageWebsite { get; set; }
        //public virtual CaddyClientDetail CaddyClientDetail { get; set; }
        public string RentalOfRoom { get; set; }
        public string AdvancePaymentDiscount { get; set; }
        public string DepositText { get; set; }
        public bool NeedWebsitebyCaddy { get; set; }
        public int RegistrationPhaseinNo { get; set; }
        //Added by prakash for Lastiva  Path release regarding Document Footer.on 05-06-2017
        public string LeaseAndOtherDocumentFooterText { get; set; }
        public bool IsLeaseAndOtherDocumentFooterCustomized { get; set; }
        public bool IsLeaseAndOtherDocumentFooterBorderRequired { get; set; }
        public bool EnableInvoiceRoundoffValue { get; set; }
        public decimal InvoiceRoundoffRange01to04 { get; set; }
        public decimal InvoiceRoundoffRange05to09 { get; set; }
        public bool UploadUnitsClientFollowUp { get; set; }
        public bool UploadUnitsClientFollowUpSelectedStatus { get; set; }
        public bool IsLeaseAgreementFooterPageNumberEnabled { get; set; }
        public string QRCodeimg { get; set; }
    }
}

namespace Invoice_testing_dev.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ClientPaymentMode")]
    public class ClientPaymentMode
    {
        public ClientPaymentMode()
        {
            this.IsDisplayInCustomerPortal = true;
        }

        [Key]
        public Guid ClientPaymodeId { get; set; }

        [ForeignKey("PaymentModeMaster")]
        public Guid AdminPaymodeId { get; set; }

        [ForeignKey("CaddyClientDetail")]
        public Guid ClientId { get; set; }

        public string ValueText { get; set; }

        public string DisplayText { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsCommon { get; set; }

        public bool IsDisplayMerchandise { get; set; }

        public bool IsDisplayInReservation { get; set; }

        public bool IsDisplayInRefund { get; set; }

        public bool IsDisplayInPaymentSearch { get; set; }
        public bool IsDisplayInCustomerPortal { get; set; }
        //public virtual CaddyClientDetail CaddyClientDetail { get; set; }
        //public virtual PaymentModeMaster PaymentModeMaster { get; set; }
    }

    public class DropdownPaymentMode
    {
        public DropdownPaymentMode(string value = "", string text = "--Select--")
        {
            this.Id = value;
            this.Text = text;
        }

        public string Id { get; set; }
        public string Text { get; set; }
    }

    public enum ClientPaymentModeCategory
    {
        COMMOM, MERCHANDISE, LEAD, REFUND, PAYMENTSEARCH, CUSTOMERPORTAL
    }
    
}

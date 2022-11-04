using Invoice_testing_dev.Models;
using SixStorage.AutoInvoice.WebApi.Shared.DTOs.AutoInvoice;

namespace SixStorage.AutoInvoice.WebApi.Shared.DTOs.AutoInvoice
{
    public static class InvoiceGenerationHelper
    {
        public static string ReturnInvoicePDFDescription(
            string DISPLAYUNITBASEDON, 
            NewInvoicePDFModel objItem, 
            ClientAppAndDocumentConfig documentConfig, 
            string objectDescription)
        {
            if (objItem.Item.ToUpper() != "MERCHANDISE" && objItem.Item.ToUpper() != "SERVICE")
            {
                if (DISPLAYUNITBASEDON == "SQFT")
                {
                    objectDescription = objItem.DescriptionInches;
                }
                else if (DISPLAYUNITBASEDON == "MQ")
                {
                    objectDescription = objItem.DescriptionSquareMeter;
                }
                else if (DISPLAYUNITBASEDON == "QMT")
                {
                    objectDescription = objItem.DescriptionCubicMeter;
                }
                else if (DISPLAYUNITBASEDON == "QFT")
                {
                    objectDescription = objItem.DescriptionCubicFeet;
                }
                else if (DISPLAYUNITBASEDON == "QSIZE")
                {
                    objectDescription = objItem.DescriptionCubicSize;
                }
                else
                {
                    //TODO
                }
            }

            if (objItem.Item.ToUpper() == "DEPOSIT")
            {
                objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? documentConfig.DepositText : objItem.Description;
                if (DISPLAYUNITBASEDON == "SQFT")
                {
                    objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? objItem.DescriptionInches.Replace("Deposit", documentConfig.DepositText) : objItem.DescriptionInches;
                }
                else if (DISPLAYUNITBASEDON == "MQ")
                {
                    objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? objItem.DescriptionSquareMeter.Replace("Deposit", documentConfig.DepositText) : objItem.DescriptionSquareMeter;
                }
                else if (DISPLAYUNITBASEDON == "QMT")
                {
                    if (string.IsNullOrEmpty(objItem.DescriptionCubicMeter))
                    {
                        objectDescription = documentConfig.DepositText;
                    }
                    else
                    {
                        objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? objItem.DescriptionCubicMeter.Replace("Deposit", documentConfig.DepositText) : objItem.DescriptionCubicMeter;
                    }
                }
                else if (DISPLAYUNITBASEDON == "QFT")
                {
                    if (string.IsNullOrEmpty(objItem.DescriptionCubicFeet))
                    {
                        objectDescription = documentConfig.DepositText;
                    }
                    else
                    {
                        objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? objItem.DescriptionCubicFeet.Replace("Deposit", documentConfig.DepositText) : objItem.DescriptionCubicFeet;
                    }
                }
                else if (DISPLAYUNITBASEDON == "QSIZE")
                {
                    if (!string.IsNullOrEmpty(objItem.DescriptionCubicSize))
                    {
                        objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? objItem.DescriptionCubicSize.Replace("Deposit", documentConfig.DepositText) : objItem.DescriptionCubicSize;
                    }
                    else
                    {
                        objectDescription = documentConfig.DepositText;
                    }
                }
                else if (DISPLAYUNITBASEDON == "SIZE")
                {
                    objectDescription = !string.IsNullOrEmpty(documentConfig.DepositText) ? objItem.Description.Replace("Deposit", documentConfig.DepositText) : objItem.Description;
                }
                else
                {
                    //ToDo
                }
            }
            return objectDescription;
        }
    }
}

﻿using InvoiceSdk.Fluent;
using InvoiceSdk.Models.Payments;
using InvoiceSdk.Renderer.Configuration;
using Font = InvoiceSdk.Renderer.Internal.Font;

namespace BusinessLogic
{
    public static class InvoiceGenerator
    {
        public static Address generateAddressForCustomer(string street, string country, string city, string zipCode, string phone)
        {
            return new Address()
            {
                Street = street,
                Country = country,
                City = city,
                ZipCode = zipCode,
                Phone = phone
            };
        }

        public static Payment generatePayment(Guid id, decimal amount, string paymentMethod)
        {
            return new Payment()
            {
                Id = Guid.NewGuid(),
                InvoiceId = id,
                Amount = amount,
                Method = new() { Name = paymentMethod },
                PaidAt = DateTime.Now,
                Status = PaymentStatus.Paid
            };
        }

        public static InvoiceConfiguration generateConfiguration(string font, string hexColor, string sellerHeader, string buyerHeader, string itemHeader,
            string alertWithoutItems, string alertItemsHeader, string alertWithoutPayments, string alertPaymentHeader, string paymentHeader, string finalText)
        {
            var invoiceConfiguration = InvoiceConfigurationFactory.CreateConfiguration();

            if (!string.IsNullOrEmpty(font))
            {
                invoiceConfiguration.WithGlobalFont(new Font(font));
            }
            if (!string.IsNullOrEmpty(hexColor))
            {
                invoiceConfiguration
                .ConfigureHeader()
                .WithTextColor(hexColor);
            }
            if (!string.IsNullOrEmpty(sellerHeader) && !string.IsNullOrEmpty(buyerHeader))
            {
                invoiceConfiguration
                .ConfigureAddress()
                .WithHeaders(sellerHeader, buyerHeader)
                .ThatDoesNotShowLabels();
            }
            if (!string.IsNullOrEmpty(itemHeader))
            {
                invoiceConfiguration
                .ConfigureItemTable()
                .ThatDoesNotDisplayItemDescriptions()
                .WithHeader(itemHeader);
            }
            if (!string.IsNullOrEmpty(alertItemsHeader) && !string.IsNullOrEmpty(alertWithoutItems))
            {
                invoiceConfiguration
                .ConfigureItemTable()
                .ThatShowsAlertWithoutItems(alertItemsHeader, alertWithoutItems);
            }
            if (!string.IsNullOrEmpty(paymentHeader))
            {
                invoiceConfiguration
                .ConfigurePaymentTable()
                .WithHeader(paymentHeader);
            }
            if (!string.IsNullOrEmpty(alertPaymentHeader) && !string.IsNullOrEmpty(alertWithoutPayments))
            {
                invoiceConfiguration
                .ConfigurePaymentTable()
                .ThatShowsAlertWithoutItems(alertPaymentHeader, alertWithoutPayments);
            }
            if (!string.IsNullOrEmpty(finalText))
            {
                invoiceConfiguration
                .ConfigureFooter()
                .WithText(finalText);
            }

            if (!string.IsNullOrEmpty(hexColor))
            {
                invoiceConfiguration
                .ConfigureFooter()
                .WithTextColor(hexColor);
            }
            return invoiceConfiguration.Build();
        }

        public static Address generateAddressForCinema(string street,
            string country, string city, string zipCode, string phone, string companyName, string email, string state)
        {
            return new Address()
            {
                Street = street,
                Country = country,
                City = city,
                ZipCode = zipCode,
                Phone = phone,
                CompanyName = companyName,
                Email = email,
                State = state
            };
        }
    }
}

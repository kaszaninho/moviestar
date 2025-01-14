﻿using DatabaseAPI.Models.DictionaryModels;
using InvoiceSdk.Fluent;
using InvoiceSdk.Models.Payments;
using InvoiceSdk.Renderer.Configuration;
using InvoiceSdk.Renderer.Internal;
using Mono.TextTemplating;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Font = InvoiceSdk.Renderer.Internal.Font;

namespace BusinessLogic
{
    public static class InvoiceGenerator
    {
        public static InvoiceConfiguration generateConfiguration()
        {
            return InvoiceConfigurationFactory.CreateConfiguration()
                .WithGlobalFont(new Font("Calibri"))
                .ConfigureHeader()
                .WithTextColor(Color.LightBlue)

                .ConfigureAddress()
                .WithHeaders("Beneficiary", "Recipient")
                .ThatDoesNotShowLabels()

                .ConfigureLogo()
                .WithLogoHeightCm(50f)
                .WithLogoFile("E:\\Visual Studio 2022 - Projekty\\ProjektInzynierski\\PortalWWW\\wwwroot\\css\\photos\\LOGO.png")

                .ConfigureItemTable()
                .ThatDoesNotDisplayItemDescriptions()
                .WithHeader("Tickets")
                .ThatShowsAlertWithoutItems("No items!", "You did not purchase any goods or services!")

                .ConfigurePaymentTable()
                .ThatShowsAlertWithoutItems("No payments!", "You did not make any payments for this invoice!")
                .WithHeader("Invoice Payments")

                .ConfigureFooter()
                .WithText("Come back again!")
                .WithTextColor(Color.LightBlue)

                .Build();
        }

        public static Address generateAddressForCinema()
        {
            return new Address()
            {
                CompanyName = "MovieCinema",
                Street = "Łazienki 123",
                Country = "Poland",
                City = "Nowy Sącz",
                ZipCode = "33-300",
                State = "Małopolskie",
                Phone = "+48 332 543 522"
            };
        }

        public static Address generateAddressForCustomer(string street, string country, string city, string zipCode, string state, string phone)
        {
            return new Address()
            {
                Street = street,
                Country = country,
                City = city,
                ZipCode = zipCode,
                State = state,
                Phone = phone
            };
        }

        public static Payment generatePayment(Guid id, decimal amount)
        {
            return new Payment()
            {
                Id = Guid.NewGuid(),
                InvoiceId = id,
                Amount = amount,
                Method = new() { Name = "PayPal", ProviderUrl = "paypal.com" },
                PaidAt = DateTime.Now,
                Status = PaymentStatus.Paid
            };
        }
    }
}

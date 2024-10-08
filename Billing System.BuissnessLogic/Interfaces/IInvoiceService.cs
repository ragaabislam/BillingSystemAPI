﻿using Billing_System.BuissnessLogic.DTO.Invoice;

namespace Billing_System.BuissnessLogic.Interfaces
{
    public interface IInvoiceService
    {
        void AddInvoice(InvoiceToAddDTO invoice);
        List<InvoiceToReturnDTO> GetAllInvoices();
        void DeleteInvoice(int id);
        InvoiceToReturnDTO GetInvoiceById(int id);
        List<InvoiceToReturnDTO> GetInvoicesBetweenDates(DateTime startDate, DateTime endDate);
    }
}

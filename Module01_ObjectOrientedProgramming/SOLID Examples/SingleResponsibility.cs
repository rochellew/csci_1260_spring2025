// Single responsibility principle - classes should be responsible for one task

// SRP violation
class Invoice {
    public void CalculateTotal() {}
    public void PrintInvoice() {}
}

// SRP Adherence
class InvoiceCalculator {
    public void CalculateTotal() {}
}

class InvoicePrinter {
    public void PrintInvoice() {}
}
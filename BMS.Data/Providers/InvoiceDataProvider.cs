using BMS.Data.Models;
using BMS.Data.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace BMS.Data.Providers
{
    public interface IInvoiceDataProvider
    {
        Task<InvoiceResultModel?> GenerateInvoiceAsync(int customerId, DateTime invoiceDate);
        Task<byte[]> GenerateInvoicePdfAsync(int customerId, DateTime invoiceDate);
    }

    public class InvoiceDataProvider : IInvoiceDataProvider
    {
        private readonly IDbService _dbService;

        public InvoiceDataProvider(IDbService db)
        {
            _dbService = db;
        }

        public async Task<InvoiceResultModel?> GenerateInvoiceAsync(int customerId, DateTime invoiceDate)
        {
            var customer = await _dbService.GetCustomersById(customerId);
            if (customer == null) return null;

            // Get all orders for this customer for the given date (customize as needed)
            var invoices = await _dbService.GetInvoiceByCustomerIdAndDateAsync(customerId, invoiceDate);            
            if (invoices == null) return null;

            var items = new List<InvoiceItemResultModel>();
            decimal total = 0;
            //foreach (var inv in invoices)
            //{
                foreach (var item in invoices.InvoiceItems)
                {
                    var lineTotal = item.Quantity * (float)item.Product.MRP;
                    items.Add(new InvoiceItemResultModel
                    {
                        ProductName = item.Product.Name,
                        Quantity = item.Quantity,
                        Price = item.Product.MRP,
                        Total = (decimal)lineTotal
                    });
                    total += (decimal)lineTotal;
                }
            //}

            // Example: No discount logic, but you can add as needed
            var discount = 0m;

            // Generate invoice number (simple example)
            var invoiceNumber = invoices?.InvoiceNumber ?? "N/A";

            // Optionally, save the invoice to DB here

            var rtnmodel = new InvoiceResultModel
            {
                InvoiceNumber = invoiceNumber,
                InvoiceDate = invoiceDate.ToString("yyyy-MM-dd"),
                Customer = customer,
                Items = items,
                DiscountAmount = discount,
                TotalAmount = total - discount
            };
            return rtnmodel;
        }

        public async Task<byte[]> GenerateInvoicePdfAsync(int customerId, DateTime invoiceDate)
        {
            var invoice = await GenerateInvoiceAsync(customerId, invoiceDate);
            if (invoice == null)
                return Array.Empty<byte>();

            var customer = invoice.Customer;
            var items = invoice.Items;
            string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "images", "logo-icon.png");
            var image = Image.FromFile(imgPath);

            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Width(40).Height(40).Image(image);
                        });
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("Thannickal Bakery").FontSize(18).Bold().FontColor(Color.FromHex("#31adec"));
                            col.Item().Text("Ezhamkulam Kaipattoor Rd, Adoor");
                            col.Item().Text("Kerala, Pin- 691554");
                            col.Item().Text("company@example.com");
                        });
                    });

                    page.Content().Column(col =>
                    {
                        col.Item().PaddingTop(10).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("INVOICE TO:").FontColor(Colors.Grey.Darken2).FontSize(10);
                                c.Item().Text(customer.Name).FontSize(14).Bold();
                                c.Item().Text(customer.Address ?? "");
                                c.Item().Text(customer.Email ?? "");
                            });
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text($"INVOICE #{invoice.InvoiceNumber}").FontSize(14).Bold();
                                c.Item().Text($"Date of Invoice: {invoice.InvoiceDate}");
                                c.Item().Text($"Due Date: {invoice.InvoiceDate}");
                            });
                        });

                        col.Item().PaddingTop(15).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(30); // #
                                columns.RelativeColumn(3);  // Description
                                columns.RelativeColumn(1);  // MRP
                                columns.RelativeColumn(1);  // Qty
                                columns.RelativeColumn(1);  // Discount
                                columns.RelativeColumn(1);  // Total
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("#").Bold();
                                header.Cell().Element(CellStyle).Text("DESCRIPTION").Bold();
                                header.Cell().Element(CellStyle).AlignRight().Text("MRP").Bold();
                                header.Cell().Element(CellStyle).AlignRight().Text("QTY").Bold();
                                header.Cell().Element(CellStyle).AlignRight().Text("DISCOUNT").Bold();
                                header.Cell().Element(CellStyle).AlignRight().Text("TOTAL").Bold();
                            });

                            int idx = 1;
                            foreach (var item in items)
                            {
                                table.Cell().Element(CellStyle).Text(idx++.ToString()).BackgroundColor(Color.FromHex("#31adec"));
                                table.Cell().Element(CellStyle).Text(item.ProductName).FontColor(Color.FromHex("#31adec"));
                                table.Cell().Element(CellStyle).AlignRight().Text($"₹{item.Price:N2}");
                                table.Cell().Element(CellStyle).AlignRight().Text(item.Quantity.ToString());
                                table.Cell().Element(CellStyle).AlignRight().Text("₹0.00");
                                table.Cell().Element(CellStyle).AlignRight().Text($"₹{item.Total:N2}").BackgroundColor(Color.FromHex("#31adec"));
                            }

                            static IContainer CellStyle(IContainer container)
                                => container.PaddingVertical(2).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
                        });

                        col.Item().PaddingTop(10).AlignRight().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(1);
                            });

                            table.Cell().AlignRight().Text("SUBTOTAL");
                            table.Cell().AlignRight().Text($"₹{invoice.TotalAmount:N2}");

                            table.Cell().AlignRight().Text("TAX 25%");
                            table.Cell().AlignRight().Text("₹00.00");

                            table.Cell().AlignRight().Text("Discount");
                            table.Cell().AlignRight().Text($"₹{invoice.DiscountAmount:N2}");

                            table.Cell().AlignRight().Text("GRAND TOTAL").Bold();
                            table.Cell().AlignRight().Text($"₹{invoice.TotalAmount:N2}").Bold();
                        });

                        col.Item().PaddingTop(20).Text("Thank you!").FontSize(14).Bold();
                        col.Item().PaddingTop(5).Text("NOTICE:").Bold();
                        col.Item().Text("A finance charge of 1.5% will be made on unpaid balances after 30 days.");
                    });

                    page.Footer().AlignCenter().Text("Invoice was created on a computer and is valid without the signature and seal.");
                });
            }).GeneratePdf();

            return pdf;
        }
    }
}
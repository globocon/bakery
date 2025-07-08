$(document).ready(function () {
    $('#btnGenerateInvoice').on('click', function (e) {
        e.preventDefault();

        var customerId = parseInt($('#CustomerId').val());
        var invoiceDate = $('#inputInvoiceDate').val();

        if (!customerId) {
            round_warning_noti('Please select a customer.');
            return;
        }
        if (!invoiceDate) {
            round_warning_noti('Please select an invoice date.');
            return;
        }

        var requestData = {
            CustomerId: customerId,
            InvoiceDate: invoiceDate
        };

        $.ajax({
            url: '/Invoices?handler=GenerateInvoice',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(requestData),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            success: function (response) {
                if (response.success && response.invoice) {
                    $('#invoiceResult').html(renderInvoiceHtml(response.invoice));
                    round_success_noti('Invoice generated successfully.');
                } else {
                    round_error_noti(response.message || 'Failed to generate invoice.');
                }
            },
            error: function () {
                round_error_noti('Failed to generate invoice.');
            }
        });
    });

    $('#btnDownloadInvoicePdf').on('click', function (e) {
        e.preventDefault();
        var customerId = parseInt($('#CustomerId').val());
        var invoiceDate = $('#inputInvoiceDate').val();

        if (!customerId) {
            round_warning_noti('Please select a customer.');
            return;
        }
        if (!invoiceDate) {
            round_warning_noti('Please select an invoice date.');
            return;
        }

        // Open PDF in new tab
        var url = `/Invoices?handler=DownloadInvoicePdf&customerId=${customerId}&invoiceDate=${encodeURIComponent(invoiceDate)}`;
        window.open(url, '_blank');
    });

    function renderInvoiceHtml(invoice) {
        // Render a simple invoice summary (customize as needed)
        var html = `<div class="card">
	<div class="card-body">
		<div id="invoice">
			<div class="toolbar hidden-print">
				<div class="text-end">
					<a href="javascript:;" class="btn btn-dark" onclick="window.print()"><i class="fa fa-print"></i> Print</a>
					<a href="javascript:;" class="btn btn-danger"><i class="fa fa-file-pdf-o"></i> Export as PDF</a>
				</div>
				<hr />
			</div>
			<div class="invoice overflow-auto">
				<div>
					<header>
						<div class="row">
							<div class="col">
								<a href="javascript:;">
									<img src="assets/images/logo-icon.png" width="80" alt="" />
								</a>
							</div>
							<div class="col company-details">
								<h2 class="name">
									<a href="javascript:;">
										Thannickal Bakery
									</a>
								</h2>
								<div>Ezhamkulam Kaipattoor Rd,Adoor</div>
								<div>Kerala, Pin- 691554</div>
								<div>company@example.com</div>
							</div>
						</div>
					</header>
					<main>
						<div class="row contacts">
							<div class="col invoice-to">
								<div class="text-gray-light">INVOICE TO:</div>
								<h2 class="to">${invoice.customer.name}</h2>
								<div class="address">${invoice.customer.address}</div>
								<div class="email">
									<a href="${invoice.customer.email}">${invoice.customer.email}</a>
								</div>
							</div>
							<div class="col invoice-details">
								<h1 class="invoice-id">#${invoice.invoiceNumber}</h1>
								<div class="date">Date of Invoice: ${invoice.invoiceDate}</div>
								<div class="date">Due Date: ${invoice.invoiceDate}</div>
							</div>
						</div>
						<table>
							<thead>
								<tr>
									<th>#</th>
									<th class="text-left">DESCRIPTION</th>
									<th class="text-right">MRP</th>
									<th class="text-right">QTY</th>
									<th class="text-right">DISCOUNT</th>
									<th class="text-right">TOTAL</th>
								</tr>
							</thead>
							<tbody>`;
							invoice.items.forEach(function (item) {
								html += `<tr>
													<td class="no">01</td>
													<td class="text-left">
														<h3>${item.productName}</h3>Filled with special organic egg
													</td>
													<td class="unit">₹${item.price}</td>
													<td class="qty">${item.quantity}</td>
													<td class="unit">₹0.00</td>
													<td class="total">₹${item.total}</td>
												</tr>`;
							});
							html += `</tbody>
												<tfoot>
													<tr>
														<td colspan="2"></td>
														<td colspan="2">SUBTOTAL</td>
														<td>₹${invoice.totalAmount}</td>
													</tr>
													<tr>
														<td colspan="2"></td>
														<td colspan="2">TAX 25%</td>
														<td>₹00.00</td>
													</tr>
													<tr>
														<td colspan="2"></td>
														<td colspan="2">Discount</td>
														<td>₹${invoice.discountAmount}</td>
													</tr>
													<tr>
														<td colspan="2"></td>
														<td colspan="2">GRAND TOTAL</td>
														<td>₹${invoice.totalAmount}</td>
													</tr>
												</tfoot>
											</table>
											<div class="thanks">Thank you!</div>
											<div class="notices">
												<div>NOTICE:</div>
												<div class="notice">A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>
											</div>
										</main>
										<footer>Invoice was created on a computer and is valid without the signature and seal.</footer>
									</div>
									<!--DO NOT DELETE THIS div. IT is responsible for showing footer always at the bottom-->
									<div></div>
								</div>
							</div>
						</div>
					</div>`;
        return html;
    }
});
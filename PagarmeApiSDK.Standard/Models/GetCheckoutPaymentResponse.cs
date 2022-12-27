// <copyright file="GetCheckoutPaymentResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetCheckoutPaymentResponse.
    /// </summary>
    public class GetCheckoutPaymentResponse
    {
        private int? amount;
        private DateTime? canceledAt;
        private Models.GetCustomerResponse customer;
        private DateTime? closedAt;
        private DateTime? expiresAt;
        private Models.GetCheckoutDebitCardPaymentResponse debitCard;
        private Models.GetCheckoutBankTransferPaymentResponse bankTransfer;
        private Models.GetCheckoutPixPaymentResponse pix;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "amount", false },
            { "canceled_at", false },
            { "customer", false },
            { "closed_at", false },
            { "expires_at", false },
            { "debit_card", false },
            { "bank_transfer", false },
            { "pix", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="defaultPaymentMethod">default_payment_method.</param>
        /// <param name="successUrl">success_url.</param>
        /// <param name="paymentUrl">payment_url.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="acceptedPaymentMethods">accepted_payment_methods.</param>
        /// <param name="status">status.</param>
        /// <param name="skipCheckoutSuccessPage">skip_checkout_success_page.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="customerEditable">customer_editable.</param>
        /// <param name="customer">customer.</param>
        /// <param name="billingaddress">billingaddress.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="billingAddressEditable">billing_address_editable.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="shippable">shippable.</param>
        /// <param name="closedAt">closed_at.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="currency">currency.</param>
        /// <param name="debitCard">debit_card.</param>
        /// <param name="bankTransfer">bank_transfer.</param>
        /// <param name="acceptedBrands">accepted_brands.</param>
        /// <param name="pix">pix.</param>
        public GetCheckoutPaymentResponse(
            string id = null,
            int? amount = null,
            string defaultPaymentMethod = null,
            string successUrl = null,
            string paymentUrl = null,
            string gatewayAffiliationId = null,
            List<string> acceptedPaymentMethods = null,
            string status = null,
            bool? skipCheckoutSuccessPage = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? canceledAt = null,
            bool? customerEditable = null,
            Models.GetCustomerResponse customer = null,
            Models.GetAddressResponse billingaddress = null,
            Models.GetCheckoutCreditCardPaymentResponse creditCard = null,
            Models.GetCheckoutBoletoPaymentResponse boleto = null,
            bool? billingAddressEditable = null,
            Models.GetShippingResponse shipping = null,
            bool? shippable = null,
            DateTime? closedAt = null,
            DateTime? expiresAt = null,
            string currency = null,
            Models.GetCheckoutDebitCardPaymentResponse debitCard = null,
            Models.GetCheckoutBankTransferPaymentResponse bankTransfer = null,
            List<string> acceptedBrands = null,
            Models.GetCheckoutPixPaymentResponse pix = null)
        {
            this.Id = id;
            if (amount != null)
            {
                this.Amount = amount;
            }

            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.SuccessUrl = successUrl;
            this.PaymentUrl = paymentUrl;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.AcceptedPaymentMethods = acceptedPaymentMethods;
            this.Status = status;
            this.SkipCheckoutSuccessPage = skipCheckoutSuccessPage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (canceledAt != null)
            {
                this.CanceledAt = canceledAt;
            }

            this.CustomerEditable = customerEditable;
            if (customer != null)
            {
                this.Customer = customer;
            }

            this.Billingaddress = billingaddress;
            this.CreditCard = creditCard;
            this.Boleto = boleto;
            this.BillingAddressEditable = billingAddressEditable;
            this.Shipping = shipping;
            this.Shippable = shippable;
            if (closedAt != null)
            {
                this.ClosedAt = closedAt;
            }

            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            this.Currency = currency;
            if (debitCard != null)
            {
                this.DebitCard = debitCard;
            }

            if (bankTransfer != null)
            {
                this.BankTransfer = bankTransfer;
            }

            this.AcceptedBrands = acceptedBrands;
            if (pix != null)
            {
                this.Pix = pix;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Valor em centavos
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.shouldSerialize["amount"] = true;
                this.amount = value;
            }
        }

        /// <summary>
        /// Meio de pagamento padrão no checkout
        /// </summary>
        [JsonProperty("default_payment_method", NullValueHandling = NullValueHandling.Include)]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Url de redirecionamento de sucesso após o checkou
        /// </summary>
        [JsonProperty("success_url", NullValueHandling = NullValueHandling.Include)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Url para pagamento usando o checkout
        /// </summary>
        [JsonProperty("payment_url", NullValueHandling = NullValueHandling.Include)]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// Código da afiliação onde o pagamento será processado no gateway
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Include)]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Meios de pagamento aceitos no checkout
        /// </summary>
        [JsonProperty("accepted_payment_methods", NullValueHandling = NullValueHandling.Include)]
        public List<string> AcceptedPaymentMethods { get; set; }

        /// <summary>
        /// Status do checkout
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Pular tela de sucesso pós-pagamento?
        /// </summary>
        [JsonProperty("skip_checkout_success_page", NullValueHandling = NullValueHandling.Include)]
        public bool? SkipCheckoutSuccessPage { get; set; }

        /// <summary>
        /// Data de criação
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Data de atualização
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Data de cancelamento
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt
        {
            get
            {
                return this.canceledAt;
            }

            set
            {
                this.shouldSerialize["canceled_at"] = true;
                this.canceledAt = value;
            }
        }

        /// <summary>
        /// Torna o objeto customer editável
        /// </summary>
        [JsonProperty("customer_editable", NullValueHandling = NullValueHandling.Include)]
        public bool? CustomerEditable { get; set; }

        /// <summary>
        /// Dados do comprador
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.shouldSerialize["customer"] = true;
                this.customer = value;
            }
        }

        /// <summary>
        /// Dados do endereço de cobrança
        /// </summary>
        [JsonProperty("billingaddress", NullValueHandling = NullValueHandling.Include)]
        public Models.GetAddressResponse Billingaddress { get; set; }

        /// <summary>
        /// Configurações de cartão de crédito
        /// </summary>
        [JsonProperty("credit_card", NullValueHandling = NullValueHandling.Include)]
        public Models.GetCheckoutCreditCardPaymentResponse CreditCard { get; set; }

        /// <summary>
        /// Configurações de boleto
        /// </summary>
        [JsonProperty("boleto", NullValueHandling = NullValueHandling.Include)]
        public Models.GetCheckoutBoletoPaymentResponse Boleto { get; set; }

        /// <summary>
        /// Indica se o billing address poderá ser editado
        /// </summary>
        [JsonProperty("billing_address_editable", NullValueHandling = NullValueHandling.Include)]
        public bool? BillingAddressEditable { get; set; }

        /// <summary>
        /// Configurações  de entrega
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Include)]
        public Models.GetShippingResponse Shipping { get; set; }

        /// <summary>
        /// Indica se possui entrega
        /// </summary>
        [JsonProperty("shippable", NullValueHandling = NullValueHandling.Include)]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Data de fechamento
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt
        {
            get
            {
                return this.closedAt;
            }

            set
            {
                this.shouldSerialize["closed_at"] = true;
                this.closedAt = value;
            }
        }

        /// <summary>
        /// Data de expiração
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt
        {
            get
            {
                return this.expiresAt;
            }

            set
            {
                this.shouldSerialize["expires_at"] = true;
                this.expiresAt = value;
            }
        }

        /// <summary>
        /// Moeda
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Include)]
        public string Currency { get; set; }

        /// <summary>
        /// Configurações de cartão de débito
        /// </summary>
        [JsonProperty("debit_card")]
        public Models.GetCheckoutDebitCardPaymentResponse DebitCard
        {
            get
            {
                return this.debitCard;
            }

            set
            {
                this.shouldSerialize["debit_card"] = true;
                this.debitCard = value;
            }
        }

        /// <summary>
        /// Bank transfer payment response
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.GetCheckoutBankTransferPaymentResponse BankTransfer
        {
            get
            {
                return this.bankTransfer;
            }

            set
            {
                this.shouldSerialize["bank_transfer"] = true;
                this.bankTransfer = value;
            }
        }

        /// <summary>
        /// Accepted Brands
        /// </summary>
        [JsonProperty("accepted_brands", NullValueHandling = NullValueHandling.Include)]
        public List<string> AcceptedBrands { get; set; }

        /// <summary>
        /// Pix payment response
        /// </summary>
        [JsonProperty("pix")]
        public Models.GetCheckoutPixPaymentResponse Pix
        {
            get
            {
                return this.pix;
            }

            set
            {
                this.shouldSerialize["pix"] = true;
                this.pix = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCanceledAt()
        {
            this.shouldSerialize["canceled_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomer()
        {
            this.shouldSerialize["customer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClosedAt()
        {
            this.shouldSerialize["closed_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDebitCard()
        {
            this.shouldSerialize["debit_card"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBankTransfer()
        {
            this.shouldSerialize["bank_transfer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPix()
        {
            this.shouldSerialize["pix"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCanceledAt()
        {
            return this.shouldSerialize["canceled_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomer()
        {
            return this.shouldSerialize["customer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClosedAt()
        {
            return this.shouldSerialize["closed_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return this.shouldSerialize["expires_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDebitCard()
        {
            return this.shouldSerialize["debit_card"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankTransfer()
        {
            return this.shouldSerialize["bank_transfer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePix()
        {
            return this.shouldSerialize["pix"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetCheckoutPaymentResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.DefaultPaymentMethod == null && other.DefaultPaymentMethod == null) || (this.DefaultPaymentMethod?.Equals(other.DefaultPaymentMethod) == true)) &&
                ((this.SuccessUrl == null && other.SuccessUrl == null) || (this.SuccessUrl?.Equals(other.SuccessUrl) == true)) &&
                ((this.PaymentUrl == null && other.PaymentUrl == null) || (this.PaymentUrl?.Equals(other.PaymentUrl) == true)) &&
                ((this.GatewayAffiliationId == null && other.GatewayAffiliationId == null) || (this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true)) &&
                ((this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null) || (this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.SkipCheckoutSuccessPage == null && other.SkipCheckoutSuccessPage == null) || (this.SkipCheckoutSuccessPage?.Equals(other.SkipCheckoutSuccessPage) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.CustomerEditable == null && other.CustomerEditable == null) || (this.CustomerEditable?.Equals(other.CustomerEditable) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Billingaddress == null && other.Billingaddress == null) || (this.Billingaddress?.Equals(other.Billingaddress) == true)) &&
                ((this.CreditCard == null && other.CreditCard == null) || (this.CreditCard?.Equals(other.CreditCard) == true)) &&
                ((this.Boleto == null && other.Boleto == null) || (this.Boleto?.Equals(other.Boleto) == true)) &&
                ((this.BillingAddressEditable == null && other.BillingAddressEditable == null) || (this.BillingAddressEditable?.Equals(other.BillingAddressEditable) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Shippable == null && other.Shippable == null) || (this.Shippable?.Equals(other.Shippable) == true)) &&
                ((this.ClosedAt == null && other.ClosedAt == null) || (this.ClosedAt?.Equals(other.ClosedAt) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.DebitCard == null && other.DebitCard == null) || (this.DebitCard?.Equals(other.DebitCard) == true)) &&
                ((this.BankTransfer == null && other.BankTransfer == null) || (this.BankTransfer?.Equals(other.BankTransfer) == true)) &&
                ((this.AcceptedBrands == null && other.AcceptedBrands == null) || (this.AcceptedBrands?.Equals(other.AcceptedBrands) == true)) &&
                ((this.Pix == null && other.Pix == null) || (this.Pix?.Equals(other.Pix) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.DefaultPaymentMethod = {(this.DefaultPaymentMethod == null ? "null" : this.DefaultPaymentMethod == string.Empty ? "" : this.DefaultPaymentMethod)}");
            toStringOutput.Add($"this.SuccessUrl = {(this.SuccessUrl == null ? "null" : this.SuccessUrl == string.Empty ? "" : this.SuccessUrl)}");
            toStringOutput.Add($"this.PaymentUrl = {(this.PaymentUrl == null ? "null" : this.PaymentUrl == string.Empty ? "" : this.PaymentUrl)}");
            toStringOutput.Add($"this.GatewayAffiliationId = {(this.GatewayAffiliationId == null ? "null" : this.GatewayAffiliationId == string.Empty ? "" : this.GatewayAffiliationId)}");
            toStringOutput.Add($"this.AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AcceptedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.SkipCheckoutSuccessPage = {(this.SkipCheckoutSuccessPage == null ? "null" : this.SkipCheckoutSuccessPage.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.CustomerEditable = {(this.CustomerEditable == null ? "null" : this.CustomerEditable.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Billingaddress = {(this.Billingaddress == null ? "null" : this.Billingaddress.ToString())}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"this.Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"this.BillingAddressEditable = {(this.BillingAddressEditable == null ? "null" : this.BillingAddressEditable.ToString())}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.Shippable = {(this.Shippable == null ? "null" : this.Shippable.ToString())}");
            toStringOutput.Add($"this.ClosedAt = {(this.ClosedAt == null ? "null" : this.ClosedAt.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.DebitCard = {(this.DebitCard == null ? "null" : this.DebitCard.ToString())}");
            toStringOutput.Add($"this.BankTransfer = {(this.BankTransfer == null ? "null" : this.BankTransfer.ToString())}");
            toStringOutput.Add($"this.AcceptedBrands = {(this.AcceptedBrands == null ? "null" : $"[{string.Join(", ", this.AcceptedBrands)} ]")}");
            toStringOutput.Add($"this.Pix = {(this.Pix == null ? "null" : this.Pix.ToString())}");
        }
    }
}
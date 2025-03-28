// <copyright file="GetCheckoutPaymentResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Utilities;

namespace PagarmeApiSDK.Standard.Models
{
    /// <summary>
    /// GetCheckoutPaymentResponse.
    /// </summary>
    public class GetCheckoutPaymentResponse
    {
        private string id;
        private int? amount;
        private string defaultPaymentMethod;
        private string successUrl;
        private string paymentUrl;
        private string gatewayAffiliationId;
        private List<string> acceptedPaymentMethods;
        private string status;
        private bool? skipCheckoutSuccessPage;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private DateTime? canceledAt;
        private bool? customerEditable;
        private Models.GetCustomerResponse customer;
        private Models.GetAddressResponse billingaddress;
        private Models.GetCheckoutCreditCardPaymentResponse creditCard;
        private Models.GetCheckoutBoletoPaymentResponse boleto;
        private bool? billingAddressEditable;
        private Models.GetShippingResponse shipping;
        private bool? shippable;
        private DateTime? closedAt;
        private DateTime? expiresAt;
        private string currency;
        private Models.GetCheckoutDebitCardPaymentResponse debitCard;
        private Models.GetCheckoutBankTransferPaymentResponse bankTransfer;
        private List<string> acceptedBrands;
        private Models.GetCheckoutPixPaymentResponse pix;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "amount", false },
            { "default_payment_method", false },
            { "success_url", false },
            { "payment_url", false },
            { "gateway_affiliation_id", false },
            { "accepted_payment_methods", false },
            { "status", false },
            { "skip_checkout_success_page", false },
            { "created_at", false },
            { "updated_at", false },
            { "canceled_at", false },
            { "customer_editable", false },
            { "customer", false },
            { "billingaddress", false },
            { "credit_card", false },
            { "boleto", false },
            { "billing_address_editable", false },
            { "shipping", false },
            { "shippable", false },
            { "closed_at", false },
            { "expires_at", false },
            { "currency", false },
            { "debit_card", false },
            { "bank_transfer", false },
            { "accepted_brands", false },
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

            if (id != null)
            {
                this.Id = id;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (defaultPaymentMethod != null)
            {
                this.DefaultPaymentMethod = defaultPaymentMethod;
            }

            if (successUrl != null)
            {
                this.SuccessUrl = successUrl;
            }

            if (paymentUrl != null)
            {
                this.PaymentUrl = paymentUrl;
            }

            if (gatewayAffiliationId != null)
            {
                this.GatewayAffiliationId = gatewayAffiliationId;
            }

            if (acceptedPaymentMethods != null)
            {
                this.AcceptedPaymentMethods = acceptedPaymentMethods;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (skipCheckoutSuccessPage != null)
            {
                this.SkipCheckoutSuccessPage = skipCheckoutSuccessPage;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (canceledAt != null)
            {
                this.CanceledAt = canceledAt;
            }

            if (customerEditable != null)
            {
                this.CustomerEditable = customerEditable;
            }

            if (customer != null)
            {
                this.Customer = customer;
            }

            if (billingaddress != null)
            {
                this.Billingaddress = billingaddress;
            }

            if (creditCard != null)
            {
                this.CreditCard = creditCard;
            }

            if (boleto != null)
            {
                this.Boleto = boleto;
            }

            if (billingAddressEditable != null)
            {
                this.BillingAddressEditable = billingAddressEditable;
            }

            if (shipping != null)
            {
                this.Shipping = shipping;
            }

            if (shippable != null)
            {
                this.Shippable = shippable;
            }

            if (closedAt != null)
            {
                this.ClosedAt = closedAt;
            }

            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            if (currency != null)
            {
                this.Currency = currency;
            }

            if (debitCard != null)
            {
                this.DebitCard = debitCard;
            }

            if (bankTransfer != null)
            {
                this.BankTransfer = bankTransfer;
            }

            if (acceptedBrands != null)
            {
                this.AcceptedBrands = acceptedBrands;
            }

            if (pix != null)
            {
                this.Pix = pix;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

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
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod
        {
            get
            {
                return this.defaultPaymentMethod;
            }

            set
            {
                this.shouldSerialize["default_payment_method"] = true;
                this.defaultPaymentMethod = value;
            }
        }

        /// <summary>
        /// Url de redirecionamento de sucesso após o checkou
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl
        {
            get
            {
                return this.successUrl;
            }

            set
            {
                this.shouldSerialize["success_url"] = true;
                this.successUrl = value;
            }
        }

        /// <summary>
        /// Url para pagamento usando o checkout
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl
        {
            get
            {
                return this.paymentUrl;
            }

            set
            {
                this.shouldSerialize["payment_url"] = true;
                this.paymentUrl = value;
            }
        }

        /// <summary>
        /// Código da afiliação onde o pagamento será processado no gateway
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId
        {
            get
            {
                return this.gatewayAffiliationId;
            }

            set
            {
                this.shouldSerialize["gateway_affiliation_id"] = true;
                this.gatewayAffiliationId = value;
            }
        }

        /// <summary>
        /// Meios de pagamento aceitos no checkout
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods
        {
            get
            {
                return this.acceptedPaymentMethods;
            }

            set
            {
                this.shouldSerialize["accepted_payment_methods"] = true;
                this.acceptedPaymentMethods = value;
            }
        }

        /// <summary>
        /// Status do checkout
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Pular tela de sucesso pós-pagamento?
        /// </summary>
        [JsonProperty("skip_checkout_success_page")]
        public bool? SkipCheckoutSuccessPage
        {
            get
            {
                return this.skipCheckoutSuccessPage;
            }

            set
            {
                this.shouldSerialize["skip_checkout_success_page"] = true;
                this.skipCheckoutSuccessPage = value;
            }
        }

        /// <summary>
        /// Data de criação
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                this.shouldSerialize["created_at"] = true;
                this.createdAt = value;
            }
        }

        /// <summary>
        /// Data de atualização
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
        {
            get
            {
                return this.updatedAt;
            }

            set
            {
                this.shouldSerialize["updated_at"] = true;
                this.updatedAt = value;
            }
        }

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
        [JsonProperty("customer_editable")]
        public bool? CustomerEditable
        {
            get
            {
                return this.customerEditable;
            }

            set
            {
                this.shouldSerialize["customer_editable"] = true;
                this.customerEditable = value;
            }
        }

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
        [JsonProperty("billingaddress")]
        public Models.GetAddressResponse Billingaddress
        {
            get
            {
                return this.billingaddress;
            }

            set
            {
                this.shouldSerialize["billingaddress"] = true;
                this.billingaddress = value;
            }
        }

        /// <summary>
        /// Configurações de cartão de crédito
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.GetCheckoutCreditCardPaymentResponse CreditCard
        {
            get
            {
                return this.creditCard;
            }

            set
            {
                this.shouldSerialize["credit_card"] = true;
                this.creditCard = value;
            }
        }

        /// <summary>
        /// Configurações de boleto
        /// </summary>
        [JsonProperty("boleto")]
        public Models.GetCheckoutBoletoPaymentResponse Boleto
        {
            get
            {
                return this.boleto;
            }

            set
            {
                this.shouldSerialize["boleto"] = true;
                this.boleto = value;
            }
        }

        /// <summary>
        /// Indica se o billing address poderá ser editado
        /// </summary>
        [JsonProperty("billing_address_editable")]
        public bool? BillingAddressEditable
        {
            get
            {
                return this.billingAddressEditable;
            }

            set
            {
                this.shouldSerialize["billing_address_editable"] = true;
                this.billingAddressEditable = value;
            }
        }

        /// <summary>
        /// Configurações  de entrega
        /// </summary>
        [JsonProperty("shipping")]
        public Models.GetShippingResponse Shipping
        {
            get
            {
                return this.shipping;
            }

            set
            {
                this.shouldSerialize["shipping"] = true;
                this.shipping = value;
            }
        }

        /// <summary>
        /// Indica se possui entrega
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable
        {
            get
            {
                return this.shippable;
            }

            set
            {
                this.shouldSerialize["shippable"] = true;
                this.shippable = value;
            }
        }

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
        [JsonProperty("currency")]
        public string Currency
        {
            get
            {
                return this.currency;
            }

            set
            {
                this.shouldSerialize["currency"] = true;
                this.currency = value;
            }
        }

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
        [JsonProperty("accepted_brands")]
        public List<string> AcceptedBrands
        {
            get
            {
                return this.acceptedBrands;
            }

            set
            {
                this.shouldSerialize["accepted_brands"] = true;
                this.acceptedBrands = value;
            }
        }

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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultPaymentMethod()
        {
            this.shouldSerialize["default_payment_method"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSuccessUrl()
        {
            this.shouldSerialize["success_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentUrl()
        {
            this.shouldSerialize["payment_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayAffiliationId()
        {
            this.shouldSerialize["gateway_affiliation_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcceptedPaymentMethods()
        {
            this.shouldSerialize["accepted_payment_methods"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSkipCheckoutSuccessPage()
        {
            this.shouldSerialize["skip_checkout_success_page"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCanceledAt()
        {
            this.shouldSerialize["canceled_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerEditable()
        {
            this.shouldSerialize["customer_editable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomer()
        {
            this.shouldSerialize["customer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingaddress()
        {
            this.shouldSerialize["billingaddress"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreditCard()
        {
            this.shouldSerialize["credit_card"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBoleto()
        {
            this.shouldSerialize["boleto"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingAddressEditable()
        {
            this.shouldSerialize["billing_address_editable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetShipping()
        {
            this.shouldSerialize["shipping"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetShippable()
        {
            this.shouldSerialize["shippable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetClosedAt()
        {
            this.shouldSerialize["closed_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCurrency()
        {
            this.shouldSerialize["currency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDebitCard()
        {
            this.shouldSerialize["debit_card"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankTransfer()
        {
            this.shouldSerialize["bank_transfer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcceptedBrands()
        {
            this.shouldSerialize["accepted_brands"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPix()
        {
            this.shouldSerialize["pix"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
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
        public bool ShouldSerializeDefaultPaymentMethod()
        {
            return this.shouldSerialize["default_payment_method"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuccessUrl()
        {
            return this.shouldSerialize["success_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentUrl()
        {
            return this.shouldSerialize["payment_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayAffiliationId()
        {
            return this.shouldSerialize["gateway_affiliation_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcceptedPaymentMethods()
        {
            return this.shouldSerialize["accepted_payment_methods"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSkipCheckoutSuccessPage()
        {
            return this.shouldSerialize["skip_checkout_success_page"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
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
        public bool ShouldSerializeCustomerEditable()
        {
            return this.shouldSerialize["customer_editable"];
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
        public bool ShouldSerializeBillingaddress()
        {
            return this.shouldSerialize["billingaddress"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditCard()
        {
            return this.shouldSerialize["credit_card"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBoleto()
        {
            return this.shouldSerialize["boleto"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingAddressEditable()
        {
            return this.shouldSerialize["billing_address_editable"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShipping()
        {
            return this.shouldSerialize["shipping"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShippable()
        {
            return this.shouldSerialize["shippable"];
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
        public bool ShouldSerializeCurrency()
        {
            return this.shouldSerialize["currency"];
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
        public bool ShouldSerializeAcceptedBrands()
        {
            return this.shouldSerialize["accepted_brands"];
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCheckoutPaymentResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.DefaultPaymentMethod == null && other.DefaultPaymentMethod == null ||
                 this.DefaultPaymentMethod?.Equals(other.DefaultPaymentMethod) == true) &&
                (this.SuccessUrl == null && other.SuccessUrl == null ||
                 this.SuccessUrl?.Equals(other.SuccessUrl) == true) &&
                (this.PaymentUrl == null && other.PaymentUrl == null ||
                 this.PaymentUrl?.Equals(other.PaymentUrl) == true) &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true) &&
                (this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null ||
                 this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.SkipCheckoutSuccessPage == null && other.SkipCheckoutSuccessPage == null ||
                 this.SkipCheckoutSuccessPage?.Equals(other.SkipCheckoutSuccessPage) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.CanceledAt == null && other.CanceledAt == null ||
                 this.CanceledAt?.Equals(other.CanceledAt) == true) &&
                (this.CustomerEditable == null && other.CustomerEditable == null ||
                 this.CustomerEditable?.Equals(other.CustomerEditable) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Billingaddress == null && other.Billingaddress == null ||
                 this.Billingaddress?.Equals(other.Billingaddress) == true) &&
                (this.CreditCard == null && other.CreditCard == null ||
                 this.CreditCard?.Equals(other.CreditCard) == true) &&
                (this.Boleto == null && other.Boleto == null ||
                 this.Boleto?.Equals(other.Boleto) == true) &&
                (this.BillingAddressEditable == null && other.BillingAddressEditable == null ||
                 this.BillingAddressEditable?.Equals(other.BillingAddressEditable) == true) &&
                (this.Shipping == null && other.Shipping == null ||
                 this.Shipping?.Equals(other.Shipping) == true) &&
                (this.Shippable == null && other.Shippable == null ||
                 this.Shippable?.Equals(other.Shippable) == true) &&
                (this.ClosedAt == null && other.ClosedAt == null ||
                 this.ClosedAt?.Equals(other.ClosedAt) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.DebitCard == null && other.DebitCard == null ||
                 this.DebitCard?.Equals(other.DebitCard) == true) &&
                (this.BankTransfer == null && other.BankTransfer == null ||
                 this.BankTransfer?.Equals(other.BankTransfer) == true) &&
                (this.AcceptedBrands == null && other.AcceptedBrands == null ||
                 this.AcceptedBrands?.Equals(other.AcceptedBrands) == true) &&
                (this.Pix == null && other.Pix == null ||
                 this.Pix?.Equals(other.Pix) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"DefaultPaymentMethod = {this.DefaultPaymentMethod ?? "null"}");
            toStringOutput.Add($"SuccessUrl = {this.SuccessUrl ?? "null"}");
            toStringOutput.Add($"PaymentUrl = {this.PaymentUrl ?? "null"}");
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
            toStringOutput.Add($"AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AcceptedPaymentMethods)} ]")}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"SkipCheckoutSuccessPage = {(this.SkipCheckoutSuccessPage == null ? "null" : this.SkipCheckoutSuccessPage.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"CustomerEditable = {(this.CustomerEditable == null ? "null" : this.CustomerEditable.ToString())}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Billingaddress = {(this.Billingaddress == null ? "null" : this.Billingaddress.ToString())}");
            toStringOutput.Add($"CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"BillingAddressEditable = {(this.BillingAddressEditable == null ? "null" : this.BillingAddressEditable.ToString())}");
            toStringOutput.Add($"Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Shippable = {(this.Shippable == null ? "null" : this.Shippable.ToString())}");
            toStringOutput.Add($"ClosedAt = {(this.ClosedAt == null ? "null" : this.ClosedAt.ToString())}");
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"DebitCard = {(this.DebitCard == null ? "null" : this.DebitCard.ToString())}");
            toStringOutput.Add($"BankTransfer = {(this.BankTransfer == null ? "null" : this.BankTransfer.ToString())}");
            toStringOutput.Add($"AcceptedBrands = {(this.AcceptedBrands == null ? "null" : $"[{string.Join(", ", this.AcceptedBrands)} ]")}");
            toStringOutput.Add($"Pix = {(this.Pix == null ? "null" : this.Pix.ToString())}");
        }
    }
}
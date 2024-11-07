using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SheinPrototype.DTOs
{
    public class WebhookPayloadDto
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("sale_amount")]
        public decimal? SaleAmount { get; set; }

        [JsonPropertyName("currency_enum")]
        public int? CurrencyEnum { get; set; }

        [JsonPropertyName("currency_enum_key")]
        public string? CurrencyEnumKey { get; set; }

        [JsonPropertyName("coupon_code")]
        public string? CouponCode { get; set; }

        [JsonPropertyName("installments")]
        public int? Installments { get; set; }

        [JsonPropertyName("installment_amount")]
        public decimal? InstallmentAmount { get; set; }

        [JsonPropertyName("shipping_type_enum")]
        public int? ShippingTypeEnum { get; set; }

        [JsonPropertyName("shipping_type_enum_key")]
        public string? ShippingTypeEnumKey { get; set; }

        [JsonPropertyName("shipping_amount")]
        public decimal? ShippingAmount { get; set; }

        [JsonPropertyName("payment_method_enum")]
        public int? PaymentMethodEnum { get; set; }

        [JsonPropertyName("payment_method_enum_key")]
        public string? PaymentMethodEnumKey { get; set; }

        [JsonPropertyName("payment_type_enum")]
        public int? PaymentTypeEnum { get; set; }

        [JsonPropertyName("payment_type_enum_key")]
        public string? PaymentTypeEnumKey { get; set; }

        [JsonPropertyName("payment_format_enum")]
        public int? PaymentFormatEnum { get; set; }

        [JsonPropertyName("payment_format_enum_key")]
        public string? PaymentFormatEnumKey { get; set; }

        [JsonPropertyName("original_code")]
        public string? OriginalCode { get; set; }

        [JsonPropertyName("billet_url")]
        public string? BilletUrl { get; set; }

        [JsonPropertyName("billet_number")]
        public string? BilletNumber { get; set; }

        [JsonPropertyName("billet_expiration")]
        public DateTime? BilletExpiration { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("sale_status_enum")]
        public int? SaleStatusEnum { get; set; }

        [JsonPropertyName("sale_status_enum_key")]
        public string? SaleStatusEnumKey { get; set; }

        [JsonPropertyName("sale_status_detail")]
        public string? SaleStatusDetail { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("date_approved")]
        public DateTime? DateApproved { get; set; }

        [JsonPropertyName("tracking")]
        public string? Tracking { get; set; }

        [JsonPropertyName("url_tracking")]
        public string? UrlTracking { get; set; }

        [JsonPropertyName("checkout_type_enum")]
        public string? CheckoutTypeEnum { get; set; }

        [JsonPropertyName("product")]
        public ProductDto? Product { get; set; }

        [JsonPropertyName("plan")]
        public PlanDto? Plan { get; set; }

        [JsonPropertyName("plan_itens")]
        public List<object>? PlanItens { get; set; }

        [JsonPropertyName("customer")]
        public CustomerDto? Customer { get; set; }

        [JsonPropertyName("metadata")]
        public MetadataDto? Metadata { get; set; }

        [JsonPropertyName("webhook_owner")]
        public string? WebhookOwner { get; set; }

        [JsonPropertyName("commission")]
        public List<CommissionDto>? Commission { get; set; }

        [JsonPropertyName("url_send_webhook_pay")]
        public string? UrlSendWebhookPay { get; set; }
    }

    public class ProductDto
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("external_reference")]
        public string? ExternalReference { get; set; }

        [JsonPropertyName("guarantee")]
        public int? Guarantee { get; set; }
    }

    public class PlanDto
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("tax_code")]
        public string? TaxCode { get; set; }
    }

    public class CustomerDto
    {
        [JsonPropertyName("customer_type_enum")]
        public int? CustomerTypeEnum { get; set; }

        [JsonPropertyName("customer_type_enum_key")]
        public string? CustomerTypeEnumKey { get; set; }

        [JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("identification_type")]
        public string? IdentificationType { get; set; }

        [JsonPropertyName("identification_number")]
        public string? IdentificationNumber { get; set; }

        [JsonPropertyName("birthday")]
        public DateTime? Birthday { get; set; }

        [JsonPropertyName("date_birth")]
        public DateTime? DateBirth { get; set; }

        [JsonPropertyName("phone_extension")]
        public string? PhoneExtension { get; set; }

        [JsonPropertyName("phone_area_code")]
        public string? PhoneAreaCode { get; set; }

        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("phone_formated")]
        public string? PhoneFormated { get; set; }

        [JsonPropertyName("phone_formated_ddi")]
        public string? PhoneFormatedDdi { get; set; }

        [JsonPropertyName("ip")]
        public string? Ip { get; set; }

        [JsonPropertyName("street_name")]
        public string? StreetName { get; set; }

        [JsonPropertyName("street_number")]
        public string? StreetNumber { get; set; }

        [JsonPropertyName("district")]
        public string? District { get; set; }

        [JsonPropertyName("complement")]
        public string? Complement { get; set; }

        [JsonPropertyName("zip_code")]
        public string? ZipCode { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }

    public class MetadataDto
    {
        [JsonPropertyName("src")]
        public string? Src { get; set; }

        [JsonPropertyName("sck")]
        public string? Sck { get; set; }

        [JsonPropertyName("utm_source")]
        public string? UtmSource { get; set; }

        [JsonPropertyName("utm_medium")]
        public string? UtmMedium { get; set; }

        [JsonPropertyName("utm_campaign")]
        public string? UtmCampaign { get; set; }

        [JsonPropertyName("utm_content")]
        public string? UtmContent { get; set; }

        [JsonPropertyName("utm_term")]
        public string? UtmTerm { get; set; }

        [JsonPropertyName("ref")]
        public string? Ref { get; set; }
    }

    public class CommissionDto
    {
        [JsonPropertyName("affiliation_code")]
        public string? AffiliationCode { get; set; }

        [JsonPropertyName("affiliation_type_enum")]
        public int? AffiliationTypeEnum { get; set; }

        [JsonPropertyName("affiliation_type_enum_key")]
        public string? AffiliationTypeEnumKey { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("identification_number")]
        public string? IdentificationNumber { get; set; }

        [JsonPropertyName("commission_amount")]
        public decimal? CommissionAmount { get; set; }
    }
}

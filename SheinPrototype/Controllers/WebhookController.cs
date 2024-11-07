using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using SheinPrototype.DTOs;

namespace SheinPrototype.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebhookController: ControllerBase
{
    private WebhookPayloadDto? serializeRequest(string payload)
    {
        return JsonSerializer.Deserialize<WebhookPayloadDto>(payload, new JsonSerializerOptions()
        {
            Converters =
            {
                new CustomDateTimeConverter("yyyy-MM-dd HH:mm:ss") 
            }
        });
    }
    [HttpPost("PerfectPay")]
    public async Task<IActionResult> Index()
    {
        var data = await new StreamReader(Request.Body).ReadToEndAsync();
        var payload = serializeRequest(data);
        return Ok();
    }
    private class CustomDateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string _dateTimeFormat;

        public CustomDateTimeConverter(string dateTimeFormat)
        {
            _dateTimeFormat = dateTimeFormat;
        }

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            var dateTimeString = reader.GetString();
            if (DateTime.TryParseExact(dateTimeString, _dateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime))
            {
                return dateTime;
            }

            throw new JsonException($"Unable to parse '{dateTimeString}' as a DateTime using format '{_dateTimeFormat}'.");
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString(_dateTimeFormat, CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
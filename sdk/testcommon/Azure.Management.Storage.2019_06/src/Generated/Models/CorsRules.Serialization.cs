// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class CorsRules : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (CorsRulesValue != null)
            {
                writer.WritePropertyName("corsRules");
                writer.WriteStartArray();
                foreach (var item in CorsRulesValue)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CorsRules DeserializeCorsRules(JsonElement element)
        {
            IList<CorsRule> corsRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("corsRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CorsRule> array = new List<CorsRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(CorsRule.DeserializeCorsRule(item));
                        }
                    }
                    corsRules = array;
                    continue;
                }
            }
            return new CorsRules(corsRules);
        }
    }
}

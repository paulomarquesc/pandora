// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ApplicationSignInDetailedSummaryModel
{
    [JsonPropertyName("aggregatedEventDateTime")]
    public DateTime? AggregatedEventDateTime { get; set; }

    [JsonPropertyName("appDisplayName")]
    public string? AppDisplayName { get; set; }

    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("signInCount")]
    public long? SignInCount { get; set; }

    [JsonPropertyName("status")]
    public SignInStatusModel? Status { get; set; }
}

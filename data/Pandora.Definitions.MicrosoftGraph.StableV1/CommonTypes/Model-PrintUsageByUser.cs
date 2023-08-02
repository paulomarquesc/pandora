// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class PrintUsageByUserModel
{
    [JsonPropertyName("completedBlackAndWhiteJobCount")]
    public long? CompletedBlackAndWhiteJobCount { get; set; }

    [JsonPropertyName("completedColorJobCount")]
    public long? CompletedColorJobCount { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("incompleteJobCount")]
    public long? IncompleteJobCount { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("usageDate")]
    public DateTime? UsageDate { get; set; }

    [JsonPropertyName("userPrincipalName")]
    public string? UserPrincipalName { get; set; }
}

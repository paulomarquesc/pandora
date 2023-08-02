// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class MacOSSoftwareUpdateStateSummaryModel
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastUpdatedDateTime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("productKey")]
    public string? ProductKey { get; set; }

    [JsonPropertyName("state")]
    public MacOSSoftwareUpdateStateConstant? State { get; set; }

    [JsonPropertyName("updateCategory")]
    public MacOSSoftwareUpdateCategoryConstant? UpdateCategory { get; set; }

    [JsonPropertyName("updateVersion")]
    public string? UpdateVersion { get; set; }
}

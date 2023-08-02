// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class TeamsAppSettingsModel
{
    [JsonPropertyName("allowUserRequestsForAppAccess")]
    public bool? AllowUserRequestsForAppAccess { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isChatResourceSpecificConsentEnabled")]
    public bool? IsChatResourceSpecificConsentEnabled { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}

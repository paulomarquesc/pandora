using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSql.v2022_03_08_preview.LocationBasedCapabilities;


internal class HyperscaleNodeEditionCapabilityModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("supportedNodeTypes")]
    public List<NodeTypeCapabilityModel>? SupportedNodeTypes { get; set; }

    [JsonPropertyName("supportedServerVersions")]
    public List<ServerVersionCapabilityModel>? SupportedServerVersions { get; set; }

    [JsonPropertyName("supportedStorageEditions")]
    public List<StorageEditionCapabilityModel>? SupportedStorageEditions { get; set; }
}
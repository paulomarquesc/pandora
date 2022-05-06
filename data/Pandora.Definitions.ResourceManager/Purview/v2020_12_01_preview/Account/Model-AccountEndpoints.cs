using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Purview.v2020_12_01_preview.Account;


internal class AccountEndpointsModel
{
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    [JsonPropertyName("guardian")]
    public string? Guardian { get; set; }

    [JsonPropertyName("scan")]
    public string? Scan { get; set; }
}

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.FrontDoor.v2020_04_01.FrontDoors;


internal class BackendPoolsSettingsModel
{
    [JsonPropertyName("enforceCertificateNameCheck")]
    public EnforceCertificateNameCheckEnabledStateConstant? EnforceCertificateNameCheck { get; set; }

    [JsonPropertyName("sendRecvTimeoutSeconds")]
    public int? SendRecvTimeoutSeconds { get; set; }
}

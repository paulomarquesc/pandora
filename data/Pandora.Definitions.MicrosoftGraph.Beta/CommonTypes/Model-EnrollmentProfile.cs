// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class EnrollmentProfileModel
{
    [JsonPropertyName("configurationEndpointUrl")]
    public string? ConfigurationEndpointUrl { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("enableAuthenticationViaCompanyPortal")]
    public bool? EnableAuthenticationViaCompanyPortal { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("requireCompanyPortalOnSetupAssistantEnrolledDevices")]
    public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices { get; set; }

    [JsonPropertyName("requiresUserAuthentication")]
    public bool? RequiresUserAuthentication { get; set; }
}

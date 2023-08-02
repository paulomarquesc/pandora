// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AuthenticationStrengthPolicyModel
{
    [JsonPropertyName("allowedCombinations")]
    public List<AuthenticationMethodModesConstant>? AllowedCombinations { get; set; }

    [JsonPropertyName("combinationConfigurations")]
    public List<AuthenticationCombinationConfigurationModel>? CombinationConfigurations { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("modifiedDateTime")]
    public DateTime? ModifiedDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("policyType")]
    public AuthenticationStrengthPolicyTypeConstant? PolicyType { get; set; }

    [JsonPropertyName("requirementsSatisfied")]
    public AuthenticationStrengthRequirementsConstant? RequirementsSatisfied { get; set; }
}

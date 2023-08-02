// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class WindowsUpdatesContentApprovalModel
{
    [JsonPropertyName("content")]
    public DeployableContentModel? Content { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("deploymentSettings")]
    public DeploymentSettingsModel? DeploymentSettings { get; set; }

    [JsonPropertyName("deployments")]
    public List<DeploymentModel>? Deployments { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isRevoked")]
    public bool? IsRevoked { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("revokedDateTime")]
    public DateTime? RevokedDateTime { get; set; }

    [JsonPropertyName("updatePolicy")]
    public UpdatePolicyModel? UpdatePolicy { get; set; }
}

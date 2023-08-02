// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class SimulationModel
{
    [JsonPropertyName("attackTechnique")]
    public SimulationAttackTechniqueConstant? AttackTechnique { get; set; }

    [JsonPropertyName("attackType")]
    public SimulationAttackTypeConstant? AttackType { get; set; }

    [JsonPropertyName("automationId")]
    public string? AutomationId { get; set; }

    [JsonPropertyName("completionDateTime")]
    public DateTime? CompletionDateTime { get; set; }

    [JsonPropertyName("createdBy")]
    public EmailIdentityModel? CreatedBy { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isAutomated")]
    public bool? IsAutomated { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public EmailIdentityModel? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("launchDateTime")]
    public DateTime? LaunchDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("payloadDeliveryPlatform")]
    public PayloadDeliveryPlatformConstant? PayloadDeliveryPlatform { get; set; }

    [JsonPropertyName("report")]
    public SimulationReportModel? Report { get; set; }

    [JsonPropertyName("status")]
    public SimulationStatusConstant? Status { get; set; }
}

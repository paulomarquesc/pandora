// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class SynchronizationLinkedObjectsModel
{
    [JsonPropertyName("manager")]
    public SynchronizationJobSubjectModel? Manager { get; set; }

    [JsonPropertyName("members")]
    public List<SynchronizationJobSubjectModel>? Members { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("owners")]
    public List<SynchronizationJobSubjectModel>? Owners { get; set; }
}

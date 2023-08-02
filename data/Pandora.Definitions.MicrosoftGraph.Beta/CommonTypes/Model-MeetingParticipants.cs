// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class MeetingParticipantsModel
{
    [JsonPropertyName("attendees")]
    public List<MeetingParticipantInfoModel>? Attendees { get; set; }

    [JsonPropertyName("contributors")]
    public List<MeetingParticipantInfoModel>? Contributors { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("organizer")]
    public MeetingParticipantInfoModel? Organizer { get; set; }

    [JsonPropertyName("producers")]
    public List<MeetingParticipantInfoModel>? Producers { get; set; }
}

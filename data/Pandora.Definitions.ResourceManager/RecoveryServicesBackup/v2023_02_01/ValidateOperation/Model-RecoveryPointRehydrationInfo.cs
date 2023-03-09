using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_02_01.ValidateOperation;


internal class RecoveryPointRehydrationInfoModel
{
    [JsonPropertyName("rehydrationPriority")]
    public RehydrationPriorityConstant? RehydrationPriority { get; set; }

    [JsonPropertyName("rehydrationRetentionDuration")]
    public string? RehydrationRetentionDuration { get; set; }
}

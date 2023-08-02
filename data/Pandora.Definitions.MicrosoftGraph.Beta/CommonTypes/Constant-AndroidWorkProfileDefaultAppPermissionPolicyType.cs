// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AndroidWorkProfileDefaultAppPermissionPolicyTypeConstant
{
    [Description("DeviceDefault")]
    @deviceDefault,

    [Description("Prompt")]
    @prompt,

    [Description("AutoGrant")]
    @autoGrant,

    [Description("AutoDeny")]
    @autoDeny,
}

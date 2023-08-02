// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UserPurposeConstant
{
    [Description("User")]
    @user,

    [Description("Linked")]
    @linked,

    [Description("Shared")]
    @shared,

    [Description("Room")]
    @room,

    [Description("Equipment")]
    @equipment,

    [Description("Others")]
    @others,
}

// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DefenderAvStatusConstant
{
    [Description("NotReporting")]
    @notReporting,

    [Description("Disabled")]
    @disabled,

    [Description("NotUpdated")]
    @notUpdated,

    [Description("Updated")]
    @updated,

    [Description("Unknown")]
    @unknown,

    [Description("NotSupported")]
    @notSupported,
}

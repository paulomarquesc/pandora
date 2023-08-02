// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ValueTypeConstant
{
    [Description("Enum")]
    @enum,

    [Description("String")]
    @string,

    [Description("Int")]
    @int,

    [Description("Bool")]
    @bool,
}

// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ResourceConnectionStateConstant
{
    [Description("Connected")]
    @connected,

    [Description("NotAuthorized")]
    @notAuthorized,

    [Description("NotFound")]
    @notFound,
}

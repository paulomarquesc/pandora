// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ITunesPairingModeConstant
{
    [Description("Disallow")]
    @disallow,

    [Description("Allow")]
    @allow,

    [Description("RequiresCertificate")]
    @requiresCertificate,
}

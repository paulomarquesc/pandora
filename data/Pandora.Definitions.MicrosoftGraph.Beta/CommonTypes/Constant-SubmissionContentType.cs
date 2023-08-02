// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SubmissionContentTypeConstant
{
    [Description("Email")]
    @email,

    [Description("Url")]
    @url,

    [Description("File")]
    @file,

    [Description("App")]
    @app,
}

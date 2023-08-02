// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TokenIssuerTypeConstant
{
    [Description("AzureAD")]
    @AzureAD,

    [Description("ADFederationServices")]
    @ADFederationServices,

    [Description("AzureADBackupAuth")]
    @AzureADBackupAuth,

    [Description("ADFederationServicesMFAAdapter")]
    @ADFederationServicesMFAAdapter,

    [Description("NPSExtension")]
    @NPSExtension,
}

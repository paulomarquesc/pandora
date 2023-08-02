// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.ServicePrincipals.Beta.ServicePrincipalHomeRealmDiscoveryPolicy;

internal class ListServicePrincipalHomeRealmDiscoveryPolicyOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new ServicePrincipalId();
    public override Type NestedItemType() => typeof(string);
    public override string? UriSuffix() => "/homeRealmDiscoveryPolicies/$ref";
}

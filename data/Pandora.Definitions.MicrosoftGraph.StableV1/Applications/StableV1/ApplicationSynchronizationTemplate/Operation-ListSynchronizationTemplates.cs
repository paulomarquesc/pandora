// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Applications.StableV1.ApplicationSynchronizationTemplate;

internal class ListSynchronizationTemplatesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new ApplicationId();
    public override Type NestedItemType() => typeof(SynchronizationTemplateModel);
    public override string? UriSuffix() => "/synchronization/templates";
}

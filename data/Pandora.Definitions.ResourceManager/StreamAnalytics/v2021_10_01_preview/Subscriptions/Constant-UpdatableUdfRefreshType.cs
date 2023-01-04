using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StreamAnalytics.v2021_10_01_preview.Subscriptions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UpdatableUdfRefreshTypeConstant
{
    [Description("Blocking")]
    Blocking,

    [Description("Nonblocking")]
    Nonblocking,
}
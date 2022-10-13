using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2022_05_01.ReplicationProtectionContainerMappings;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum HealthErrorCustomerResolvabilityConstant
{
    [Description("Allowed")]
    Allowed,

    [Description("NotAllowed")]
    NotAllowed,
}
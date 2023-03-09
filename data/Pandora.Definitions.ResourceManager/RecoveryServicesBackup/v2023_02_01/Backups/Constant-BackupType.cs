using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_02_01.Backups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BackupTypeConstant
{
    [Description("CopyOnlyFull")]
    CopyOnlyFull,

    [Description("Differential")]
    Differential,

    [Description("Full")]
    Full,

    [Description("Incremental")]
    Incremental,

    [Description("Invalid")]
    Invalid,

    [Description("Log")]
    Log,

    [Description("SnapshotCopyOnlyFull")]
    SnapshotCopyOnlyFull,

    [Description("SnapshotFull")]
    SnapshotFull,
}

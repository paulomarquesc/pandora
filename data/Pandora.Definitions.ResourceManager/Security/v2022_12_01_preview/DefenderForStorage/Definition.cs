using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2022_12_01_preview.DefenderForStorage;

internal class Definition : ResourceDefinition
{
    public string Name => "DefenderForStorage";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new GetOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DefenderForStorageSettingModel),
        typeof(DefenderForStorageSettingPropertiesModel),
        typeof(MalwareScanningPropertiesModel),
        typeof(OnUploadPropertiesModel),
        typeof(OperationStatusModel),
        typeof(SensitiveDataDiscoveryPropertiesModel),
    };
}

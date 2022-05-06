using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web;

public partial class Service : ServiceDefinition
{
    public string Name => "Web";
    public string? ResourceProvider => "Microsoft.CertificateRegistration";
}

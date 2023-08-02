// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class MacOSKerberosSingleSignOnExtensionModel
{
    [JsonPropertyName("activeDirectorySiteCode")]
    public string? ActiveDirectorySiteCode { get; set; }

    [JsonPropertyName("blockActiveDirectorySiteAutoDiscovery")]
    public bool? BlockActiveDirectorySiteAutoDiscovery { get; set; }

    [JsonPropertyName("blockAutomaticLogin")]
    public bool? BlockAutomaticLogin { get; set; }

    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    [JsonPropertyName("credentialBundleIdAccessControlList")]
    public List<string>? CredentialBundleIdAccessControlList { get; set; }

    [JsonPropertyName("credentialsCacheMonitored")]
    public bool? CredentialsCacheMonitored { get; set; }

    [JsonPropertyName("domainRealms")]
    public List<string>? DomainRealms { get; set; }

    [JsonPropertyName("domains")]
    public List<string>? Domains { get; set; }

    [JsonPropertyName("isDefaultRealm")]
    public bool? IsDefaultRealm { get; set; }

    [JsonPropertyName("kerberosAppsInBundleIdACLIncluded")]
    public bool? KerberosAppsInBundleIdACLIncluded { get; set; }

    [JsonPropertyName("managedAppsInBundleIdACLIncluded")]
    public bool? ManagedAppsInBundleIdACLIncluded { get; set; }

    [JsonPropertyName("modeCredentialUsed")]
    public string? ModeCredentialUsed { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("passwordBlockModification")]
    public bool? PasswordBlockModification { get; set; }

    [JsonPropertyName("passwordChangeUrl")]
    public string? PasswordChangeUrl { get; set; }

    [JsonPropertyName("passwordEnableLocalSync")]
    public bool? PasswordEnableLocalSync { get; set; }

    [JsonPropertyName("passwordExpirationDays")]
    public int? PasswordExpirationDays { get; set; }

    [JsonPropertyName("passwordExpirationNotificationDays")]
    public int? PasswordExpirationNotificationDays { get; set; }

    [JsonPropertyName("passwordMinimumAgeDays")]
    public int? PasswordMinimumAgeDays { get; set; }

    [JsonPropertyName("passwordMinimumLength")]
    public int? PasswordMinimumLength { get; set; }

    [JsonPropertyName("passwordPreviousPasswordBlockCount")]
    public int? PasswordPreviousPasswordBlockCount { get; set; }

    [JsonPropertyName("passwordRequireActiveDirectoryComplexity")]
    public bool? PasswordRequireActiveDirectoryComplexity { get; set; }

    [JsonPropertyName("passwordRequirementsDescription")]
    public string? PasswordRequirementsDescription { get; set; }

    [JsonPropertyName("preferredKDCs")]
    public List<string>? PreferredKDCs { get; set; }

    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    [JsonPropertyName("requireUserPresence")]
    public bool? RequireUserPresence { get; set; }

    [JsonPropertyName("signInHelpText")]
    public string? SignInHelpText { get; set; }

    [JsonPropertyName("tlsForLDAPRequired")]
    public bool? TlsForLDAPRequired { get; set; }

    [JsonPropertyName("userPrincipalName")]
    public string? UserPrincipalName { get; set; }

    [JsonPropertyName("userSetupDelayed")]
    public bool? UserSetupDelayed { get; set; }

    [JsonPropertyName("usernameLabelCustom")]
    public string? UsernameLabelCustom { get; set; }
}

// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class IosVppAppModel
{
    [JsonPropertyName("appStoreUrl")]
    public string? AppStoreUrl { get; set; }

    [JsonPropertyName("applicableDeviceType")]
    public IosDeviceTypeModel? ApplicableDeviceType { get; set; }

    [JsonPropertyName("assignedLicenses")]
    public List<IosVppAppAssignedLicenseModel>? AssignedLicenses { get; set; }

    [JsonPropertyName("assignments")]
    public List<MobileAppAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    [JsonPropertyName("categories")]
    public List<MobileAppCategoryModel>? Categories { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("dependentAppCount")]
    public int? DependentAppCount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("developer")]
    public string? Developer { get; set; }

    [JsonPropertyName("deviceStatuses")]
    public List<MobileAppInstallStatusModel>? DeviceStatuses { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("informationUrl")]
    public string? InformationUrl { get; set; }

    [JsonPropertyName("installSummary")]
    public MobileAppInstallSummaryModel? InstallSummary { get; set; }

    [JsonPropertyName("isAssigned")]
    public bool? IsAssigned { get; set; }

    [JsonPropertyName("isFeatured")]
    public bool? IsFeatured { get; set; }

    [JsonPropertyName("largeIcon")]
    public MimeContentModel? LargeIcon { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("licensingType")]
    public VppLicensingTypeModel? LicensingType { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("privacyInformationUrl")]
    public string? PrivacyInformationUrl { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("publishingState")]
    public MobileAppPublishingStateConstant? PublishingState { get; set; }

    [JsonPropertyName("relationships")]
    public List<MobileAppRelationshipModel>? Relationships { get; set; }

    [JsonPropertyName("releaseDateTime")]
    public DateTime? ReleaseDateTime { get; set; }

    [JsonPropertyName("revokeLicenseActionResults")]
    public List<IosVppAppRevokeLicensesActionResultModel>? RevokeLicenseActionResults { get; set; }

    [JsonPropertyName("roleScopeTagIds")]
    public List<string>? RoleScopeTagIds { get; set; }

    [JsonPropertyName("supersededAppCount")]
    public int? SupersededAppCount { get; set; }

    [JsonPropertyName("supersedingAppCount")]
    public int? SupersedingAppCount { get; set; }

    [JsonPropertyName("totalLicenseCount")]
    public int? TotalLicenseCount { get; set; }

    [JsonPropertyName("uploadState")]
    public int? UploadState { get; set; }

    [JsonPropertyName("usedLicenseCount")]
    public int? UsedLicenseCount { get; set; }

    [JsonPropertyName("userStatuses")]
    public List<UserAppInstallStatusModel>? UserStatuses { get; set; }

    [JsonPropertyName("vppTokenAccountType")]
    public VppTokenAccountTypeConstant? VppTokenAccountType { get; set; }

    [JsonPropertyName("vppTokenAppleId")]
    public string? VppTokenAppleId { get; set; }

    [JsonPropertyName("vppTokenId")]
    public string? VppTokenId { get; set; }

    [JsonPropertyName("vppTokenOrganizationName")]
    public string? VppTokenOrganizationName { get; set; }
}

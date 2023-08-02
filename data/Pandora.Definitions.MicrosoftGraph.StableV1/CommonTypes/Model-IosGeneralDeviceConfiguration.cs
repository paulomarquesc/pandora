// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class IosGeneralDeviceConfigurationModel
{
    [JsonPropertyName("accountBlockModification")]
    public bool? AccountBlockModification { get; set; }

    [JsonPropertyName("activationLockAllowWhenSupervised")]
    public bool? ActivationLockAllowWhenSupervised { get; set; }

    [JsonPropertyName("airDropBlocked")]
    public bool? AirDropBlocked { get; set; }

    [JsonPropertyName("airDropForceUnmanagedDropTarget")]
    public bool? AirDropForceUnmanagedDropTarget { get; set; }

    [JsonPropertyName("airPlayForcePairingPasswordForOutgoingRequests")]
    public bool? AirPlayForcePairingPasswordForOutgoingRequests { get; set; }

    [JsonPropertyName("appStoreBlockAutomaticDownloads")]
    public bool? AppStoreBlockAutomaticDownloads { get; set; }

    [JsonPropertyName("appStoreBlockInAppPurchases")]
    public bool? AppStoreBlockInAppPurchases { get; set; }

    [JsonPropertyName("appStoreBlockUIAppInstallation")]
    public bool? AppStoreBlockUIAppInstallation { get; set; }

    [JsonPropertyName("appStoreBlocked")]
    public bool? AppStoreBlocked { get; set; }

    [JsonPropertyName("appStoreRequirePassword")]
    public bool? AppStoreRequirePassword { get; set; }

    [JsonPropertyName("appleNewsBlocked")]
    public bool? AppleNewsBlocked { get; set; }

    [JsonPropertyName("appleWatchBlockPairing")]
    public bool? AppleWatchBlockPairing { get; set; }

    [JsonPropertyName("appleWatchForceWristDetection")]
    public bool? AppleWatchForceWristDetection { get; set; }

    [JsonPropertyName("appsSingleAppModeList")]
    public List<AppListItemModel>? AppsSingleAppModeList { get; set; }

    [JsonPropertyName("appsVisibilityList")]
    public List<AppListItemModel>? AppsVisibilityList { get; set; }

    [JsonPropertyName("appsVisibilityListType")]
    public AppListTypeConstant? AppsVisibilityListType { get; set; }

    [JsonPropertyName("assignments")]
    public List<DeviceConfigurationAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("bluetoothBlockModification")]
    public bool? BluetoothBlockModification { get; set; }

    [JsonPropertyName("cameraBlocked")]
    public bool? CameraBlocked { get; set; }

    [JsonPropertyName("cellularBlockDataRoaming")]
    public bool? CellularBlockDataRoaming { get; set; }

    [JsonPropertyName("cellularBlockGlobalBackgroundFetchWhileRoaming")]
    public bool? CellularBlockGlobalBackgroundFetchWhileRoaming { get; set; }

    [JsonPropertyName("cellularBlockPerAppDataModification")]
    public bool? CellularBlockPerAppDataModification { get; set; }

    [JsonPropertyName("cellularBlockPersonalHotspot")]
    public bool? CellularBlockPersonalHotspot { get; set; }

    [JsonPropertyName("cellularBlockVoiceRoaming")]
    public bool? CellularBlockVoiceRoaming { get; set; }

    [JsonPropertyName("certificatesBlockUntrustedTlsCertificates")]
    public bool? CertificatesBlockUntrustedTlsCertificates { get; set; }

    [JsonPropertyName("classroomAppBlockRemoteScreenObservation")]
    public bool? ClassroomAppBlockRemoteScreenObservation { get; set; }

    [JsonPropertyName("classroomAppForceUnpromptedScreenObservation")]
    public bool? ClassroomAppForceUnpromptedScreenObservation { get; set; }

    [JsonPropertyName("compliantAppListType")]
    public AppListTypeConstant? CompliantAppListType { get; set; }

    [JsonPropertyName("compliantAppsList")]
    public List<AppListItemModel>? CompliantAppsList { get; set; }

    [JsonPropertyName("configurationProfileBlockChanges")]
    public bool? ConfigurationProfileBlockChanges { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("definitionLookupBlocked")]
    public bool? DefinitionLookupBlocked { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("deviceBlockEnableRestrictions")]
    public bool? DeviceBlockEnableRestrictions { get; set; }

    [JsonPropertyName("deviceBlockEraseContentAndSettings")]
    public bool? DeviceBlockEraseContentAndSettings { get; set; }

    [JsonPropertyName("deviceBlockNameModification")]
    public bool? DeviceBlockNameModification { get; set; }

    [JsonPropertyName("deviceSettingStateSummaries")]
    public List<SettingStateDeviceSummaryModel>? DeviceSettingStateSummaries { get; set; }

    [JsonPropertyName("deviceStatusOverview")]
    public DeviceConfigurationDeviceOverviewModel? DeviceStatusOverview { get; set; }

    [JsonPropertyName("deviceStatuses")]
    public List<DeviceConfigurationDeviceStatusModel>? DeviceStatuses { get; set; }

    [JsonPropertyName("diagnosticDataBlockSubmission")]
    public bool? DiagnosticDataBlockSubmission { get; set; }

    [JsonPropertyName("diagnosticDataBlockSubmissionModification")]
    public bool? DiagnosticDataBlockSubmissionModification { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("documentsBlockManagedDocumentsInUnmanagedApps")]
    public bool? DocumentsBlockManagedDocumentsInUnmanagedApps { get; set; }

    [JsonPropertyName("documentsBlockUnmanagedDocumentsInManagedApps")]
    public bool? DocumentsBlockUnmanagedDocumentsInManagedApps { get; set; }

    [JsonPropertyName("emailInDomainSuffixes")]
    public List<string>? EmailInDomainSuffixes { get; set; }

    [JsonPropertyName("enterpriseAppBlockTrust")]
    public bool? EnterpriseAppBlockTrust { get; set; }

    [JsonPropertyName("enterpriseAppBlockTrustModification")]
    public bool? EnterpriseAppBlockTrustModification { get; set; }

    [JsonPropertyName("faceTimeBlocked")]
    public bool? FaceTimeBlocked { get; set; }

    [JsonPropertyName("findMyFriendsBlocked")]
    public bool? FindMyFriendsBlocked { get; set; }

    [JsonPropertyName("gameCenterBlocked")]
    public bool? GameCenterBlocked { get; set; }

    [JsonPropertyName("gamingBlockGameCenterFriends")]
    public bool? GamingBlockGameCenterFriends { get; set; }

    [JsonPropertyName("gamingBlockMultiplayer")]
    public bool? GamingBlockMultiplayer { get; set; }

    [JsonPropertyName("hostPairingBlocked")]
    public bool? HostPairingBlocked { get; set; }

    [JsonPropertyName("iBooksStoreBlockErotica")]
    public bool? IBooksStoreBlockErotica { get; set; }

    [JsonPropertyName("iBooksStoreBlocked")]
    public bool? IBooksStoreBlocked { get; set; }

    [JsonPropertyName("iCloudBlockActivityContinuation")]
    public bool? ICloudBlockActivityContinuation { get; set; }

    [JsonPropertyName("iCloudBlockBackup")]
    public bool? ICloudBlockBackup { get; set; }

    [JsonPropertyName("iCloudBlockDocumentSync")]
    public bool? ICloudBlockDocumentSync { get; set; }

    [JsonPropertyName("iCloudBlockManagedAppsSync")]
    public bool? ICloudBlockManagedAppsSync { get; set; }

    [JsonPropertyName("iCloudBlockPhotoLibrary")]
    public bool? ICloudBlockPhotoLibrary { get; set; }

    [JsonPropertyName("iCloudBlockPhotoStreamSync")]
    public bool? ICloudBlockPhotoStreamSync { get; set; }

    [JsonPropertyName("iCloudBlockSharedPhotoStream")]
    public bool? ICloudBlockSharedPhotoStream { get; set; }

    [JsonPropertyName("iCloudRequireEncryptedBackup")]
    public bool? ICloudRequireEncryptedBackup { get; set; }

    [JsonPropertyName("iTunesBlockExplicitContent")]
    public bool? ITunesBlockExplicitContent { get; set; }

    [JsonPropertyName("iTunesBlockMusicService")]
    public bool? ITunesBlockMusicService { get; set; }

    [JsonPropertyName("iTunesBlockRadio")]
    public bool? ITunesBlockRadio { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("keyboardBlockAutoCorrect")]
    public bool? KeyboardBlockAutoCorrect { get; set; }

    [JsonPropertyName("keyboardBlockDictation")]
    public bool? KeyboardBlockDictation { get; set; }

    [JsonPropertyName("keyboardBlockPredictive")]
    public bool? KeyboardBlockPredictive { get; set; }

    [JsonPropertyName("keyboardBlockShortcuts")]
    public bool? KeyboardBlockShortcuts { get; set; }

    [JsonPropertyName("keyboardBlockSpellCheck")]
    public bool? KeyboardBlockSpellCheck { get; set; }

    [JsonPropertyName("kioskModeAllowAssistiveSpeak")]
    public bool? KioskModeAllowAssistiveSpeak { get; set; }

    [JsonPropertyName("kioskModeAllowAssistiveTouchSettings")]
    public bool? KioskModeAllowAssistiveTouchSettings { get; set; }

    [JsonPropertyName("kioskModeAllowAutoLock")]
    public bool? KioskModeAllowAutoLock { get; set; }

    [JsonPropertyName("kioskModeAllowColorInversionSettings")]
    public bool? KioskModeAllowColorInversionSettings { get; set; }

    [JsonPropertyName("kioskModeAllowRingerSwitch")]
    public bool? KioskModeAllowRingerSwitch { get; set; }

    [JsonPropertyName("kioskModeAllowScreenRotation")]
    public bool? KioskModeAllowScreenRotation { get; set; }

    [JsonPropertyName("kioskModeAllowSleepButton")]
    public bool? KioskModeAllowSleepButton { get; set; }

    [JsonPropertyName("kioskModeAllowTouchscreen")]
    public bool? KioskModeAllowTouchscreen { get; set; }

    [JsonPropertyName("kioskModeAllowVoiceOverSettings")]
    public bool? KioskModeAllowVoiceOverSettings { get; set; }

    [JsonPropertyName("kioskModeAllowVolumeButtons")]
    public bool? KioskModeAllowVolumeButtons { get; set; }

    [JsonPropertyName("kioskModeAllowZoomSettings")]
    public bool? KioskModeAllowZoomSettings { get; set; }

    [JsonPropertyName("kioskModeAppStoreUrl")]
    public string? KioskModeAppStoreUrl { get; set; }

    [JsonPropertyName("kioskModeBuiltInAppId")]
    public string? KioskModeBuiltInAppId { get; set; }

    [JsonPropertyName("kioskModeManagedAppId")]
    public string? KioskModeManagedAppId { get; set; }

    [JsonPropertyName("kioskModeRequireAssistiveTouch")]
    public bool? KioskModeRequireAssistiveTouch { get; set; }

    [JsonPropertyName("kioskModeRequireColorInversion")]
    public bool? KioskModeRequireColorInversion { get; set; }

    [JsonPropertyName("kioskModeRequireMonoAudio")]
    public bool? KioskModeRequireMonoAudio { get; set; }

    [JsonPropertyName("kioskModeRequireVoiceOver")]
    public bool? KioskModeRequireVoiceOver { get; set; }

    [JsonPropertyName("kioskModeRequireZoom")]
    public bool? KioskModeRequireZoom { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("lockScreenBlockControlCenter")]
    public bool? LockScreenBlockControlCenter { get; set; }

    [JsonPropertyName("lockScreenBlockNotificationView")]
    public bool? LockScreenBlockNotificationView { get; set; }

    [JsonPropertyName("lockScreenBlockPassbook")]
    public bool? LockScreenBlockPassbook { get; set; }

    [JsonPropertyName("lockScreenBlockTodayView")]
    public bool? LockScreenBlockTodayView { get; set; }

    [JsonPropertyName("mediaContentRatingApps")]
    public RatingAppsTypeConstant? MediaContentRatingApps { get; set; }

    [JsonPropertyName("mediaContentRatingAustralia")]
    public MediaContentRatingAustraliaModel? MediaContentRatingAustralia { get; set; }

    [JsonPropertyName("mediaContentRatingCanada")]
    public MediaContentRatingCanadaModel? MediaContentRatingCanada { get; set; }

    [JsonPropertyName("mediaContentRatingFrance")]
    public MediaContentRatingFranceModel? MediaContentRatingFrance { get; set; }

    [JsonPropertyName("mediaContentRatingGermany")]
    public MediaContentRatingGermanyModel? MediaContentRatingGermany { get; set; }

    [JsonPropertyName("mediaContentRatingIreland")]
    public MediaContentRatingIrelandModel? MediaContentRatingIreland { get; set; }

    [JsonPropertyName("mediaContentRatingJapan")]
    public MediaContentRatingJapanModel? MediaContentRatingJapan { get; set; }

    [JsonPropertyName("mediaContentRatingNewZealand")]
    public MediaContentRatingNewZealandModel? MediaContentRatingNewZealand { get; set; }

    [JsonPropertyName("mediaContentRatingUnitedKingdom")]
    public MediaContentRatingUnitedKingdomModel? MediaContentRatingUnitedKingdom { get; set; }

    [JsonPropertyName("mediaContentRatingUnitedStates")]
    public MediaContentRatingUnitedStatesModel? MediaContentRatingUnitedStates { get; set; }

    [JsonPropertyName("messagesBlocked")]
    public bool? MessagesBlocked { get; set; }

    [JsonPropertyName("networkUsageRules")]
    public List<IosNetworkUsageRuleModel>? NetworkUsageRules { get; set; }

    [JsonPropertyName("notificationsBlockSettingsModification")]
    public bool? NotificationsBlockSettingsModification { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("passcodeBlockFingerprintModification")]
    public bool? PasscodeBlockFingerprintModification { get; set; }

    [JsonPropertyName("passcodeBlockFingerprintUnlock")]
    public bool? PasscodeBlockFingerprintUnlock { get; set; }

    [JsonPropertyName("passcodeBlockModification")]
    public bool? PasscodeBlockModification { get; set; }

    [JsonPropertyName("passcodeBlockSimple")]
    public bool? PasscodeBlockSimple { get; set; }

    [JsonPropertyName("passcodeExpirationDays")]
    public int? PasscodeExpirationDays { get; set; }

    [JsonPropertyName("passcodeMinimumCharacterSetCount")]
    public int? PasscodeMinimumCharacterSetCount { get; set; }

    [JsonPropertyName("passcodeMinimumLength")]
    public int? PasscodeMinimumLength { get; set; }

    [JsonPropertyName("passcodeMinutesOfInactivityBeforeLock")]
    public int? PasscodeMinutesOfInactivityBeforeLock { get; set; }

    [JsonPropertyName("passcodeMinutesOfInactivityBeforeScreenTimeout")]
    public int? PasscodeMinutesOfInactivityBeforeScreenTimeout { get; set; }

    [JsonPropertyName("passcodePreviousPasscodeBlockCount")]
    public int? PasscodePreviousPasscodeBlockCount { get; set; }

    [JsonPropertyName("passcodeRequired")]
    public bool? PasscodeRequired { get; set; }

    [JsonPropertyName("passcodeRequiredType")]
    public RequiredPasswordTypeConstant? PasscodeRequiredType { get; set; }

    [JsonPropertyName("passcodeSignInFailureCountBeforeWipe")]
    public int? PasscodeSignInFailureCountBeforeWipe { get; set; }

    [JsonPropertyName("podcastsBlocked")]
    public bool? PodcastsBlocked { get; set; }

    [JsonPropertyName("safariBlockAutofill")]
    public bool? SafariBlockAutofill { get; set; }

    [JsonPropertyName("safariBlockJavaScript")]
    public bool? SafariBlockJavaScript { get; set; }

    [JsonPropertyName("safariBlockPopups")]
    public bool? SafariBlockPopups { get; set; }

    [JsonPropertyName("safariBlocked")]
    public bool? SafariBlocked { get; set; }

    [JsonPropertyName("safariCookieSettings")]
    public WebBrowserCookieSettingsConstant? SafariCookieSettings { get; set; }

    [JsonPropertyName("safariManagedDomains")]
    public List<string>? SafariManagedDomains { get; set; }

    [JsonPropertyName("safariPasswordAutoFillDomains")]
    public List<string>? SafariPasswordAutoFillDomains { get; set; }

    [JsonPropertyName("safariRequireFraudWarning")]
    public bool? SafariRequireFraudWarning { get; set; }

    [JsonPropertyName("screenCaptureBlocked")]
    public bool? ScreenCaptureBlocked { get; set; }

    [JsonPropertyName("siriBlockUserGeneratedContent")]
    public bool? SiriBlockUserGeneratedContent { get; set; }

    [JsonPropertyName("siriBlocked")]
    public bool? SiriBlocked { get; set; }

    [JsonPropertyName("siriBlockedWhenLocked")]
    public bool? SiriBlockedWhenLocked { get; set; }

    [JsonPropertyName("siriRequireProfanityFilter")]
    public bool? SiriRequireProfanityFilter { get; set; }

    [JsonPropertyName("spotlightBlockInternetResults")]
    public bool? SpotlightBlockInternetResults { get; set; }

    [JsonPropertyName("userStatusOverview")]
    public DeviceConfigurationUserOverviewModel? UserStatusOverview { get; set; }

    [JsonPropertyName("userStatuses")]
    public List<DeviceConfigurationUserStatusModel>? UserStatuses { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }

    [JsonPropertyName("voiceDialingBlocked")]
    public bool? VoiceDialingBlocked { get; set; }

    [JsonPropertyName("wallpaperBlockModification")]
    public bool? WallpaperBlockModification { get; set; }

    [JsonPropertyName("wiFiConnectOnlyToConfiguredNetworks")]
    public bool? WiFiConnectOnlyToConfiguredNetworks { get; set; }
}

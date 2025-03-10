# Release History

## 1.2.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.1.0 (2022-11-11)

### Features Added

- Added new resources for Managed Instance AdvancedThreatProtection APIs.

### Other Changes

- Obsolete tag methods in `RestorableDroppedDatabaseResource` and `RestorableDroppedManagedDatabaseResource`.
- Marked some extension methods to get resources as `EditorBrowsableState.Never`, added corresponding methods that return resource data.

## 1.0.0 (2022-07-21)

This release is the first stable release of the Azure Sql management library.

### Features Added

- Added Update methods in resource classes.

### Breaking Changes

Polishing since last public beta release:
- Prepended `Sql` prefix to all single / simple model names.
- Corrected the format of all `Guid` type properties / parameters.
- Corrected the format of all `ResourceIdentifier` type properties / parameters.
- Corrected the format of all `ResouceType` type properties / parameters.
- Corrected the format of all `ETag` type properties / parameters.
- Corrected the format of all `AzureLocation` type properties / parameters.
- Corrected the format of all binary type properties / parameters.
- Corrected all acronyms that not follow [.Net Naming Guidelines](https://docs.microsoft.com/dotnet/standard/design-guidelines/naming-guidelines).
- Corrected enumeration name by following [Naming Enumerations Rule](https://docs.microsoft.com/dotnet/standard/design-guidelines/names-of-classes-structs-and-interfaces#naming-enumerations).
- Corrected the suffix of `DateTimeOffset` properties / parameters.
- Corrected the name of interval / duration properties / parameters that end with units.
- Optimized the name of some models and functions.

### Other Changes

- Upgraded dependent `Azure.ResourceManager` to 1.2.0
- Upgraded dependent `Azure.Core` to 1.25.0

## 1.0.0-beta.5 (2022-06-08)

### Features Added

- Add Update methods in resource classes.

### Breaking Changes

- Rename private endpoint resource names with `Sql` prefix.
- Rename `PrivateLinkServiceConnectionState` properties to `ConnectionState`.

### Bugs Fixed

- Fixed wrong API version for Databases and ReplicationLinks operations.

## 1.0.0-beta.4 (2022-04-08)

### Breaking Changes

- Simplify `type` property names.
- Normalized the body parameter type names for PUT / POST / PATCH operations if it is only used as input.

### Other Changes

- Upgrade dependency to Azure.ResourceManager 1.0.0

## 1.0.0-beta.3 (2022-03-31)

### Breaking Changes

- Now all the resource classes would have a `Resource` suffix (if it previously does not have one).
- Renamed some models to more comprehensive names.
- `bool waitForCompletion` parameter in all long running operations were changed to `WaitUntil waitUntil`.
- All properties of the type `object` were changed to `BinaryData`.
- Removed `GetIfExists` methods from all the resource classes.

## 1.0.0-beta.2 (2021-12-28)

### Features Added

- Added `CreateResourceIdentifier` for each resource class
- Class `DeletedServerCollection`, `InstanceFailoverGroupCollection`, `SqlTimeZoneCollection`, `ServerTrustGroupCollection`, `SubscriptionUsageCollection`, `ResourceGroupLongTermRetentionBackupCollection`, `SubscriptionLongTermRetentionBackupCollection`, `ResourceGroupLongTermRetentionManagedInstanceBackupCollection` and `SubscriptionLongTermRetentionManagedInstanceBackupCollection` now implements `IEnumerable<T>` and `IAsyncEnumerable<T>`.

### Breaking Changes

- Renamed `CheckIfExists` to `Exists` for each resource collection class
- Renamed `Get{Resource}ByName` to `Get{Resource}AsGenericResources` in `SubscriptionExtensions`
- Constructor of `DeletedServerCollection`, `InstanceFailoverGroupCollection`, `SqlTimeZoneCollection`, `ServerTrustGroupCollection` and `SubscriptionUsageCollection` no longer accept `locationName` as their first parameter.
- Constructor of `ResourceGroupLongTermRetentionBackupCollection` and `SubscriptionLongTermRetentionBackupCollection` no longer accept `locationName`, `longTermRetentionServerName` and `longTermRetentionDatabaseName` as its first three parameters.
- Constructor of `ResourceGroupLongTermRetentionManagedInstanceBackupCollection` and `SubscriptionLongTermRetentionManagedInstanceBackupCollection` no longer accept `locationName`, `managedInstanceName` and `databaseName` as its first three parameters.
- Method `GetInstanceFailoverGroups` and `GetServerTrustGroups` in `ResourceGroupExtensions` now accepts an extra parameter `locationName`.
- Method `GetResourceGroupLongTermRetentionBackups` in `ResourceGroupExtensions` now accepts three extra parameters `locationName`, `longTermRetentionServerName` and `longTermRetentionDatabaseName`.
- Method `GetResourceGroupLongTermRetentionManagedInstanceBackups` in `ResourceGroupExtensions` now accepts three extra parameters `locationName`, `managedInstanceName` and `databaseName`.
- Method `GetDeletedServers`, `GetSqlTimeZones` and `GetSubscriptionUsages` now accepts an extra parameter `locationName`.
- Method `GetSubscriptionLongTermRetentionBackups` now accepts three extra parameters `locationName`, `longTermRetentionServerName` and `longTermRetentionDatabaseName`.
- Method `GetSubscriptionLongTermRetentionManagedInstanceBackups` now accepts three extra parameters `locationName`, `managedInstanceName` and `databaseName`.

### Bugs Fixed

- Fixed comments for `FirstPageFunc` of each pageable resource class

## 1.0.0-beta.1 (2021-12-03)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.Sql` to `Azure.ResourceManager.Sql`.

### General New Features

This package follows the [new Azure SDK guidelines](https://azure.github.io/azure-sdk/general_introduction.html), and provides many core capabilities:

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET.
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing.
    - HTTP pipeline with custom policies.
    - Better error-handling.
    - Support uniform telemetry across all languages.

This package is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

> NOTE: For more information about unified authentication, please refer to [Microsoft Azure Identity documentation for .NET](https://docs.microsoft.com//dotnet/api/overview/azure/identity-readme?view=azure-dotnet).
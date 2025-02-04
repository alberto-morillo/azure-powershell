namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Represents a server to be updated.</summary>
    public partial class ServerForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal
    {

        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public System.Security.SecureString AdministratorLoginPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).AdministratorLoginPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).AdministratorLoginPassword = value ?? null; }

        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate; }

        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? BackupGeoRedundantBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupGeoRedundantBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupGeoRedundantBackup = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum)""); }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? BackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupRetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupRetentionDay = value ?? default(int); }

        /// <summary>The mode to update a new PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateModeForUpdate? CreateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).CreateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).CreateMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateModeForUpdate)""); }

        /// <summary>The HA mode for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? HighAvailabilityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode)""); }

        /// <summary>availability zone information of the standby.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string HighAvailabilityStandbyAvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityStandbyAvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityStandbyAvailabilityZone = value ?? null; }

        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location the resource resides in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowCustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowCustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowDayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowDayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.Backup { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).Backup; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).Backup = value; }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate = value; }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.HighAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailability = value; }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState = value; }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.MaintenanceWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).MaintenanceWindow = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdate Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ServerPropertiesForUpdate()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.SkuAutoGenerated()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateInternal.Storage { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).Storage = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdate _property;

        /// <summary>Properties of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ServerPropertiesForUpdate()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGenerated _sku;

        /// <summary>The SKU (pricing tier) of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGenerated Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.SkuAutoGenerated()); set => this._sku = value; }

        /// <summary>The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGeneratedInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGeneratedInternal)Sku).Name = value ?? null; }

        /// <summary>The tier of the particular SKU, e.g. Burstable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier? SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGeneratedInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGeneratedInternal)Sku).Tier = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier)""); }

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).StorageSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdateInternal)Property).StorageSizeGb = value ?? default(int); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateTags _tag;

        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ServerForUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ServerForUpdate" /> instance.</summary>
        public ServerForUpdate()
        {

        }
    }
    /// Represents a server to be updated.
    public partial interface IServerForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password of the administrator login.",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The earliest restore point time (ISO8601 format) for server.",
        SerializedName = @"earliestRestoreDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? BackupEarliestRestoreDate { get;  }
        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether Geo-Redundant backup is enabled on the server.",
        SerializedName = @"geoRedundantBackup",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupRetentionDay { get; set; }
        /// <summary>The mode to update a new PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mode to update a new PostgreSQL server.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateModeForUpdate) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateModeForUpdate? CreateMode { get; set; }
        /// <summary>The HA mode for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The HA mode for the server.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? HighAvailabilityMode { get; set; }
        /// <summary>availability zone information of the standby.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"availability zone information of the standby.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A state of a HA server that is visible to user.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HighAvailabilityState { get;  }
        /// <summary>The location the resource resides in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location the resource resides in.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"indicates whether custom window is enabled or disabled",
        SerializedName = @"customWindow",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"day of week for maintenance window",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start hour for maintenance window",
        SerializedName = @"startHour",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start minute for maintenance window",
        SerializedName = @"startMinute",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. Burstable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tier of the particular SKU, e.g. Burstable.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier? SkuTier { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageSizeGb { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application-specific metadata in the form of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateTags Tag { get; set; }

    }
    /// Represents a server to be updated.
    internal partial interface IServerForUpdateInternal

    {
        /// <summary>The password of the administrator login.</summary>
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>Backup properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup Backup { get; set; }
        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        global::System.DateTime? BackupEarliestRestoreDate { get; set; }
        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        int? BackupRetentionDay { get; set; }
        /// <summary>The mode to update a new PostgreSQL server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateModeForUpdate? CreateMode { get; set; }
        /// <summary>High availability properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability HighAvailability { get; set; }
        /// <summary>The HA mode for the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? HighAvailabilityMode { get; set; }
        /// <summary>availability zone information of the standby.</summary>
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HighAvailabilityState { get; set; }
        /// <summary>The location the resource resides in.</summary>
        string Location { get; set; }
        /// <summary>Maintenance window properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>Properties of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesForUpdate Property { get; set; }
        /// <summary>The SKU (pricing tier) of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ISkuAutoGenerated Sku { get; set; }
        /// <summary>The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.</summary>
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. Burstable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier? SkuTier { get; set; }
        /// <summary>Storage properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage Storage { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? StorageSizeGb { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerForUpdateTags Tag { get; set; }

    }
}
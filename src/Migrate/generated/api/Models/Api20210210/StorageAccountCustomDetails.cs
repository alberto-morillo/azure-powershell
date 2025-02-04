namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Storage account custom input.</summary>
    public partial class StorageAccountCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal
    {

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Creates an new <see cref="StorageAccountCustomDetails" /> instance.</summary>
        public StorageAccountCustomDetails()
        {

        }
    }
    /// Storage account custom input.
    public partial interface IStorageAccountCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }

    }
    /// Storage account custom input.
    internal partial interface IStorageAccountCustomDetailsInternal

    {
        /// <summary>The class type.</summary>
        string ResourceType { get; set; }

    }
}
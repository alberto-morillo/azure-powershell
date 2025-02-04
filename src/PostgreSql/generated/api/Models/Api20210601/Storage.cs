namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Storage properties of a server</summary>
    public partial class Storage :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageInternal
    {

        /// <summary>Backing field for <see cref="SizeGb" /> property.</summary>
        private int? _sizeGb;

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? SizeGb { get => this._sizeGb; set => this._sizeGb = value; }

        /// <summary>Creates an new <see cref="Storage" /> instance.</summary>
        public Storage()
        {

        }
    }
    /// Storage properties of a server
    public partial interface IStorage :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? SizeGb { get; set; }

    }
    /// Storage properties of a server
    internal partial interface IStorageInternal

    {
        /// <summary>Max storage allowed for a server.</summary>
        int? SizeGb { get; set; }

    }
}
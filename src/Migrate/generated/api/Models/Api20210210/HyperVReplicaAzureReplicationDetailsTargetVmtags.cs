namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The target VM tags.</summary>
    public partial class HyperVReplicaAzureReplicationDetailsTargetVmtags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureReplicationDetailsTargetVmtags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureReplicationDetailsTargetVmtagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="HyperVReplicaAzureReplicationDetailsTargetVmtags" /> instance.
        /// </summary>
        public HyperVReplicaAzureReplicationDetailsTargetVmtags()
        {

        }
    }
    /// The target VM tags.
    public partial interface IHyperVReplicaAzureReplicationDetailsTargetVmtags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The target VM tags.
    internal partial interface IHyperVReplicaAzureReplicationDetailsTargetVmtagsInternal

    {

    }
}
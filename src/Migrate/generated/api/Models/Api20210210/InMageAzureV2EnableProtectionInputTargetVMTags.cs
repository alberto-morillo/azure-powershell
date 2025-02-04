namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The target VM tags.</summary>
    public partial class InMageAzureV2EnableProtectionInputTargetVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="InMageAzureV2EnableProtectionInputTargetVMTags" /> instance.
        /// </summary>
        public InMageAzureV2EnableProtectionInputTargetVMTags()
        {

        }
    }
    /// The target VM tags.
    public partial interface IInMageAzureV2EnableProtectionInputTargetVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The target VM tags.
    internal partial interface IInMageAzureV2EnableProtectionInputTargetVMTagsInternal

    {

    }
}
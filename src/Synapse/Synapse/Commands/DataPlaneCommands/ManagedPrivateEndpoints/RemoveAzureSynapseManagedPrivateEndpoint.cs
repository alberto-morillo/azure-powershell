﻿using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Commands.Synapse.Properties;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.ManagedPrivateEndpoint,
        DefaultParameterSetName = RemoveByName, SupportsShouldProcess = true)]
    [OutputType(typeof(bool))]
    public class RemoveAzureSynapseManagedPrivateEndpoint : SynapseManagedPrivateEndpointsClientCmdletBase
    {
        private const string RemoveByName = "RemoveByName";
        private const string RemoveByObject = "RemoveByObject";
        private const string RemoveByInputObject = "RemoveByInputObject";

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = RemoveByName,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public override string WorkspaceName { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = RemoveByObject,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceObject)]
        [ValidateNotNull]
        public PSSynapseWorkspace WorkspaceObject { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = RemoveByInputObject,
           Mandatory = true, HelpMessage = HelpMessages.ManagedPrivateEndpointObject)]
        [ValidateNotNull]
        public PSManagedPrivateEndpointResource InputObject { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = RemoveByName,
            Mandatory = true, HelpMessage = HelpMessages.ManagedPrivateEndpointName)]
        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = RemoveByObject,
            Mandatory = true, HelpMessage = HelpMessages.ManagedPrivateEndpointName)]
        [ValidateNotNullOrEmpty]
        [Alias("ManagedPrivateEndpointName")]
        public string Name { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, Mandatory = false, HelpMessage = HelpMessages.DefaultVNetName)]
        [ValidateNotNullOrEmpty]
        [Alias("VNetName")]
        [PSDefaultValue(Help = SynapseConstants.DefaultVNetName, Value = SynapseConstants.DefaultVNetName)]
        public string VirtualNetworkName { get; set; } = SynapseConstants.DefaultVNetName;

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.PassThru)]
        public SwitchParameter PassThru { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.AsJob)]
        public SwitchParameter AsJob { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.Force)]
        public SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.WorkspaceObject))
            {
                this.WorkspaceName = this.WorkspaceObject.Name;
            }

            if (this.IsParameterBound(c => c.InputObject))
            {
                this.WorkspaceName = this.InputObject.WorkspaceName;
                this.Name = this.InputObject.Name;
            }

            ConfirmAction(
                Force.IsPresent,
                string.Format(Resources.RemoveSynapseManagedPrivateEndpoint, this.Name),
                string.Format(Resources.RemovingSynapseManagedPrivateEndpoint, this.Name, this.WorkspaceName),
                Name,
                () =>
                {
                    SynapseManagedPrivateEndpointsClient.DeleteManagedPrivateEndpoint(this.Name,this.VirtualNetworkName);
                    if (PassThru)
                    {
                        WriteObject(true);
                    }
                });
        }
    }
}

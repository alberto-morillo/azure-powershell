﻿using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Commands.Synapse.Properties;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.ManagedPrivateEndpoint,
        DefaultParameterSetName = SetByName, SupportsShouldProcess = true)]
    [Alias("Set-" + ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.ManagedPrivateEndpoint)]
    [OutputType(typeof(PSManagedPrivateEndpointResource))]
    public class NewAzureSynapseManagedPrivateEndpoint : SynapseManagedPrivateEndpointsClientCmdletBase
    {
        private const string SetByName = "SetByName";
        private const string SetByObject = "SetByObject";

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = SetByName,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public override string WorkspaceName { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = SetByObject,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceObject)]
        [ValidateNotNull]
        public PSSynapseWorkspace WorkspaceObject { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = HelpMessages.ManagedPrivateEndpointName)]
        [ValidateNotNullOrEmpty]
        [Alias("ManagedPrivateEndpointName")]
        public string Name { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, Mandatory = false, HelpMessage = HelpMessages.DefaultVNetName)]
        [ValidateNotNullOrEmpty]
        [Alias("VNetName")]
        [PSDefaultValue(Help = SynapseConstants.DefaultVNetName, Value = SynapseConstants.DefaultVNetName)]
        public string VirtualNetworkName { get; set; } = SynapseConstants.DefaultVNetName;

        [Parameter(ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = HelpMessages.JsonFilePath)]
        [ValidateNotNullOrEmpty]
        [Alias("File")]
        public string DefinitionFile { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.AsJob)]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.WorkspaceObject))
            {
                this.WorkspaceName = this.WorkspaceObject.Name;
            }

            if (this.ShouldProcess(this.WorkspaceName, String.Format(Resources.SettingSynapseManagedPrivateEndPoint, this.Name, this.WorkspaceName)))
            { 
                string rawJsonContent = SynapseManagedPrivateEndpointsClient.ReadJsonFileContent(this.TryResolvePath(DefinitionFile));
                WriteObject(new PSManagedPrivateEndpointResource(SynapseManagedPrivateEndpointsClient.CreateManagedPrivateEndpoint(this.Name, rawJsonContent, this.VirtualNetworkName), this.WorkspaceName));
            }
        }
    }
}

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Query parameter to enumerate jobs.</summary>
    public partial class JobQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobQueryParameter,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobQueryParameterInternal
    {

        /// <summary>Backing field for <see cref="AffectedObjectType" /> property.</summary>
        private string _affectedObjectType;

        /// <summary>The type of objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AffectedObjectType { get => this._affectedObjectType; set => this._affectedObjectType = value; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private string _endTime;

        /// <summary>Date time to get jobs upto.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="FabricId" /> property.</summary>
        private string _fabricId;

        /// <summary>The Id of the fabric to search jobs under.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricId { get => this._fabricId; set => this._fabricId = value; }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>The job Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string JobName { get => this._jobName; set => this._jobName = value; }

        /// <summary>Backing field for <see cref="JobOutputType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ExportJobOutputSerializationType? _jobOutputType;

        /// <summary>The output type of the jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ExportJobOutputSerializationType? JobOutputType { get => this._jobOutputType; set => this._jobOutputType = value; }

        /// <summary>Backing field for <see cref="JobStatus" /> property.</summary>
        private string _jobStatus;

        /// <summary>The states of the job to be filtered can be in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string JobStatus { get => this._jobStatus; set => this._jobStatus = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>Date time to get jobs from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="TimezoneOffset" /> property.</summary>
        private double? _timezoneOffset;

        /// <summary>The timezone offset for the location of the request (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? TimezoneOffset { get => this._timezoneOffset; set => this._timezoneOffset = value; }

        /// <summary>Creates an new <see cref="JobQueryParameter" /> instance.</summary>
        public JobQueryParameter()
        {

        }
    }
    /// Query parameter to enumerate jobs.
    public partial interface IJobQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The type of objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of objects.",
        SerializedName = @"affectedObjectTypes",
        PossibleTypes = new [] { typeof(string) })]
        string AffectedObjectType { get; set; }
        /// <summary>Date time to get jobs upto.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date time to get jobs upto.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(string) })]
        string EndTime { get; set; }
        /// <summary>The Id of the fabric to search jobs under.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the fabric to search jobs under.",
        SerializedName = @"fabricId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricId { get; set; }
        /// <summary>The job Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The job Name.",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        string JobName { get; set; }
        /// <summary>The output type of the jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The output type of the jobs.",
        SerializedName = @"jobOutputType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ExportJobOutputSerializationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ExportJobOutputSerializationType? JobOutputType { get; set; }
        /// <summary>The states of the job to be filtered can be in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The states of the job to be filtered can be in.",
        SerializedName = @"jobStatus",
        PossibleTypes = new [] { typeof(string) })]
        string JobStatus { get; set; }
        /// <summary>Date time to get jobs from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date time to get jobs from.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get; set; }
        /// <summary>The timezone offset for the location of the request (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timezone offset for the location of the request (in minutes).",
        SerializedName = @"timezoneOffset",
        PossibleTypes = new [] { typeof(double) })]
        double? TimezoneOffset { get; set; }

    }
    /// Query parameter to enumerate jobs.
    internal partial interface IJobQueryParameterInternal

    {
        /// <summary>The type of objects.</summary>
        string AffectedObjectType { get; set; }
        /// <summary>Date time to get jobs upto.</summary>
        string EndTime { get; set; }
        /// <summary>The Id of the fabric to search jobs under.</summary>
        string FabricId { get; set; }
        /// <summary>The job Name.</summary>
        string JobName { get; set; }
        /// <summary>The output type of the jobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ExportJobOutputSerializationType? JobOutputType { get; set; }
        /// <summary>The states of the job to be filtered can be in.</summary>
        string JobStatus { get; set; }
        /// <summary>Date time to get jobs from.</summary>
        string StartTime { get; set; }
        /// <summary>The timezone offset for the location of the request (in minutes).</summary>
        double? TimezoneOffset { get; set; }

    }
}
// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataLake.AnalyticsJob.Models;

namespace Microsoft.Azure.Management.DataLake.AnalyticsJob.Models
{
    /// <summary>
    /// The common Data Lake Analytics job information properties.
    /// </summary>
    public partial class JobInformation
    {
        private int? _degreeOfParallelism;
        
        /// <summary>
        /// Optional. Gets or sets the degree of parallelism used for this job.
        /// This must have a minimum value of 2
        /// </summary>
        public int? DegreeOfParallelism
        {
            get { return this._degreeOfParallelism; }
            set { this._degreeOfParallelism = value; }
        }
        
        private System.DateTimeOffset? _endTime;
        
        /// <summary>
        /// Optional. Gets or sets the completion time of the job
        /// </summary>
        public System.DateTimeOffset? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Gets or sets the error message to display, if any.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private Guid _jobId;
        
        /// <summary>
        /// Required. Gets or sets the job's unique identifier.
        /// </summary>
        public Guid JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the friendly name of the job.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int? _priority;
        
        /// <summary>
        /// Optional. Gets or sets the priority value for the current job which
        /// must be greater than 1.
        /// </summary>
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }
        
        private JobProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the job specific properties.
        /// </summary>
        public JobProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private Microsoft.Azure.Management.DataLake.AnalyticsJob.Models.JobResult? _result;
        
        /// <summary>
        /// Optional. Gets or sets the result of job execution or the current
        /// result of the running job.
        /// </summary>
        public Microsoft.Azure.Management.DataLake.AnalyticsJob.Models.JobResult? Result
        {
            get { return this._result; }
            set { this._result = value; }
        }
        
        private System.DateTimeOffset? _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time of the job.
        /// </summary>
        public System.DateTimeOffset? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private Microsoft.Azure.Management.DataLake.AnalyticsJob.Models.JobState? _state;
        
        /// <summary>
        /// Optional. Gets or sets a more detailed state of the job than the
        /// result. Especially used for intermediate states and errors
        /// </summary>
        public Microsoft.Azure.Management.DataLake.AnalyticsJob.Models.JobState? State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private IList<JobStateAuditRecord> _stateAuditRecords;
        
        /// <summary>
        /// Optional. Gets or sets the job state audit records, indicating when
        /// various operations have been performed on this job.
        /// </summary>
        public IList<JobStateAuditRecord> StateAuditRecords
        {
            get { return this._stateAuditRecords; }
            set { this._stateAuditRecords = value; }
        }
        
        private string _submitter;
        
        /// <summary>
        /// Optional. Gets or sets the user or account that submitted the job.
        /// </summary>
        public string Submitter
        {
            get { return this._submitter; }
            set { this._submitter = value; }
        }
        
        private System.DateTimeOffset? _submitTime;
        
        /// <summary>
        /// Optional. Gets or sets the time the job was submitted to the
        /// service.
        /// </summary>
        public System.DateTimeOffset? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. Gets or sets the job type of the current job (i.e. Hive
        /// or U-SQL).
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobInformation class.
        /// </summary>
        public JobInformation()
        {
            this.StateAuditRecords = new LazyList<JobStateAuditRecord>();
        }
    }
}

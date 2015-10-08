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
using System.Linq;

namespace Microsoft.Azure.Management.DataLake.AnalyticsJob.Models
{
    /// <summary>
    /// The common Data Lake Analytics job properties.
    /// </summary>
    public abstract partial class JobProperties
    {
        private string _runtimeVersion;
        
        /// <summary>
        /// Optional. Gets or sets the runtime version of the SQL-IP engine to
        /// use
        /// </summary>
        public string RuntimeVersion
        {
            get { return this._runtimeVersion; }
            set { this._runtimeVersion = value; }
        }
        
        private string _script;
        
        /// <summary>
        /// Required. Gets or sets the SQL-IP script to run
        /// </summary>
        public string Script
        {
            get { return this._script; }
            set { this._script = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets or sets the job type of the current job (i.e. Hive
        /// or U-SQL).
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        public JobProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the JobProperties class with required
        /// arguments.
        /// </summary>
        public JobProperties(string script)
            : this()
        {
            if (script == null)
            {
                throw new ArgumentNullException("script");
            }
            this.Script = script;
        }
    }
}

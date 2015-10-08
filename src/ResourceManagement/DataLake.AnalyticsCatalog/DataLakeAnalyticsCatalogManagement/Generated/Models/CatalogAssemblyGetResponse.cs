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
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models;

/// <summary>
/// Provides the object model used for Data Lake Analytics catalogs.
/// </summary>
namespace Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models
{
    /// <summary>
    /// The Get Database operation response.
    /// </summary>
    public partial class CatalogAssemblyGetResponse : AzureOperationResponse
    {
        private USqlAssembly _assembly;
        
        /// <summary>
        /// Optional. Gets or sets the resulting assembly from the get.
        /// </summary>
        public USqlAssembly Assembly
        {
            get { return this._assembly; }
            set { this._assembly = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CatalogAssemblyGetResponse class.
        /// </summary>
        public CatalogAssemblyGetResponse()
        {
        }
    }
}

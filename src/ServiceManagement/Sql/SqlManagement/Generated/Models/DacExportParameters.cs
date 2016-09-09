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
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Represents the parameters needed to initiate an Azure SQL Database
    /// Export operation.
    /// </summary>
    public partial class DacExportParameters
    {
        private DacExportParameters.BlobCredentialsParameter _blobCredentials;
        
        /// <summary>
        /// Optional. Gets or sets the credentials information needed for
        /// setting where the DACPAC file will be exported to in Azure Blob
        /// Storage.
        /// </summary>
        public DacExportParameters.BlobCredentialsParameter BlobCredentials
        {
            get { return this._blobCredentials; }
            set { this._blobCredentials = value; }
        }
        
        private DacExportParameters.ConnectionInfoParameter _connectionInfo;
        
        /// <summary>
        /// Optional. Gets or sets the connection information needed for the
        /// Azure SQL Database.
        /// </summary>
        public DacExportParameters.ConnectionInfoParameter ConnectionInfo
        {
            get { return this._connectionInfo; }
            set { this._connectionInfo = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DacExportParameters class.
        /// </summary>
        public DacExportParameters()
        {
        }
        
        /// <summary>
        /// The credentials needed to connect to Azure Blob Storage to export
        /// the DACPAC file.
        /// </summary>
        public partial class BlobCredentialsParameter
        {
            private string _storageAccessKey;
            
            /// <summary>
            /// Required. Gets or sets the access key for the Azure Storage
            /// account.
            /// </summary>
            public string StorageAccessKey
            {
                get { return this._storageAccessKey; }
                set { this._storageAccessKey = value; }
            }
            
            private Uri _uri;
            
            /// <summary>
            /// Required. Gets or sets the URI of where the DACPAC file should
            /// be stored in Azure Blob Storage.
            /// </summary>
            public Uri Uri
            {
                get { return this._uri; }
                set { this._uri = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the BlobCredentialsParameter
            /// class.
            /// </summary>
            public BlobCredentialsParameter()
            {
            }
            
            /// <summary>
            /// Initializes a new instance of the BlobCredentialsParameter
            /// class with required arguments.
            /// </summary>
            public BlobCredentialsParameter(Uri uri, string storageAccessKey)
                : this()
            {
                if (uri == null)
                {
                    throw new ArgumentNullException("uri");
                }
                if (storageAccessKey == null)
                {
                    throw new ArgumentNullException("storageAccessKey");
                }
                this.Uri = uri;
                this.StorageAccessKey = storageAccessKey;
            }
        }
        
        /// <summary>
        /// Represents the connection information for the Azure SQL Database to
        /// export.
        /// </summary>
        public partial class ConnectionInfoParameter
        {
            private string _databaseName;
            
            /// <summary>
            /// Required. Gets or sets the name of the database to be exported.
            /// </summary>
            public string DatabaseName
            {
                get { return this._databaseName; }
                set { this._databaseName = value; }
            }
            
            private string _password;
            
            /// <summary>
            /// Required. Gets or sets the password for the database
            /// administrator user.
            /// </summary>
            public string Password
            {
                get { return this._password; }
                set { this._password = value; }
            }
            
            private string _serverName;
            
            /// <summary>
            /// Required. Gets or sets the Azure SQL Database Server name where
            /// the database resides.
            /// </summary>
            public string ServerName
            {
                get { return this._serverName; }
                set { this._serverName = value; }
            }
            
            private string _userName;
            
            /// <summary>
            /// Required. Gets or sets the username of the database
            /// administrator user.
            /// </summary>
            public string UserName
            {
                get { return this._userName; }
                set { this._userName = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ConnectionInfoParameter class.
            /// </summary>
            public ConnectionInfoParameter()
            {
            }
        }
    }
}
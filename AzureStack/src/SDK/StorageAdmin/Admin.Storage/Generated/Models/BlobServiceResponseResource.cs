// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.AzureStack.Storage.Admin;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    public partial class BlobServiceResponseResource : ResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the BlobServiceResponseResource
        /// class.
        /// </summary>
        public BlobServiceResponseResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobServiceResponseResource
        /// class.
        /// </summary>
        /// <param name="properties">TODO</param>
        public BlobServiceResponseResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), BlobServiceResponse properties = default(BlobServiceResponse))
            : base(id, name, type, location, tags)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public BlobServiceResponse Properties { get; set; }

    }
}
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A file to be downloaded from Azure blob storage to a compute node.
    /// </summary>
    public partial class ResourceFile
    {
        /// <summary>
        /// Initializes a new instance of the ResourceFile class.
        /// </summary>
        public ResourceFile() { }

        /// <summary>
        /// Initializes a new instance of the ResourceFile class.
        /// </summary>
        /// <param name="blobSource">The URL of the file within Azure Blob Storage. This URL should include a shared access signature if the blob is not publicly readable.</param>
        /// <param name="filePath">The location to which to download the file, relative to the task's working directory.</param>
        /// <param name="fileMode">The file mode attribute in octal format.</param>
        public ResourceFile(string blobSource, string filePath, string fileMode = default(string))
        {
            BlobSource = blobSource;
            FilePath = filePath;
            FileMode = fileMode;
        }

        /// <summary>
        /// Gets or sets the URL of the file within Azure Blob Storage. This
        /// URL should include a shared access signature if the blob is not
        /// publicly readable.
        /// </summary>
        [JsonProperty(PropertyName = "blobSource")]
        public string BlobSource { get; set; }

        /// <summary>
        /// Gets or sets the location to which to download the file, relative
        /// to the task's working directory.
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file mode attribute in octal format.
        /// </summary>
        /// <remarks>
        /// This property will be ignored if it is specified for a
        /// resourceFile which will be downloaded to a Windows compute node.
        /// </remarks>
        [JsonProperty(PropertyName = "fileMode")]
        public string FileMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BlobSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BlobSource");
            }
            if (FilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePath");
            }
        }
    }
}
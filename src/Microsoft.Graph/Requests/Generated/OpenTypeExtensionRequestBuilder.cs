// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type OpenTypeExtensionRequestBuilder.
    /// </summary>
    public partial class OpenTypeExtensionRequestBuilder : ExtensionRequestBuilder, IOpenTypeExtensionRequestBuilder
    {

        /// <summary>
        /// Constructs a new OpenTypeExtensionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OpenTypeExtensionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOpenTypeExtensionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOpenTypeExtensionRequest Request(IEnumerable<Option> options)
        {
            return new OpenTypeExtensionRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}

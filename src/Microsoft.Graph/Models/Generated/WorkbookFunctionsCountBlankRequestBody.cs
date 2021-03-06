// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsCountBlankRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsCountBlankRequestBody
    {
    
        /// <summary>
        /// Gets or sets Range.
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Range { get; set; }
    
    }
}

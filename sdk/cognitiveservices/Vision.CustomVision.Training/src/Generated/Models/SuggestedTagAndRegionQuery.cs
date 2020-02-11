// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The array of result images and token containing session and
    /// continuation Ids for the next query.
    /// </summary>
    public partial class SuggestedTagAndRegionQuery
    {
        /// <summary>
        /// Initializes a new instance of the SuggestedTagAndRegionQuery class.
        /// </summary>
        public SuggestedTagAndRegionQuery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SuggestedTagAndRegionQuery class.
        /// </summary>
        /// <param name="token">Contains properties we need to fetch suggested
        /// tags for.</param>
        /// <param name="results">Result of a suggested tags and regions
        /// request of the untagged image.</param>
        public SuggestedTagAndRegionQuery(SuggestedTagAndRegionQueryToken token = default(SuggestedTagAndRegionQueryToken), IList<StoredSuggestedTagAndRegion> results = default(IList<StoredSuggestedTagAndRegion>))
        {
            Token = token;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains properties we need to fetch suggested tags
        /// for.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public SuggestedTagAndRegionQueryToken Token { get; set; }

        /// <summary>
        /// Gets result of a suggested tags and regions request of the untagged
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<StoredSuggestedTagAndRegion> Results { get; private set; }

    }
}
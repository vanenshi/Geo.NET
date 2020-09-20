﻿// <copyright file="Reference.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.Here.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// A reference about a location.
    /// </summary>
    public class Reference
    {
        /// <summary>
        /// Gets or sets the information about the supplier of this reference.
        /// </summary>
        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the place as provided by the supplier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

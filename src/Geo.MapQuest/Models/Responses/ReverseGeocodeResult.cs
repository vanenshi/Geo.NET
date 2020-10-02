﻿// <copyright file="ReverseGeocodeResult.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.MapQuest.Models.Responses
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The result of a reverse geocode request.
    /// </summary>
    public class ReverseGeocodeResult
    {
        /// <summary>
        /// Gets or sets the provided location properties passed in the reverse geocode request.
        /// </summary>
        [JsonProperty("providedLocation")]
        public ReverseGeocodeProvidedLocation ProvidedLocation { get; set; }

        /// <summary>
        /// Gets or sets the locations that match the reverse geocode request.
        /// </summary>
        [JsonProperty("locations")]
        public List<ReverseGeocodeLocation> Locations { get; set; }
    }
}

﻿// <copyright file="LocationPhoneme.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.Here.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Phonemes for a location.
    /// </summary>
    public class LocationPhoneme
    {
        /// <summary>
        /// Gets or sets phonemes for the name of the place.
        /// </summary>
        [JsonProperty("placeName")]
        public List<Phoneme> PlaceNames { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the county name.
        /// </summary>
        [JsonProperty("countryName")]
        public List<Phoneme> CountryNames { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the county name.
        /// </summary>
        [JsonProperty("county")]
        public List<Phoneme> County { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the city name.
        /// </summary>
        [JsonProperty("city")]
        public List<Phoneme> City { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the subdistrict name.
        /// </summary>
        [JsonProperty("subdistrict")]
        public List<Phoneme> SubDistrict { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the name of the place.
        /// </summary>
        [JsonProperty("street")]
        public List<Phoneme> Street { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the block.
        /// </summary>
        [JsonProperty("block")]
        public List<Phoneme> Block { get; set; }

        /// <summary>
        /// Gets or sets phonemes for the sub-block
        /// </summary>
        [JsonProperty("subblock")]
        public List<Phoneme> SubBlock { get; set; }
    }
}

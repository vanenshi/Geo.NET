﻿// <copyright file="Copyright.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.MapQuest.Models.Responses
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The copyright information.
    /// </summary>
    public class Copyright
    {
        /// <summary>
        /// Gets or sets the copyright text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the copyright image url.
        /// </summary>
        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the alternate copyright image text.
        /// </summary>
        [JsonProperty("imageAltText")]
        public string ImageAlternateText { get; set; }
    }
}

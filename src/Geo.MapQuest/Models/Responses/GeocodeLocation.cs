﻿// <copyright file="GeocodeLocation.cs" company="Geo.NET">
// Copyright (c) Geo.NET.
// Licensed under the MIT license. See the LICENSE file in the solution root for full license information.
// </copyright>

namespace Geo.MapQuest.Models.Responses
{
    using System;
    using Geo.MapQuest.Converters;
    using Geo.MapQuest.Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// The location for a geocode request.
    /// </summary>
    public class GeocodeLocation
    {
        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the neighbourhood name.
        /// </summary>
        [JsonProperty("adminArea6")]
        public string Neighbourhood { get; set; }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        [JsonProperty("adminArea5")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the county name.
        /// </summary>
        [JsonProperty("adminArea4")]
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the state name.
        /// </summary>
        [JsonProperty("adminArea3")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        [JsonProperty("adminArea1")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the precision of the geocoded location.
        /// Refer to the https://developer.mapquest.com/documentation/geocoding-api/quality-codes/ for more information.
        /// </summary>
        [JsonProperty("geocodeQualityCode")]
        public string GeocodeQualityCode { get; set; }

        /// <summary>
        /// Gets or sets the five character quality code for the precision of the geocoded location.
        /// Refer to the https://developer.mapquest.com/documentation/geocoding-api/quality-codes/ for more information.
        /// </summary>
        [JsonProperty("geocodeQuality")]
        public string GeocodeQuality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the location a drag point? This option only applies when making a dragroute call.
        /// true = location is a drag point
        /// false = location is not a drag point(default).
        /// </summary>
        [JsonProperty("dragPoint")]
        public bool DragPoint { get; set; }

        /// <summary>
        /// Gets or sets the side of street.
        /// </summary>
        [JsonProperty("sideOfStreet")]
        [JsonConverter(typeof(DefaultStringEnumConverter<SideOfStreet>))]
        public SideOfStreet SideOfStreet { get; set; }

        /// <summary>
        /// Gets or sets a string that identifies the closest road to the address for routing purposes.
        /// </summary>
        [JsonProperty("linkId")]
        public string LinkId { get; set; }

        /// <summary>
        /// Gets or sets the unknown input.
        /// </summary>
        [JsonProperty("unknownInput")]
        public string UnknownInput { get; set; }

        /// <summary>
        /// Gets or sets the type of location.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(DefaultStringEnumConverter<Enums.Type>))]
        public Enums.Type Type { get; set; }

        /// <summary>
        /// Gets or sets the url for the map with this location.
        /// </summary>
        [JsonProperty("mapUrl")]
        public Uri MapUrl { get; set; }

        /// <summary>
        /// Gets or sets the latitude/longitude for routing and is the nearest point on a road for the entrance.
        /// </summary>
        [JsonProperty("latLng")]
        public Coordinate Position { get; set; }

        /// <summary>
        /// Gets or sets the lat/lng pair that can be helpful when showing this address as a Point of Interest.
        /// </summary>
        [JsonProperty("displayLatLng")]
        public Coordinate DisplayPosition { get; set; }
    }
}

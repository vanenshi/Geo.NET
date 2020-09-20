﻿// <copyright file="HereController.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace TestApi.Controllers
{
    using System.Threading.Tasks;
    using Geo.Here.Abstractions;
    using Geo.Here.Models;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class HereController : ControllerBase
    {
        private readonly IHereGeocoding _hereGeocoding;

        /// <summary>
        /// Initializes a new instance of the <see cref="HereController"/> class.
        /// </summary>
        /// <param name="hereGeocoding">A <see cref="IHereGeocoding"/> used for here geocoding.</param>
        public HereController(IHereGeocoding hereGeocoding)
        {
            _hereGeocoding = hereGeocoding;
        }

        [HttpGet("geocoding")]
        public async Task<IActionResult> GetGeocodingResults([FromQuery] GeocodingParameters parameters)
        {
            var results = await _hereGeocoding.GeocodingAsync(parameters).ConfigureAwait(false);

            return Ok(results);
        }

        [HttpGet("reverse-geocoding")]
        public async Task<IActionResult> GetReverseGeocodingResults([FromQuery] ReverseGeocodingParameters parameters)
        {
            var results = await _hereGeocoding.ReverseGeocodingAsync(parameters).ConfigureAwait(false);

            return Ok(results);
        }

        [HttpGet("discover")]
        public async Task<IActionResult> GetDiscoverResults([FromQuery] DiscoverParameters parameters)
        {
            var results = await _hereGeocoding.DiscoverAsync(parameters).ConfigureAwait(false);

            return Ok(results);
        }
    }
}

﻿// <copyright file="IGoogleGeocoding.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.Google.Abstractions
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Geo.Google.Models.Parameters;
    using Geo.Google.Models.Responses;
    using Newtonsoft.Json;

    /// <summary>
    /// An interface for calling the Google geocoding methods.
    /// </summary>
    public interface IGoogleGeocoding
    {
        /// <summary>
        /// Calls the Google geocoding API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="GeocodingParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="GeocodingResponse"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Address' parameter is null or empty.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<GeocodingResponse> GeocodingAsync(GeocodingParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google reverse geocoding API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="ReverseGeocodingParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="GeocodingResponse"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Coordinate' parameter is null.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<GeocodingResponse> ReverseGeocodingAsync(ReverseGeocodingParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google find places API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="FindPlacesParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="FindPlaceResponse"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Input' parameter is null or invalid or the 'InputType' parameter is invalid.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<FindPlaceResponse> FindPlacesAsync(FindPlacesParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google nearby search API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="NearbySearchParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="PlaceResponse}"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">
        /// Thrown when the 'Location' parameter is null or invalid.
        /// Thrown when the 'RankBy' is Distance and a 'Radius' is entered or a 'Keyword' or 'Type' is not entered.
        /// Thrown when the 'RankBy' is not Distance and the 'Radius' is not > 0.
        /// </exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<PlaceResponse> NearbySearchAsync(NearbySearchParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google text search API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="TextSearchParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="PlaceResponse"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Query' parameter is null or invalid.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<PlaceResponse> TextSearchAsync(TextSearchParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google place details API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="DetailsParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="DetailsResponse"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Coordinate' parameter is null.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<DetailsResponse> DetailsAsync(DetailsParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google place autocomplete API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="PlacesAutocompleteParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="AutocompleteResponse{PlaceAutocomplete}"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Coordinate' parameter is null.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<AutocompleteResponse<PlaceAutocomplete>> PlaceAutocompleteAsync(PlacesAutocompleteParameters parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the Google query autocomplete API and returns the results.
        /// </summary>
        /// <param name="parameters">A <see cref="QueryAutocompleteParameters"/> with the parameters of the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used to cancel the request.</param>
        /// <returns>A <see cref="AutocompleteResponse{QueryAutocomplete}"/> with the response from Google.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter object is null or the request uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the 'Coordinate' parameter is null.</exception>
        /// <exception cref="HttpRequestException">
        /// Thrown when the request failed due to an underlying issue such as network connectivity,
        /// DNS failure, server certificate validation or timeout.
        /// </exception>
        /// <exception cref="TaskCanceledException">Thrown when the Google request is cancelled.</exception>
        /// <exception cref="JsonReaderException">Thrown when an error occurs while reading the return JSON text.</exception>
        /// <exception cref="JsonSerializationException">Thrown when when an error occurs during JSON deserialization.</exception>
        Task<AutocompleteResponse<QueryAutocomplete>> QueryAutocompleteAsync(QueryAutocompleteParameters parameters, CancellationToken cancellationToken = default);
    }
}

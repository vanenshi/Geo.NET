﻿// <copyright file="SupplierType.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.Here.Enums
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The supplier of information about a location.
    /// </summary>
    public enum SupplierType
    {
        /// <summary>
        /// Indicates the supplier of the information is a core reference.
        /// </summary>
        [EnumMember(Value = "core")]
        Core = 1,

        /// <summary>
        /// Indicates the supplier of the information is a yelp.
        /// </summary>
        [EnumMember(Value = "yelp")]
        Yelp,

        /// <summary>
        /// Indicates the supplier of the information is a trip advisor.
        /// </summary>
        [EnumMember(Value = "tripadvisor")]
        TripAdvisor,
    }
}

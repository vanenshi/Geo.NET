﻿// <copyright file="HereKeyContainerShould.cs" company="Geo.NET">
// Copyright (c) Geo.NET.
// Licensed under the MIT license. See the LICENSE file in the solution root for full license information.
// </copyright>

namespace Geo.Here.Tests.Services
{
    using FluentAssertions;
    using Geo.Here.Services;
    using Xunit;

    /// <summary>
    /// Unit tests for the <see cref="HereKeyContainer"/> class.
    /// </summary>
    public class HereKeyContainerShould
    {
        /// <summary>
        /// Tests the key is properly set.
        /// </summary>
        [Fact]
        public void SetKey()
        {
            var keyContainer = new HereKeyContainer("abc123");
            keyContainer.GetKey().Should().Be("abc123");
        }
    }
}
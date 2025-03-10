﻿// <copyright file="GeoCoreException.cs" company="Geo.NET">
// Copyright (c) Geo.NET.
// Licensed under the MIT license. See the LICENSE file in the solution root for full license information.
// </copyright>

namespace Geo.Core.Models.Exceptions
{
    using System;
    using System.Collections;
    using System.Globalization;

    /// <summary>
    /// A base exception typ eused by all derived exceptions, which overrides the ToString method to display the Data in the exception as well.
    /// </summary>
    public abstract class GeoCoreException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoreException"/> class.
        /// </summary>
        protected GeoCoreException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoreException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        protected GeoCoreException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoreException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="inner">The exception that is the cause of the current exception.</param>
        protected GeoCoreException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return base.ToString() + GetData();
        }

        /// <summary>
        /// Formats the information in the Data field of the exception and displays it when printing.
        /// </summary>
        /// <returns>A string with the formatted data.</returns>
        private string GetData()
        {
            if (Data.Count == 0)
            {
                return string.Empty;
            }

            var data = Environment.NewLine + "Data:";
            foreach (DictionaryEntry item in Data)
            {
                data += Environment.NewLine + "   " + string.Format(CultureInfo.InvariantCulture, "{0}: {1}", item.Key, item.Value);
            }

            return data;
        }
    }
}

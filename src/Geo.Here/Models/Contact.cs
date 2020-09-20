﻿// <copyright file="Contact.cs" company="Geo.NET">
// Copyright (c) Geo.NET. All rights reserved.
// </copyright>

namespace Geo.Here.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A gropu of contact information for a location.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets a list of phone numbers associated with a location.
        /// </summary>
        [JsonProperty("phone")]
        public List<ContactItem> Phones { get; set; }

        /// <summary>
        /// Gets or sets a list of mobile numbers associated with a location.
        /// </summary>
        [JsonProperty("mobile")]
        public List<ContactItem> Mobiles { get; set; }

        /// <summary>
        /// Gets or sets a list of toll free numbers associated with a location.
        /// </summary>
        [JsonProperty("tollFree")]
        public List<ContactItem> TollFrees { get; set; }

        /// <summary>
        /// Gets or sets a list of fax numbers associated with a location.
        /// </summary>
        [JsonProperty("fax")]
        public List<ContactItem> Faxes { get; set; }

        /// <summary>
        /// Gets or sets a list of websites associated with a location.
        /// </summary>
        [JsonProperty("www")]
        public List<ContactItem> Websites { get; set; }

        /// <summary>
        /// Gets or sets a list of emails associated with a location.
        /// </summary>
        [JsonProperty("email")]
        public List<ContactItem> Emails { get; set; }
    }
}

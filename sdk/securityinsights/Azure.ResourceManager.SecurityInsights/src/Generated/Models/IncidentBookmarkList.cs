// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of incident bookmarks. </summary>
    internal partial class IncidentBookmarkList
    {
        /// <summary> Initializes a new instance of IncidentBookmarkList. </summary>
        /// <param name="value"> Array of incident bookmarks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IncidentBookmarkList(IEnumerable<HuntingBookmark> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of IncidentBookmarkList. </summary>
        /// <param name="value"> Array of incident bookmarks. </param>
        internal IncidentBookmarkList(IReadOnlyList<HuntingBookmark> value)
        {
            Value = value;
        }

        /// <summary> Array of incident bookmarks. </summary>
        public IReadOnlyList<HuntingBookmark> Value { get; }
    }
}

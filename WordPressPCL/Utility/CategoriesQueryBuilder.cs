﻿using System;
using System.Collections.Generic;
using System.Text;
using WordPressPCL.Models;

namespace WordPressPCL.Utility
{
    /// <summary>
    /// Category Query Builder class to construct queries with valid parameters
    /// </summary>
    public class CategoriesQueryBuilder : QueryBuilder
    {
        /// <summary>
        /// Current page of the collection.
        /// </summary>
        /// <remarks>Default: 1</remarks>
        [QueryText("page")]
        public int Page { get; set; }
        /// <summary>
        /// Maximum number of items to be returned in result set.
        /// </summary>
        /// <remarks>Default: 10</remarks>
        [QueryText("per_page")]
        public int PerPage { get; set; }
        /// <summary>
        /// Limit results to those matching a string.
        /// </summary>
        [QueryText("search")]
        public string Search { get; set; }

        /// <summary>
        /// Ensure result set excludes specific IDs.
        /// </summary>
        [QueryText("exclude")]
        public int[] Exclude { get; set; }
        /// <summary>
        /// Limit result set to specific IDs.
        /// </summary>
        [QueryText("include")]
        public int[] Include { get; set; }
        /// <summary>
        /// Offset the result set by a specific number of items.
        /// </summary>
        [QueryText("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Sort collection by object attribute.
        /// </summary>
        /// <remarks>Default: name
        /// One of: id, include, name, slug, term_group, description, count</remarks>
        [QueryText("orderby")]
        public TermsOrderBy OrderBy { get; set; }

        /// <summary>
        /// Limit result set to users with a specific slug.
        /// </summary>
        [QueryText("slug")]
        public string[] Slugs { get; set; }
        /// <summary>
        /// Whether to hide terms not assigned to any posts.
        /// </summary>
        [QueryText("hide_empty")]
        public bool HideEmpty { get; set; }
        /// <summary>
        /// Limit result set to terms assigned to a specific post.
        /// </summary>
        [QueryText("post")]
        public int Post { get; set; }
        /// <summary>
        /// Limit result set to terms assigned to a specific parent.
        /// </summary>
        [QueryText("parent")]
        public int Parent { get; set; }

    }
}

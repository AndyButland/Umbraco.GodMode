﻿using System;

namespace Diplo.GodMode.Models
{
    /// <summary>
    /// Represents a view component mapping
    /// </summary>
    public class ComponentMap
    {
        /// <summary>
        /// Gets the ID of the Template the component belongs to
        /// </summary>
        public int TemplateId { get; set; }

        /// <summary>
        /// Gets the alias of the template the component belongs to
        /// </summary>
        public string TemplateAlias { get; set; }

        /// <summary>
        /// Gets the partial name
        /// </summary>
        public string Name { get; set; }
    }
}
﻿using Lifti.ItemTokenization;
using System.Collections.Generic;

namespace Lifti
{
    /// <summary>
    /// Describes the configuration that should be used when indexing
    /// an strongly typed item against an index.
    /// </summary>
    internal interface IItemTokenizationOptions
    {
        /// <summary>
        /// Gets the configuration for the fields associated to this instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFieldTokenization> GetConfiguredFields();
    }
}

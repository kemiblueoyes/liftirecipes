﻿using System;
using System.Collections.Generic;

namespace Lifti.ItemTokenization
{
    /// <inheritdoc/>
    public class ItemTokenizationOptions<TItem, TKey> : IItemTokenizationOptions
    {
        internal ItemTokenizationOptions(
            Func<TItem, TKey> keyReader,
            IReadOnlyList<FieldTokenizationOptions<TItem>> fieldTokenizationOptions)
        {
            this.KeyReader = keyReader;
            this.FieldTokenization = fieldTokenizationOptions;
        }

        /// <summary>
        /// Gets the delegate capable of reading the key from the item.
        /// </summary>
        public Func<TItem, TKey> KeyReader { get; }

        /// <summary>
        /// Gets the set of configurations that determine how fields should be read from an object of 
        /// type <typeparamref name="TItem"/>.
        /// </summary>
        public IReadOnlyList<FieldTokenizationOptions<TItem>> FieldTokenization { get; }

        /// <inheritdoc />
        IEnumerable<IFieldTokenization> IItemTokenizationOptions.GetConfiguredFields()
        {
            return this.FieldTokenization;
        }
    }
}

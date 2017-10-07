// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Data;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Storage
{
    /// <summary>
    ///     <para>
    ///         Represents the mapping between a .NET <see cref="sbyte" /> type and a database type.
    ///     </para>
    ///     <para>
    ///         This type is typically used by database providers (and other extensions). It is generally
    ///         not used in application code.
    ///     </para>
    /// </summary>
    public class SByteTypeMapping : RelationalTypeMapping
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SByteTypeMapping" /> class.
        /// </summary>
        /// <param name="storeType"> The name of the database type. </param>
        /// <param name="dbType"> The <see cref="DbType" /> to be used. </param>
        public SByteTypeMapping(
            [NotNull] string storeType,
            DbType? dbType = null)
            : base(storeType, typeof(sbyte), dbType)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SByteTypeMapping" /> class.
        /// </summary>
        /// <param name="storeType"> The name of the database type. </param>
        /// <param name="converter"> Converts types to and from the store whenever this mapping is used. </param>
        /// <param name="dbType"> The <see cref="DbType" /> to be used. </param>
        public SByteTypeMapping(
            [NotNull] string storeType,
            [NotNull] ValueConverter converter,
            DbType? dbType = null)
            : base(storeType, typeof(sbyte), converter, dbType)
        {
        }

        /// <summary>
        ///     Creates a copy of this mapping.
        /// </summary>
        /// <param name="storeType"> The name of the database type. </param>
        /// <param name="size"> The size of data the property is configured to store, or null if no size is configured. </param>
        /// <returns> The newly created mapping. </returns>
        public override RelationalTypeMapping Clone(string storeType, int? size)
            => new SByteTypeMapping(storeType, Converter, DbType);
    }
}

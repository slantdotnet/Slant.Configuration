// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Slant.Extensions.Configuration
{
    /// <summary>
    /// Represents a source of configuration key/values for an application.
    /// </summary>
    public interface IConfigurationSource
    {
        /// <summary>
        /// Builds the <see cref="IConfigurationProvider"/> for this source.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/>.</param>
        /// <returns></returns>
        IConfigurationProvider Build(IConfigurationBuilder builder);
    }
}
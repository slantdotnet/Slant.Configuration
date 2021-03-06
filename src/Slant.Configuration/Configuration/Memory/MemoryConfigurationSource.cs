// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Slant.Extensions.Configuration.Memory
{
    /// <summary>
    /// In-memory key-value storage as a configuration source
    /// </summary>
    public class MemoryConfigurationSource : IConfigurationSource
    {
        public IEnumerable<KeyValuePair<string, string>> InitialData { get; set; }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new MemoryConfigurationProvider(this);
        }
    }
}

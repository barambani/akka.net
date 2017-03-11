﻿//-----------------------------------------------------------------------
// <copyright file="Timeouts.cs" company="Akka.NET Project">
//     Copyright (C) 2015-2016 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Akka.Streams.Tests.TCK
{
    /// <summary>
    /// Specifies timeouts for the TCK
    /// </summary>
    static class Timeouts
    {
        public const int PublisherShutdownTimeoutMillis = 3000;

        public const int DefaultTimeoutMillis = 800;
        
        public static readonly TimeSpan ShutdownTimeout = TimeSpan.FromSeconds(30);
    }
}

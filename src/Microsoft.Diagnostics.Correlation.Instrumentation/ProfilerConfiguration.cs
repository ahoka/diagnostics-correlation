﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Net;
using Microsoft.Diagnostics.Correlation.Common;
using Microsoft.Diagnostics.Correlation.Common.Instrumentation;

namespace Microsoft.Diagnostics.Correlation.Instrumentation
{
    /// <summary>
    /// Provides generic configuration for profiler instrumentation
    /// </summary>
    /// <typeparam name="TContext">Type of correlation context</typeparam>
    public class ProfilerConfiguration<TContext> : Configuration<TContext, WebRequest, WebResponse> where TContext : ICorrelationContext<TContext>
    {
    }
}

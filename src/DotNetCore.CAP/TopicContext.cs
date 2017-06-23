﻿using System;
using System.Threading;

namespace DotNetCore.CAP
{
    public class TopicContext
    {
        public TopicContext()
        {
        }

        public TopicContext(IServiceProvider provider, CancellationToken cancellationToken)
        {
            ServiceProvider = provider;
            CancellationToken = cancellationToken;
        }

        public IServiceProvider ServiceProvider { get; set; }

        public CancellationToken CancellationToken { get; }
    }
}
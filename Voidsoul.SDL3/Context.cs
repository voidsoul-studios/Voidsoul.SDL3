// SPDX-FileCopyrightText: 2026 Voidsoul Studios
// SPDX-License-Identifier: Zlib

using System;
using System.Runtime.ConstrainedExecution;

namespace Voidsoul.SDL3;

public sealed class Context
    : CriticalFinalizerObject
    , IDisposable
{
    private bool disposedValue;

    private void Dispose(bool _)
    {
        if (disposedValue)
        {
            return;
        }

        disposedValue = true;
    }

    ~Context()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

﻿using System;
using PostSharp.Sdk.CodeModel;
using PostSharp.Toolkit.Diagnostics.Weaver.Logging.Writers;

namespace PostSharp.Toolkit.Diagnostics.Weaver.Logging.Trace
{
    public class TraceBackend : LoggingBackend
    {
        protected override ILoggingBackendWriter CreateBackendWriter(ModuleDeclaration module)
        {
            return new WriteLineBackendWriter(module, typeof(System.Diagnostics.Trace));
        }
    }
}
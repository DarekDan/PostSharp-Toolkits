﻿using System;
using PostSharp.Sdk.CodeModel;
using PostSharp.Toolkit.Diagnostics.Weaver.Logging;
using PostSharp.Toolkit.Diagnostics.Weaver.Logging.Writers;

namespace PostSharp.Toolkit.Diagnostics.Weaver.NLog.Logging
{
    internal sealed class NLogBackend : LoggerBasedBackend
    {
        protected override ILoggingBackendWriter CreateBackendWriter(ModuleDeclaration module)
        {
            LoggingContext nlogContext = new NLogContext(module);

            return new LoggingContextBackendWriter(nlogContext);
        }
    }
}
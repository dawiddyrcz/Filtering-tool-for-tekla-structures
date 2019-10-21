/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringToolStarter.Exceptions
{
    [Serializable]
    class FilteringToolStarterIOException : Exception
    {
        public FilteringToolStarterIOException(string message, Exception innerException) : base(message, innerException) { }
    }
}

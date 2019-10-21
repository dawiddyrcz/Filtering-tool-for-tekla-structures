/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringToolStarter.Exceptions
{
    [Serializable]
    class FilteringToolStarterException : Exception
    {
        public FilteringToolStarterException(string message) : base(message) { }
        public FilteringToolStarterException(string message, Exception innerException) : base(message, innerException) { }
    }
}

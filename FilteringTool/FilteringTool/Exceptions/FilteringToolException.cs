/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringTool.Exceptions
{
    [Serializable]
    public class FilteringToolException : Exception
    {
        public FilteringToolException(string message) : base(message)
        {

        }

        public FilteringToolException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

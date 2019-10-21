/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringTool.Exceptions
{
    [Serializable]
    public class FilteringToolTeklaSettingsException : Exception
    {
        public FilteringToolTeklaSettingsException(string message) : base(message)
        {

        }

        public FilteringToolTeklaSettingsException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

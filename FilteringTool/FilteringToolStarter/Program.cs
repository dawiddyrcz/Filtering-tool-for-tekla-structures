/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringToolStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var filteringToolStarter = new FilteringToolStarter();
                filteringToolStarter.StartFilteringTool();
            }
            catch (Exception ex)
            {
                Exceptions.ExceptionHandler.HandleException(ex);
            }
        }
    }
}

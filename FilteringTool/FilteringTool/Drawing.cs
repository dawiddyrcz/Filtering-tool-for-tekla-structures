/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool
{
    /// <summary>Operations with drawings in the opened tekla structures model</summary>
    internal class Drawing
    {
        /// <summary>Checks if any drawing is opened in the opened tekla strucutes model</summary>
        /// <returns>True if drawing editor is not opened.</returns>
        public static bool IsNotOpened()
        {
            var drawinhHandler = new Tekla.Structures.Drawing.DrawingHandler();
            return drawinhHandler.GetActiveDrawing() == null;
        }
    }
}

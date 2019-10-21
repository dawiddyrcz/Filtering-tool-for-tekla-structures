/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.Collections.Generic;
using Tekla.Structures.Model.UI;

namespace FilteringTool
{
    /// <summary>handles operations with model views in opened tekla structures. </summary>
    internal class ModelViews
    {
        /// <summary>Gets selected model views from the opened tekla structures model</summary>
        public static List<View> GetSelectedModelViews()
        {
            var viewEnumerator = ViewHandler.GetSelectedViews();
            var retList = new List<View>(viewEnumerator.Count);

            while (viewEnumerator.MoveNext())
            {
                retList.Add(viewEnumerator.Current);
            }
            return retList;
        }

        /// <summary>Selects all model views in the opened tekla structures model</summary>
        public static void SelectAllModelViews()
        {
            if (Tekla.Structures.TeklaStructures.Connect())
            {
                TeklaMacroDirectory.CheckIfExists();
                var akit = new Tekla.Structures.MacroBuilder();
                var viewNames = GetAllViewNames();
                viewNames = CorrectTempViewsNames(viewNames);

                akit.Callback("acmd_create_dim_general_assembly_drawing", "", "main_frame");
                akit.ListSelect("Create GA-drawing", "dia_view_name_list", viewNames);
                akit.PushButton("Pushbutton_128", "Create GA-drawing");

                akit.Run();
                akit = null;
            }
        }

        /// <summary>Gets all model views from the opened tekla structures model</summary>
        public static List<View> GetAllModelViews()
        {
            var viewEnumerator = ViewHandler.GetAllViews();
            var retList = new List<View>(viewEnumerator.Count);

            while (viewEnumerator.MoveNext())
            {
                retList.Add(viewEnumerator.Current);
            }
            return retList;
        }

        private static string[] GetAllViewNames()
        {
            var views = GetAllModelViews();
            var retList = new List<string>();

            foreach (var view in views)
            {
                retList.Add(view.Name);
            }
            return retList.ToArray();
        }

        //Tempolary views have different name than name returned from API
        //This solution is ugly but work. It add many posible names to list
        private static string[] CorrectTempViewsNames(string[] viewNames)
        {
            var retList = new List<string>();

            foreach (var name in viewNames)
            {
                if (name.Contains("("))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        retList.Add("View_0" + i + " " + name);
                    }
                    for (int i = 10; i < 100; i++)
                    {
                        retList.Add("View_" + i + " " + name);
                    }
                }
                retList.Add(name);
            }
            return retList.ToArray();
        }
    }
}

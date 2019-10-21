/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.IO;
using Tekla.Structures.Model;
using FilteringTool.FTSettings;

namespace FilteringTool
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("", "IDE0017")]

    ///<summary>This class creates and changes view filters in the opened tekla structures model. 
    ///Filter is created from the "PhaseToFilter" list</summary>
    internal class ViewFilter
    {
        private const string ATTRIBUTE_DIRECTORY_NAME_IN_TS_MODEL = "attributes";
        private const string FILTER_FILE_EXTENSION = ".VObjGrp";

        /// <summary>List of phase numbers which will be written to view filter file. Filter is created when "set" methods are called</summary>
        public List<int> PhasesToFilter { get; set; } = new List<int>();

        /// <summary>Iterates through selected views in tekla structures and change its view filter</summary>
        /// <exception cref="Exceptions.FilteringToolException"></exception>
        public void SetViewFilterOfSelectedViews()
        {
            string viewFilterName = CurrentFilter.Name();
            CreateViewFilterFile(viewFilterName);
            var selectedViews = ModelViews.GetSelectedModelViews();

            foreach (var view in selectedViews)
            {
                SetFilter(viewFilterName, view);
            }
        }

        /// <summary>Iterates through all views in tekla structures and change its view filter</summary>
        /// <exception cref="Exceptions.FilteringToolException"></exception>
        public void SetViewFilterOfAllViews()
        {
            string viewFilterName = CurrentFilter.Name();
            CreateViewFilterFile(viewFilterName);
            var allViews = ModelViews.GetAllModelViews();

            foreach (var view in allViews)
            {
                SetFilter(viewFilterName, view);
            }
        }

        /// <summary>Sets filter to the tekla structures view</summary>
        private static void SetFilter(string viewFilterName, Tekla.Structures.Model.UI.View view)
        {
            view.ViewFilter = viewFilterName;
            Tekla.Structures.Model.UI.ViewCamera Camera = new Tekla.Structures.Model.UI.ViewCamera();
            Camera.View = view;
            Camera.Select();
            view.Modify();
            Camera.Modify();
        }

        ///<summary>Create new view filter file in attributes folder of current tekla model</summary>
        ///<param name="Name">Filter file name without extension</param>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        private void CreateViewFilterFile(string Name)
        {
            if (PhasesToFilter.Count == 0) return;
            Model Model = new Model();
            ModelInfo ModelInfo = Model.GetInfo();

            FileStream fileStream = null;
            StreamWriter file = null;

            string filterType = GetCurrenFilterTypeName();

            try
            {
                fileStream = new FileStream(Path.Combine(ModelInfo.ModelPath, ATTRIBUTE_DIRECTORY_NAME_IN_TS_MODEL, Name + FILTER_FILE_EXTENSION), FileMode.Create);
                file = new StreamWriter(fileStream);

                file.WriteLine("TITLE_OBJECT_GROUP ");
                file.WriteLine("{");

                int count = PhasesToFilter.Count;

                int multiple = 1;
                if (Settings.AddComponentFilter) multiple = 2;

                int weldFiltersCount = 0;
                if (Settings.AddWeldMinusOneFilter) weldFiltersCount = 2;

                file.WriteLine("    Version= 1.05 ");
                file.WriteLine("    Count= " + (count * multiple + 1 + weldFiltersCount));

                file.WriteLine("    SECTION_OBJECT_GROUP");
                file.WriteLine("    {");

                file.WriteLine("\t1");
                file.WriteLine("\t1");

                file.WriteLine("\t" + filterType);

                file.WriteLine("\tproPHASE");
                file.WriteLine("\talbl_Phase");
                file.WriteLine("\t==");
                file.WriteLine("\talbl_Equals");

                file.WriteLine("\t0");
                file.WriteLine("\t0");
                file.WriteLine("\t||");

                file.WriteLine("    }");
                file.WriteLine("");

                int i = 1;
                foreach (int phaseNumber in PhasesToFilter)
                {
                    file.WriteLine("    SECTION_OBJECT_GROUP");
                    file.WriteLine("    {");

                    file.WriteLine("\t0");
                    file.WriteLine("\t1");

                    file.WriteLine("\t" + filterType);

                    file.WriteLine("\tproPHASE");
                    file.WriteLine("\talbl_Phase");
                    file.WriteLine("\t==");
                    file.WriteLine("\talbl_Equals");

                    file.WriteLine("\t" + phaseNumber);

                    if (i == count)
                    {
                        file.WriteLine("\t1");
                        file.WriteLine("\t&&");
                    }
                    else
                    {
                        file.WriteLine("\t0");
                        file.WriteLine("\t||");
                    }

                    file.WriteLine("    }");
                    file.WriteLine("");
                    i++;
                }

                if (Settings.AddComponentFilter)
                {
                    i = 1;
                    foreach (int phaseNumber in PhasesToFilter)
                    {
                        file.WriteLine("    SECTION_OBJECT_GROUP");
                        file.WriteLine("    {");

                        if (i == 1)
                            file.WriteLine("\t1");
                        else
                            file.WriteLine("\t0");

                        file.WriteLine("\t1");

                        file.WriteLine("\tco_component");

                        file.WriteLine("\tproPHASE");
                        file.WriteLine("\talbl_Phase");
                        file.WriteLine("\t==");
                        file.WriteLine("\talbl_Equals");

                        file.WriteLine("\t" + phaseNumber);

                        if (i == count)
                        {
                            file.WriteLine("\t1");
                            file.WriteLine("\t&&");
                        }
                        else
                        {
                            file.WriteLine("\t0");
                            file.WriteLine("\t||");
                        }

                        file.WriteLine("    }");
                        file.WriteLine("");
                        i++;
                    }
                }

                if (Settings.AddWeldMinusOneFilter)
                {
                    //Weld -1 
                    file.WriteLine("    SECTION_OBJECT_GROUP");
                    file.WriteLine("    {");

                    file.WriteLine("\t0");
                    file.WriteLine("\t1");

                    file.WriteLine("\tco_weld");

                    file.WriteLine("\tproSIZE");
                    file.WriteLine("\talbl_Size_above_line");
                    file.WriteLine("\t>");
                    file.WriteLine("\talbl_GreaterThan");

                    file.WriteLine("\t-1.00");

                    file.WriteLine("\t0");
                    file.WriteLine("\t&&");

                    file.WriteLine("    }");
                    file.WriteLine("");


                    file.WriteLine("    SECTION_OBJECT_GROUP");
                    file.WriteLine("    {");

                    file.WriteLine("\t0");
                    file.WriteLine("\t1");

                    file.WriteLine("\tco_weld");

                    file.WriteLine("\tproSIZE2");
                    file.WriteLine("\talbl_Size_below_line");
                    file.WriteLine("\t>");
                    file.WriteLine("\talbl_GreaterThan");

                    file.WriteLine("\t-1.00");

                    file.WriteLine("\t0");
                    file.WriteLine("\t&&");

                    file.WriteLine("    }");
                    file.WriteLine("");
                }

                //End of file
                file.WriteLine("}");
            }
            catch (Exception ex)
            {
                string message = "Cannot create view filter name: " + Name;
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);
                throw new Exceptions.FilteringToolException(message, ex);
            }
            finally
            {
                if (file != null) file.Close();
                if (fileStream != null) fileStream.Close();
            }
        }

        /// <summary>Checks filtering tool settings and return string with filter type: object, assembly, part or bolt</summary>
        public static string GetCurrenFilterTypeName()
        {
            string retString = "co_assembly";
            switch (Settings.CurrentFilterType)
            {
                case FilterType.Object:
                    retString = "co_object";
                    break;
                case FilterType.Assembly:
                    retString = "co_assembly";
                    break;
                case FilterType.Part:
                    retString = "co_part";
                    break;
                case FilterType.Bolt:
                    retString = "co_bolt";
                    break;
            }
            return retString;
        }
    }
}

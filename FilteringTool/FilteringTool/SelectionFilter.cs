/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.IO;
using Tekla.Structures.Model;
using FilteringTool.FTSettings;

namespace FilteringTool
{
    ///<summary>This class creates and changes selection filters in the opened tekla structures model. 
    ///Filter is created from the "PhaseToFilter" list</summary>
    internal class SelectionFilter
    {
        private const string ATTRIBUTE_DIRECTORY_NAME = "attributes";
        private const string FILTER_FILE_EXTENSION = ".SObjGrp";

        /// <summary>List of phase numbers which will be written to selection filter file. Filter is created when "set" methods are called</summary>
        public List<int> PhasesToFilter { get; set; } = new List<int>();

        /// <summary>Sets selection filter in the opened tekla structures model.</summary>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public void SetCurrentSelectionFilter()
        {
            var filterName = CurrentFilter.Name();
            CreateSelectionFilterFile(filterName);
            SetSelectionFilter(filterName);
        }

        /// <summary>Sets "standard" selection filter in the opened tekla structures model. 
        /// This method is used to turn off filtering tool selection filter</summary>
        public void SetStandardSelectionFilter()
        {
            SetSelectionFilter("standard");
        }

        private void SetSelectionFilter(string name)
        {
            if (Tekla.Structures.TeklaStructures.Connect())
            {
                TeklaMacroDirectory.CheckIfExists();
                var akit = new Tekla.Structures.MacroBuilder();
                akit.ValueChange("main_frame", "sel_filter", name);
                akit.Run();
                akit = null;
            }
        }

        /// <summary>Creates selection filter in the opened tekla structures model in the folder "attributes"</summary>
        /// <param name="Name">Filter file name without extension</param>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        private void CreateSelectionFilterFile(string Name)
        {
            if (PhasesToFilter.Count == 0) return;
            Model model = new Model();
            ModelInfo modelInfo = model.GetInfo();

            FileStream fileStream = null;
            StreamWriter file = null;

            string filterType = GetCurrenFilterTypeName();

            try
            {
                var fileName = Path.Combine(modelInfo.ModelPath, ATTRIBUTE_DIRECTORY_NAME, Name + FILTER_FILE_EXTENSION);
                fileStream = new FileStream(fileName, FileMode.Create);
                file = new StreamWriter(fileStream);

                file.WriteLine("TITLE_OBJECT_GROUP ");
                file.WriteLine("{");

                int count = PhasesToFilter.Count;

                file.WriteLine("    Version= 1.05 ");
                file.WriteLine("    Count= " + (count + 1));

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

                file.WriteLine("");

                //End of file
                file.WriteLine("}");
            }
            catch (Exception ex)
            {
                string message = "Cannot create selection filter name: " + Name;
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

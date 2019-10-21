/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.Collections.Generic;

namespace FilteringToolStarter
{
    internal class Settings
    {
        public const string INPUT_DIRECTORY_NAME = "FilteringTool";
        public const string TEMP_DIRECTORY_NAME = "FilteringToolTemp";
        public const string FILTERING_TOOL_EXE_NAME = "FilteringTool.exe";
        public const string FILTERING_TOOL_CONFIG_NAME = "FilteringTool.exe.config";
        public const string TEKLA_STRUCTURES_EXE_NAME = "TeklaStructures.exe";
        public const string TEKLA_STRUCTURES_CONFIG_NAME = "TeklaStructures.exe.config";

        public static List<string> ADDITIONAL_FILE_NAMES = new List<string>()
        {
            "ReleaseNote.txt",
            "License.txt"
        };
    }
}

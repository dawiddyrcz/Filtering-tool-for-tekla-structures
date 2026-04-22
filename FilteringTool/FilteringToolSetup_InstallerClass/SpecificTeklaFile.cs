namespace FilteringToolSetup
{
    internal class SpecificTeklaFile
    {
        public string TeklaVersion { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;

        public SpecificTeklaFile(string teklaVersion, string fileName)
        {
            TeklaVersion = teklaVersion;
            FileName = fileName;
        }
    }
}

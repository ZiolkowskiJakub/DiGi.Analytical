namespace DiGi.Analytical.Urban.Constants
{
    /// <summary>
    /// Provides constant file filters used for urban analytical operations.
    /// </summary>
    public static class FileFilter
    {
        /// <summary>
        /// Gets the file filter used for selecting urban model files.
        /// </summary>
        public static Core.IO.Classes.FileFilter UrbanModelFile { get; } = Core.IO.Create.FileFilter(FileTypeName.UrbanModelFile, FileExtension.UrbanModelFile);
    }
}
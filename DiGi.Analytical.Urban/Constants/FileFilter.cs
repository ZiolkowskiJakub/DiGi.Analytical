namespace DiGi.Analytical.Urban.Constans
{
    public static class FileFilter
    {
        public static Core.IO.Classes.FileFilter UrbanModelFile { get; } = Core.IO.Create.FileFilter(FileTypeName.UrbanModelFile, FileExtension.UrbanModelFile);
    }
}
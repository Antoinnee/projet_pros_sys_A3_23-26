namespace ConsoleApp1.src.SaveType
{

    public interface TypeSave
    {
        // M�thode save (Contenant Diff�rentielle ou Compl�te)
        void save(FileInfo file, string targetFilePath);

    }
}
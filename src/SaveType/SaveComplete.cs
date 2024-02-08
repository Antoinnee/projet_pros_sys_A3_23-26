namespace ConsoleApp1.src.SaveType
{
    internal class SaveComplete : TypeSave
    {

        public SaveComplete()
        {

        }

        // M�thode save permettant de sauvegarder tous les fichiers d'un r�pertoire
        public void save(FileInfo file, string targetFilePath)
        {
            try
            {
                if (File.Exists(targetFilePath))
                {
                    try
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), "tempfile");
                        file.CopyTo(tempFilePath, true);
                    }
                    catch (Exception ex)
                    {
                    }

                    File.Delete(targetFilePath);
                    file.CopyTo(targetFilePath);
                }

                else
                    file.CopyTo(targetFilePath);
            }

            catch (Exception ex)
            {
                //erreur
            }
        }

        public String toString()
        {
            return "comp";
        }
    }
}

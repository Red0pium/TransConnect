namespace TransConnectForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Client.NouveauClient("123456789101112","BRONNEC","Mathys",DateTime.Now,"9 rue poirier de Narçay","Mathys.Bronnec@gmail.com","0651362680");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Clients clients = new Clients();
            // clients.LectureFichierClient(); //lis le tableau des clients et ajoute chaque client à la liste
            ApplicationConfiguration.Initialize();
            Formulaire_principal FormPrincipal = new Formulaire_principal();
            Application.Run(FormPrincipal);
        }
    }
}
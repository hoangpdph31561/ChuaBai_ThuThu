using ChuaBai_ThiThu.View;

namespace ChuaBai_ThiThu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Scaffold-DbContext 'Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QuanLySanPham());
        }
    }
}
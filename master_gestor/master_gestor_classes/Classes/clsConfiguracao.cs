using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace master_gestor_classes.Classes
{
    public class clsConfiguracao
    {
        public static string sArquivoConfig = "arquivoteste.txt";
        public static string sPastaPadrao = @"J:\ProjetosGit\Master_Gestor\master_gestor\";

        public static void FU_LerConfiguracoes()
        {
            if(File.Exists(sPastaPadrao+sArquivoConfig))
            {
                String linha;
                StreamReader srArquivoConfig = new StreamReader(sPastaPadrao + sArquivoConfig);
                while ((linha = srArquivoConfig.ReadLine()) != null)
                {
                    if (linha.Split('=')[0].ToString() == "HOST") clsUteis.sHost = linha.Split('=')[1].ToString();
                    if (linha.Split('=')[0].ToString() == "PORTA") clsUteis.iPorta = Convert.ToInt32(linha.Split('=')[1].ToString());
                    if (linha.Split('=')[0].ToString() == "USER") clsUteis.sUserBD = linha.Split('=')[1].ToString();
                    if (linha.Split('=')[0].ToString() == "BANCO") clsUteis.sBanco = linha.Split('=')[1].ToString();
                    if (linha.Split('=')[0].ToString() == "COLABORADOR") clsUteis.sColaborador = linha.Split('=')[1].ToString();
                    if (linha.Split('=')[0].ToString() == "PASSWORD") clsUteis.sPassword = linha.Split('=')[1].ToString();
                }
                srArquivoConfig.Close();
            }
        }
    }
}

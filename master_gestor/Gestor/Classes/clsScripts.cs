using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Classes
{
    class clsScripts
    {
        public static int iVersaoOficial = 1;
        public static int iVersaoBanco = 0;

        public static void ExecutaAtualizacao()
        {
            for (int iContador = iVersaoBanco; iContador < iVersaoOficial; iContador++)
            {
                if (iVersaoBanco < iVersaoOficial)
                {
                    if (iVersaoBanco < 1)
                    {
                        iVersaoBanco++;

                        if(BancoV1()) clsBanco.ExecutaScript("update versaobd set versaobd =" + iVersaoBanco + ";");
                    }
                }
            }

        }

        public static bool FU_CriaTabela(string sNomeTabela)
        {
            string sScrip = "CREATE TABLE " + sNomeTabela.ToLower()+";";
            if (clsBanco.ExecutaScript(sScrip)) return true;
            else return false;
        }

        public static bool FU_CriaCampo(string sNomeTabela, string sCampo)
        {
            string sScrip = "ALTER TABLE " + sNomeTabela.ToLower() + " ADD COLUMN "+sCampo+";";
            if (clsBanco.ExecutaScript(sScrip)) return true;
            else return false;
        }        

        public static bool BancoV1()
        {
            if (!FU_CriaTabela("versaobd()")) return false;
            if (!FU_CriaCampo("versaobd", "id_versao serial NOT NULL")) return false;
            if (!FU_CriaCampo("versaobd", "versaobd integer NOT NULL DEFAULT 0")) return false;
            if (!FU_CriaCampo("versaobd", "dt_exporta timestamp with time zone DEFAULT current_timestamp")) return false;
            if (!FU_CriaCampo("versaobd", "dth_exporta timestamp with time zone DEFAULT CURRENT_TIMESTAMP")) return false;
            if (!clsBanco.ExecutaScript("INSERT INTO public.versaobd(versaobd) VALUES (0);")) return false;
            if (!FU_CriaTabela("cad_usuario()")) return false;
            if (!FU_CriaCampo("cad_usuario", "id_usuario serial NOT NULL")) return false;
            if (!FU_CriaCampo("cad_usuario", "nome_usuario character varying(40) NOT NULL")) return false;
            if (!FU_CriaCampo("cad_usuario", "login character varying(30) NOT NULL")) return false;
            if (!FU_CriaCampo("cad_usuario", "senha character varying(30) NOT NULL")) return false;
            if (!FU_CriaCampo("cad_usuario", "email character varying(80)")) return false;
            if (!FU_CriaCampo("cad_usuario", "celular character varying(14)")) return false;
            if (!FU_CriaCampo("cad_usuario", "ativo boolean NOT NULL DEFAULT true")) return false;
            if (!FU_CriaCampo("cad_usuario", "dth_exporta timestamp with time zone DEFAULT CURRENT_TIMESTAMP")) return false;
            return true;
        }

    }
}

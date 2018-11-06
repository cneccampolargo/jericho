using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Controller
{
    public static class ConfigController
    {
        /// <summary>
        /// Retorna 0 se o valor da chave for igual ao valor do db
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        public static bool selectCfg(string chave)
        {
           
                ConfigDao cfgselect = new ConfigDao();
                Config result = cfgselect.selectCFG(chave);

                if (result.Valor == "0")
                {
                    return false;
                }
                else
                {
                    return true;
                }               
        }
        /// <summary>
        /// Testa pra ver se o valor é igual ao do banco, e se nao for altera
        /// </summary>
        /// <param name="chave"></param>
        public static void updateCFG(string chave)
        {



            if (selectCfg(chave) == false)
            {
                ConfigDao cfgupdate = new ConfigDao();
                cfgupdate.updateCFG(chave, "1");
            }
            else
            {
                ConfigDao cfgupdate = new ConfigDao();
                cfgupdate.updateCFG(chave, "0");
            }

           
        }
    }
}

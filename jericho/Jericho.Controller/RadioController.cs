using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Controller
{
   public class RadioController
    {
        public static int InsertRadio(Radio _radio)
        {
            RadioDao radioDao = new RadioDao();
           return radioDao.InsertRadio(_radio);
        }
        public static int UpdateRadio(Radio _radio)
        {
            RadioDao radioDao = new RadioDao();
            return radioDao.UpdateRadio(_radio);
        }
        public static List<Radio> GetRadioByName(string _name)
        {
            RadioDao radioDao = new RadioDao();
            return radioDao.GetRadioByName(_name);
        }
        public static Radio GetRadioById(int _id)
        {
            RadioDao radioDao = new RadioDao();
            return radioDao.GetRadioById(_id);
        }
        public static int DeleteRadio(int _id)
        {
            RadioDao radioDao = new RadioDao();
            return radioDao.DeleteRadio(_id);
        }
        public static List<Radio> GetAll()
        {
            RadioDao radioDao = new RadioDao();
            return radioDao.GetAll();
        }
        public static List<Radio> BuscarTudo(string parameter)
        {
            RadioDao radioDao = new RadioDao();
            return radioDao.BuscarTudoRadio(parameter);

        }


    }
}

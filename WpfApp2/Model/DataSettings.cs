using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    class DataSettings
    {
        MCSEntities db = new MCSEntities();

        public List<newEquipment> getListOfCars()
        {
            List<newEquipment> newEquipments = new List<newEquipment>();
            newEquipments = db.newEquipment.ToList();
            return newEquipments;
        }
     }
}

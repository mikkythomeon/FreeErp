using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeErp.Quality
{
    class QualitySystem
    {

    }

    class Defect
    {
        private DefectType _DefectType;
        public DateTime LoggedDate { get; set; }
        public Inventory.Part part { get; set; }
        public System.Location location { get; set; }
    }


    class DefectType
    {
        public string ID { get; set; }
        public string Description { get; set; }

    }

    class DefectCategory
    {
        private Dictionary<string, DefectType> DefectTypes;

    }


}

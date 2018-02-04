using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_03_SavannahPyle
{
    enum DesktopMaterial //: int
    {
        Laminate = 100,
        Oak = 200,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    class Desk
    {

        //private string surfaceMaterial;
        public DesktopMaterial material;

        public int Depth { get; set; }
        public int Width { get; set; }
        public int NumDrawers { get; set; }

        public void SelectMaterial(String newMaterial)
        {
            if (newMaterial == "Laminate")
                material = DesktopMaterial.Laminate;
            if (newMaterial == "Oak")
                material = DesktopMaterial.Oak;
            if (newMaterial == "Pine")
                material = DesktopMaterial.Pine;
            if (newMaterial == "Roosewood")
                material = DesktopMaterial.Rosewood;
            if (newMaterial == "Veneer")
                material = DesktopMaterial.Veneer;
        }
    }

    
}

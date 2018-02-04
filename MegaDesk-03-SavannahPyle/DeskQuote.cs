using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_03_SavannahPyle
{
    class DeskQuote
    {
        public Desk desk { get; set; }

        public int rushPrice;
        public int quote;
        public string Name { get; set; }
       

        //public string SurfaceMaterial { get; set; }
        public int Rush { get; set; }


        public int CalculateRush()
        {
            int surfaceArea = desk.Depth * desk.Width;
            int rushDay = Rush;

            if (rushDay == 3)
            {
                if (surfaceArea < 1000)
                {
                    rushPrice = 60;
                }

                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushPrice = 70;
                }

                else if (surfaceArea > 2000)
                {
                    rushPrice = 80;
                }

            }//end day 3

            else if (rushDay == 5)
            {
                if (surfaceArea < 1000)
                {
                    rushPrice = 40;
                }

                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushPrice = 50;
                }

                else if (surfaceArea > 2000)
                {
                    rushPrice = 60;
                }
            } // end day 5

            else if (rushDay == 7)
            {
                if (surfaceArea < 1000)
                {
                    rushPrice = 30;
                }

                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushPrice = 35;
                }

                else if (surfaceArea > 2000)
                {
                    rushPrice = 40;
                }
            } //end day 7

            else if (rushDay == 10)
            {
                rushPrice = 0;
            }
            return rushPrice;
        } //close function

        public int calculateQuote()
        {
            //Desk desk;
            int rush = CalculateRush();
            int priceD = desk.NumDrawers * 50;
            int basePrice = 200;
            int surfaceArea = desk.Depth * desk.Width;
            int saPrice = surfaceArea * 1;


            int mat = (int)desk.material;
            Console.WriteLine(mat);
            //int mat = Desk.SelectMaterial();

            quote = rush + priceD + basePrice + saPrice + mat;
            
            return quote;
        }
    }//close class
} //close namespace

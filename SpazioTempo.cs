using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSpazioTempo
{
    //construction of SpazioTempo class
    class SpazioTempo
    {
        //declaration of private class variables
        private double v_auto1, v_auto2, distanza_auto;
        //Default constructor
        public SpazioTempo()
        {
            v_auto1 = 0;
            v_auto2 = 0;
            distanza_auto = 0;
        }
        //declaration of properties
        //Property for the first car
        public double Vauto1
        {
            get { return v_auto1; }
            set
            {
                //value check
                if (value < 0)
                {
                    throw new Exception("La velocità deve essere maggiore o uguale a 0");
                }
                else
                {
                    v_auto1 = value;
                }
            }
        }
        //Property for the second car
        public double Vauto2
        {
            get { return v_auto2; }
            set
            {
                //value check
                if(value < 0)
                {
                    throw new Exception("La velocità deve essere maggiore o uguale a 0");
                }else
                {
                    v_auto2 = value;
                }
            }
        }
        //Property to input the initial distance between the two cars
        public double distanzaAuto
        {
            get { return distanza_auto; }
            set
            {
                //value check
                if (value <= 0)
                {
                    throw new Exception("La distanza tra le due auto deve essere maggiore di zero");
                }
                else
                {
                    distanza_auto = value;
                }
            }
        }
        //method that calculates when the car arrives in the same position
        public double tempoIncontro()
        {
            double tempo;
            tempo = distanza_auto / (v_auto1 + v_auto2);
            return tempo;
        }
        //method that calculates after how many kilometers first car arrives in the same position of second car
        public double spazioIncontroA1()
        {
            double dist;
            dist = (distanza_auto / (v_auto1 + v_auto2)) * v_auto1;
            return dist;
        }
        //method that calculates after how many kilometers second car arrives in the same position of first car
        public double spazioIncontroA2()
        {
            double dist;
            dist = (distanza_auto / (v_auto1 + v_auto2)) * v_auto2;
            return dist;
        }
    }
}

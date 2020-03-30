using System;

namespace TheCoffeMachine
{
    class Milk
    {
        private int volumeMilk = 0;//mililiter
        private int volumeOneCupMilk = 100;

        public Milk(int volumeMilk)
        {
            this.volumeMilk = volumeMilk;
        }

        public Boolean isAvailable()
        {
            return volumeMilk >= volumeOneCupMilk;
        }

        public void addWater(int volumeMilk)
        {
            this.volumeMilk += volumeMilk;
        }

        public int makeOneCupMilk()
        {
            this.volumeMilk = this.volumeMilk - this.volumeOneCupMilk;
            return volumeOneCupMilk;
        }

        public int getVolumeMilk()
        {
            return this.volumeMilk;
        }
    }
}

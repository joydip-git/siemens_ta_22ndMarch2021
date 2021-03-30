using System;

namespace SerializationApp.Entities
{
    [Serializable]
    public class Maruti : Car
    {
        bool hasSixthGear;
        public Maruti()
        {

        }
        public Maruti(string modelName, string bodyColor, bool hasAc, string make, AudioSystem carAudio, bool sixthGear)
            : base(modelName, bodyColor, hasAc, make, carAudio)
        {
            this.hasSixthGear = sixthGear;
        }

        public bool HasSixthGear { get => hasSixthGear; set => hasSixthGear = value; }
    }
}

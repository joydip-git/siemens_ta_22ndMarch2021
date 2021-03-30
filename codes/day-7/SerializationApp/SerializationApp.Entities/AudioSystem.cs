using System;

namespace SerializationApp.Entities
{
    [Serializable]
    public class AudioSystem
    {
        string modelName;
        string make;
        public AudioSystem()
        {

        }
        public AudioSystem(string modelName, string make)
        {
            this.modelName = modelName;
            this.make = make;
        }

        public string ModelName { get => modelName; set => modelName = value; }
        public string Make { get => make; set => make = value; }
    }
}

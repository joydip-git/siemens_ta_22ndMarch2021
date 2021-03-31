using System;

namespace SerializationApp.Entities
{
    [Serializable]
    public class Car //:Object
    {
        string modelName;
        string bodyColor;
        bool hasAc;
        string make;
        AudioSystem carAudio;

        public Car()
        {

        }
        public Car(string modelName, string bodyColor, bool hasAc, string make, AudioSystem carAudio)
        {
            this.modelName = modelName;
            this.bodyColor = bodyColor;
            this.hasAc = hasAc;
            this.make = make;
            this.carAudio = carAudio;
        }

        public string ModelName { get => modelName; set => modelName = value; }
        public string BodyColor { get => bodyColor; set => bodyColor = value; }
        public bool HasAc { get => hasAc; set => hasAc = value; }
        public string Make { get => make; set => make = value; }
        public AudioSystem CarAudio { get => carAudio; set => carAudio = value; }

        public override string ToString()
        {
            return $"Model Name: {modelName}, Color: {bodyColor}, AC? {hasAc}, Make:{make}, Audio:{carAudio}";
        }
    }
}

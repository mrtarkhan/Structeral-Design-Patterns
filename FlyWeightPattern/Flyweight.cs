namespace FlyWeightPattern {
    public abstract class Flyweight {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void DoOperation ();

    }
}
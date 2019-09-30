using System;
using System.Collections;

namespace FlyWeightPattern {
    public static class FlyWeightFactory {
        private static Hashtable flyweights = new Hashtable ();
        private static object _lock = new object ();

        public static T GetFlyweight<T> () where T : Flyweight, new () {
            lock (_lock) {
                var typeName = typeof(T).ToString ();
                if (flyweights.ContainsKey (typeName)) 
                    return ((T) flyweights[typeName]);
                else {
                    Console.WriteLine($"new {typeName} flyweigh created");
                    var item = new T ();
                    flyweights.Add (typeName, item);
                    return item;
                }
            }
        }

    }
}
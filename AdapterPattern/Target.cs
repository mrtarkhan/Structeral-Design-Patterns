using System;

namespace AdapterPattern {
    public class Adapter : ITarget {

        private readonly Adaptee _adaptee;

        public Adapter (Adaptee adaptee) {
            _adaptee = adaptee;
        }

        public void ShowVersion () {
            var os = _adaptee.GetOsDetails ();
            Console.WriteLine ("Version String: {0}", os.VersionString);
            Console.WriteLine ("Version Information:");
            Console.WriteLine ("   Major: {0}", os.Version.Major);
            Console.WriteLine ("   Minor: {0}", os.Version.Minor);
        }
    }
}
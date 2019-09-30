using System;


namespace AdapterPattern
{
    //the class that has some functionality but it is incompatible with our system
    // or does not have an interface(for example it is a low level functionality of OS) to work with
    public class Adaptee
    {
        public OperatingSystem GetOsDetails() {
            var os = Environment.OSVersion;
            Console.WriteLine("Current OS Information:\n");
            Console.WriteLine("Platform: {0:G}", os.Platform);
            Console.WriteLine("Service Pack: '{0}'", os.ServicePack);
            return os;
        }
    }
}
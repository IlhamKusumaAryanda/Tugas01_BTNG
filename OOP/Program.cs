using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car kijang = new Car();
            Car Ferrari = new Car();
            Car Toyota = new Car();
            kijang.setSpeed(200);
            Ferrari.setSpeed(100);
            Toyota.setMerk("Toyota");
            //Audi.detailMobil();
            
        }
    }

    class Car
    {
        public string merk = "kijang";
        
        public void setMerk(string merkbaru)
        {
            this.merk = merkbaru;
            Console.WriteLine(this.merk);
        }
        int Speed = 200;
        public void setSpeed(int Speedbaru)
        {
            this.Speed = Speedbaru;
            Console.WriteLine(this.Speed);
        }
        private void  privatemethod()
        {
            Console.WriteLine("Private Method");
        }
        public void publicMethod()
        {
            privatemethod();
        }
    }
}

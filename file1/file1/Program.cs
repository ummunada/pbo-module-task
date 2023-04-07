using file1;

namespace file1
{
    public class Processor
    {
        public string merk; 
        public string tipe;
    }

    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    public class AMD: Processor
    { 
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    public class Vga
    {
        public string merk;
    }

    public class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class Amd : Vga
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }

    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan() 
        {
            Console.WriteLine("Laptop" + " " + merk + " " + tipe + " " + "menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop" + " " + merk + " " + tipe + " " + "dimatikan");
        }
    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop" + " " + merk + " " + tipe + " " + "sedang memainkan game");
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
}
internal class program
{
    static void Main(string[]args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();

        Console.WriteLine("========== laptop1 ==========");
        Console.WriteLine("Merk Vga : " + laptop1.vga.merk);
        Console.WriteLine("Merk Processor : " + laptop1.processor.merk);
        Console.WriteLine("Tipe Processor : " + laptop1.processor.tipe);

        //laptop1.Ngoding();

        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new Amd();
        laptop2.processor = new Ryzen();

        Console.WriteLine("\n ========== laptop2 ==========");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Predator predator = new Predator();
        predator.vga = new Amd();
        predator.processor = new CoreI7();

        Console.WriteLine("\n ========== predator ==========");
        predator.BermainGame();

        ACER acer = new Predator();
        //acer.BermainGame();
    }
}
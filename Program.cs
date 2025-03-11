class Program
{
    static void Main()
    {
        Console.WriteLine("kode produk laptop : " + KodeProduk.getKodeProduk("Laptop"));
        Console.WriteLine("kode produk Smartwatch : " + KodeProduk.getKodeProduk("Smartwatch"));
        Console.WriteLine("kode produk Kamera : " + KodeProduk.getKodeProduk("Kamera"));

        Console.WriteLine("");
        Console.WriteLine("");

        FanLaptop fanlaptop = new FanLaptop();
        fanlaptop.turboShortcut();
        fanlaptop.modeDown();
        fanlaptop.modeDown();
        fanlaptop.modeUp();
        fanlaptop.modeUp();
        fanlaptop.turboShortcut();
    }
    
}

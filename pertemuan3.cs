using system;

class csharpdasar {

    static void main(string[] args) {
        Console.WriteLine("Halo dunia!";);
    }
     
     var hasil = 10 + 14;
     var hasil11 = 50 - 29;
     var hasil12 = -23;
     var hasil13 = 5 * 4;
     var hasil14 = 20 / 4;
     var hasil15 = 30 % 4;

     Console>WriteLine(hasil);
     Console>WriteLine(hasil11);
     Console>WriteLine(hasil12);
     Console>WriteLine(hasil13);
     Console>WriteLine(hasil14);
     Console>WriteLine(hasil15);

     int a = 3;
     Console.WriteLine(a);
     Console.WriteLine(++a);
     Console.WriteLine(a++);
     Console.WriteLine(--a);
     Console.WriteLine(a--);
     Console.WriteLine(a);

     string[] divisi = {"web","mobile","game","mulmed","jaringan"};
     Console.WriteLine(divisi[0]);
     Console.WriteLine(divisi[1]);
     Console.WriteLine(divisi[2]);
     Console.WriteLine(divisi[3]);
     Console.WriteLine(divisi[4]);

       string[] names = new string[5];
       names[0] = "web";
       names[0] = "mobile";
       names[0] = "game";
       names[0] = "mulmed";
       names[0] = "jaringan";

       int[,,] number = new int [2,2,3];
       int[,,] numbers = {{{1,2,3},{4,5,6},{7.8.9},{10,11,12}}};
       Console.WriteLine(number[0,0,0]);
       Console.WriteLine(numbers[1,1,0]);

       var names = new list<string> {"game","mobile","web"};
       for (int i = 0; i < names.count; i++)
       {
        Console.WriteLine(names[i]+"");
       }
       list<int> angka = new list<int>();

       angka.Add(1);
       angka.Add(2);
       angka.Add(3);

       angka.AddRange(new int[3]{4,5,6});
       angka.Remove(1);
       angka.RemoveAt(0);
       angka.IndexOf(3);
       Console.WriteLine(angka.Contains(10));
       Console.WriteLine(angka.Contains());

       foreach (var a in angka)
       {
        Console.Write(a + "");
       }

       int i = 5;
       if (1 > i)
       {
        Console.WriteLine("benar!");
       }
       else
       {
        Console.WriteLine("salah!");
       }

       int nilai = 75;
       if (nilai >= 90)
       {
        Console.WriteLine("anda mendapatkan A.");
       }
       else if (nilai >= 80)
       {
        Console.WriteLine("anda mendapatkan B");
       }
       else if (nilai >= 70)
       {
        Console.WriteLine("anda mendapatkan C.");
       }
       else
       {
        Console.WriteLine("anda mendapatkan D atau E.");
       }

       int nilai = 75;
       switch (nilai)
       {
        case > 95:
            Console.WriteLine("memuaskan");
            break;
        case > 80:
            Console.WriteLine("baik");
            break;
        case > 75:
            Console.WriteLine("cukup");
            break;
        default:
            Console.WriteLine("kurang");
            break;

       }
    int angka = 10;
        string hasil = (angka % 2 == 0) ? "genap" : "ganjil";
        Console.WriteLine(hasil);
    
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("perulangan ke " + i);
    }

    int i = 0;
    while (i < 5)
    {
        Console.WriteLine("perualangan ke " + i);
        i++;
    }

    int i = 5;
    do
    {
        Console.WriteLine("perualangan ke " + i);
        i++;
    } while (i < 5);

    int i = 0;
    int[] angka = new int [5] {1,2,3,4,5};
    foreach (int a in angka)
    {
        Console.WriteLine("ini adalah isi array urut dari indkes ke " + i++ + "yaitu" + a);
    }

    for (int i + 0; i < 10; i++)
    {
        Console.WriteLine("perualangan ke " + i);

        if (i == 5)
        {
            break;
        }
    }
    for (int i + 0; i < 10; i++)
    {
        if(i % 2 == 0)
        {
            continue;
        }
        Console.WriteLine(i);
    }

    public static void main(string[] args)
    {
        Tampil();
    }
    public static void Tampil()
    {
        Console.WriteLine("game");
    }

    public static void main(string[] args)
    {
        int hasil = return();
        Console.WriteLine("hasil");
    }
    public static int return()
    {
        return 5;
    }

     public static void main(string[] args)
     {
        int hasil = Counter(10);
        Console.WriteLine("hasil");
     }
     public static int Counter (int damage)
     {
        return damage + 5;
     }

}
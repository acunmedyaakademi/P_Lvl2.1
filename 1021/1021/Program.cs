using System.Collections.Generic;
using LinkedList;

public class Program
{
    public static MyLinkedList myList = new MyLinkedList();

    public static void Main(string[] args)
    {
        HomeMenu();
    }
    public static void HomeMenu()
    {
        try
        {
            Console.WriteLine("---Sisteme Hoşgeldin---");
            Console.WriteLine("1-Kayıt Ekle");
            Console.WriteLine("2-Kayıt Sil");
            Console.WriteLine("3-Kayıt Listele");
            Console.WriteLine("4-Kayıt Güncelle");
            Console.WriteLine("5-Çıkış");
            int choose;
            if (int.TryParse(Console.ReadLine(), out choose))
            {
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        AddList();
                        break;
                    case 2:
                        Console.Clear();
                        DeleteList();
                        break;
                    case 3:
                        Console.Clear();
                        Listt();
                        break;
                    case 4:
                        Console.Clear();
                        UpdateList();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Hatalı giriş yaptın Lütfen Tekrar dene");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Kodunda hata var Git düzelt" + ex.Message);
        }
    }
    public static void AddList()
    {
        Console.WriteLine("Kayıt İşlemine hoşgeldin");
        Console.WriteLine("Okul numarası Girin: ");
        int sNo = IntControl();
        Console.WriteLine("Öğrenci Adını Girin: ");
        string name = StringControl();
        Console.WriteLine("Öğrenci Soyadını Girin: ");
        string surname = StringControl();
        Console.WriteLine("Öğretmenin Adı: ");
        string tName = StringControl();
        Console.WriteLine("Öğretmen Soyadı: ");
        string tSurname = StringControl();
        Console.WriteLine("Ders Adı Girin: ");
        string lName = StringControl();
        Console.WriteLine("1 Notu Girin: ");
        int note1 = IntControl();
        Console.WriteLine("2 Notu Girin: ");
        int note2 = IntControl();
        int avrage = (note1 + note2) / 2;
        Console.WriteLine("Not Ortalaması: " + avrage);
        
        myList.AddToEnd(sNo, name, surname, tName, tSurname, lName, note1, note2, avrage);

        Console.ReadKey(); Console.Clear(); HomeMenu();
    }
    public static void DeleteList()
    {
        Console.WriteLine("Silme İşlemine Hoşgeldin\n");
        Console.WriteLine("Silmek istediğin Verideki OkulNo sunu yaz: ");
        int sNo = IntControl();

        myList.Delete(sNo);
        Console.ReadKey(); Console.Clear(); HomeMenu();
    }
    public static void Listt()
    {
        Console.WriteLine("--İşte LinkedList teki Verilerimiz--");
        myList.List();

        Console.ReadKey(); Console.Clear(); HomeMenu();
    }
    public static void UpdateList()
    {
        Console.WriteLine("Kayıt Güncellemeye Hoşgeldin");
        Console.WriteLine("Güncellemek İstediğin OkulNo: ");
        int sNo = IntControl();
        Console.WriteLine("Öğrenci Adını Girin: ");
        string name = StringControl();
        Console.WriteLine("Öğrenci Soyadını Girin: ");
        string surname = StringControl();
        Console.WriteLine("Öğretmenin Adı: ");
        string tName = StringControl();
        Console.WriteLine("Öğretmen Soyadı: ");
        string tSurname = StringControl();
        Console.WriteLine("Ders Adı Girin: ");
        string lName = StringControl();
        Console.WriteLine("1 Notu Girin: ");
        int note1 = IntControl();
        Console.WriteLine("2 Notu Girin: ");
        int note2 = IntControl();
        int avrage = (note1 + note2) / 2;
        Console.WriteLine("Not Ortalaması: " + avrage);

        myList.Update(sNo, name, surname, tName, tSurname, lName, note1, note2, avrage);
        Console.ReadKey(); Console.Clear(); HomeMenu();
    }
    static string StringControl()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out _))        //buradaki _ out tryprse da dönüşüm olduktan sonra depolamak için var ama biz depolamıyacağız sadece saklıyacağız bu durumuda çızgi yapıyor
            {
                return input;
            }

            Console.WriteLine("Hata: Geçerli bir metin giriniz");
        }
    }
    static int IntControl()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Hata: Geçerli bir sayı Giriniz");
            }
        }
    }
}
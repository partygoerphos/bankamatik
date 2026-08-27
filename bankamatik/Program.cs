using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 25000;
            string sifre = "ab18";
            int hak = 3;

        
            Console.WriteLine("Kartlı işlem için 1'i, Kartsız işlem için 2'yi tuşlayınız.");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                if (hak > 0)

                {
                    Console.WriteLine("şifre giriniz:");
                    string sfr = Console.ReadLine();
                    hak--;



                    if (sfr == sifre)
                    { goto anamenu; }

                    else
                    {
                    hakk:
                        Console.WriteLine("şifreniz hatalı lütfen tekrar giriniz");
                        Console.ReadLine();

                        hak--;

                        if (hak == 0)
                        {
                            Console.WriteLine("hakkınız bitti bb");
                            goto cıkıs;
                        }



                        goto hakk;


                    }
                }


            anamenu:;

                Console.WriteLine("Para Çekmek için 1/Para yatırmak için 2/Para transferleri için 3/Eğitim ödemeleri için 4/Ödemeler için 5/Bilgi güncelleme için 6yı tuşlayınız");
                int secim2 = Convert.ToInt32(Console.ReadLine());

                if (secim2 == 1)
                {
                    Console.WriteLine("para çekilecek tutarı giriniz");
                    int tutar = Convert.ToInt32(Console.ReadLine());

                    if (tutar < bakiye)
                    {
                        Console.WriteLine("para çekme başarılı");
                    }
                    else
                    { Console.WriteLine("bakiye yetersiz"); }

                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                    int tus = Convert.ToInt32(Console.ReadLine());

                    if (tus == 9)
                    { goto anamenu; }

                    else if (tus == 0)
                    { goto cıkıs; }


                }
                else if (secim2 == 2)

                {
                    Console.WriteLine("kredi kartı için 1/kendi hesabınıza yatırmak için 2yi tuşlayınız");
                    int secim3 = Convert.ToInt32(Console.ReadLine());

                    if (secim3 == 1)
                    {
                        Console.WriteLine("12 haneli kart numaranızı giriniz");
                        string no = Convert.ToString(Console.ReadLine());

                        int tutar = 25000;
                        if (no.Length == 12)
                        {

                            Console.WriteLine("para yatırılacak tutarı giriniz");
                            Console.ReadLine();


                            if (tutar == bakiye)
                            {
                                Console.WriteLine("para yatırma başarılı");

                            }
                            else
                            {
                                Console.WriteLine("bakiye yetersiz");


                            }
                        }
                        else
                        {
                            Console.WriteLine("kart numaranızı doğru girmediniz");
                        }

                    }
                    else if (secim3 == 2)
                    {
                        Console.WriteLine("kredi kartınıza yatırılacak parayı giriniz");
                        Console.ReadLine();
                    }
                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                    int tus = Convert.ToInt32(Console.ReadLine());

                    if (tus == 9)
                    { goto anamenu; }

                    else if (tus == 0)
                    { goto cıkıs; }

                }
                else if (secim2 == 3)
                {
                    Console.WriteLine("başka hesaba eft için 1/başka hesaba havale için 2yi tuşlayınız");
                    int scm = Convert.ToInt32(Console.ReadLine());

                    if (scm == 1)
                    {
                        Console.WriteLine("eft numarası giriniz");
                        string eft = Convert.ToString(Console.ReadLine());

                        if (eft.StartsWith("TR") && eft.Length == 14)
                        { Console.WriteLine("eft işlemi başarılı"); }

                        else
                        { Console.WriteLine("işlem başarısız"); }

                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu; }

                        else if (tus == 0)
                        { goto cıkıs; }

                    }
                    else if (scm == 2)
                    {
                        Console.WriteLine("hesap için 11 haneli numarayı giriniz");
                        string no = Convert.ToString(Console.ReadLine());
                        if (no.Length == 11)
                        { Console.WriteLine("transfer başarılı"); }

                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu; }

                        else if (tus == 0)
                        { goto cıkıs; }

                    }
                }
                else if (secim2 == 4)
                {
                    Console.WriteLine("eğitim ödemeleri sayfası arızalı");
                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                    int tus = Convert.ToInt32(Console.ReadLine());

                    if (tus == 9)
                    { goto anamenu; }

                    else if (tus == 0)
                    { goto cıkıs; }

                }
                else if (secim2 == 5)
                {
                    Console.WriteLine("elektrik faturası için 1/telefon faturası için 2/internet faturası için 3/su faturası için 4/ogs ödemeleri için 5i tuşlayınız");
                    int secim5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ödenecek fatura tutarını giriniz");
                    int fatura = Convert.ToInt32(Console.ReadLine());

                    if (fatura < bakiye)
                    {
                        Console.WriteLine("ödeme başarılı");
                    }
                    else
                    { Console.WriteLine("yetersiz bakiye"); }

                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                    int tus = Convert.ToInt32(Console.ReadLine());

                    if (tus == 9)
                    { goto anamenu; }

                    else if (tus == 0)
                    { goto cıkıs; }

                }
                else if (secim2 == 6)
                {
                    Console.WriteLine("şifrenizi değiştirmek için eski şifrenizi giriniz");
                    string sifre2 = Console.ReadLine();

                    if (sifre == sifre2)
                    {
                        Console.WriteLine("yeni şifre giriniz");
                        Console.ReadLine();

                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu; }

                        else if (tus == 0)
                        { goto cıkıs; }
                    }

                }
            }

            else if (secim == 2)
            {
            anamenu2:;

                Console.WriteLine("cepbank para çekmek için 1/para yatırmak için 2/kredi kartı ödemesi için 3/eğitim ödemeleri için 4/ödemeler için 5i tuşlayınız");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                { long tc = 12345678901;
                    long number = 09876543210;

                    Console.WriteLine("tc giriniz");
                    long tece = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("telefon numaranızı giriniz");
                    long nmbr = Convert.ToInt64(Console.ReadLine());
                    hak--;


                hakk2:
                    if (tc == tece && number == nmbr)
                    {
                        Console.WriteLine("hesabınıza 1000tl yatırıldı");

                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu2; }

                        else if (tus == 0)
                        { goto cıkıs; }

                    }
                    

                    else
                    {

                        Console.WriteLine("bilgiler hatalı lütfen tekrar giriniz");
                        Console.ReadLine();

                        hak--;
                        if (hak == 0)
                        {
                            Console.WriteLine("hakkınız bitti bb ve 1 saat kitlendiniz");
                            goto cıkıs;
                        }



                        goto hakk2;


                    }
                }
                else if (choice == 2)
                { Console.WriteLine("nakit ödemeleri için 1/para yatırmak için 2/kredi kartı ödemeleri için 3/eğitim ödemeleri için 4/ödemeler için 5i tuşlayınız");
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    { Console.WriteLine("en az 12 haneli kart numaranızı girin");
                        string kartno = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("tc nizi giriniz");
                        string tc = Convert.ToString(Console.ReadLine());

                        if (tc.Length==1)

                        { Console.WriteLine("nakit ödenecek tutarı giriiz");
                            Console.ReadLine();
                        }
                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu2; }

                        else if (tus == 0)
                        { goto cıkıs; }

                    } 
                }
                else if(choice==2)
                {
                    Console.WriteLine("en az 12 haneli kart numaranızı girin");
                    string kartno = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("hesap numaranızı giriniz");
                    Console.ReadLine();

                    Console.WriteLine("yatırılacak tutarı giriniz");
                    Console.ReadLine();
                     
                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                    int tus = Convert.ToInt32(Console.ReadLine());

                    if (tus == 9)
                    { goto anamenu2; }

                    else if (tus == 0)
                    { goto cıkıs; }

                }
                else if(choice==3)
                {
                    Console.WriteLine("başka hesaba eft için 1/başka hesaba havale için 2yi tuşlayınız");
                    int scm = Convert.ToInt32(Console.ReadLine());

                    if (scm == 1)
                    {
                        Console.WriteLine("eft numarası giriniz");
                        string eft = Convert.ToString(Console.ReadLine());

                        if (eft.StartsWith("TR") && eft.Length == 14)
                        { Console.WriteLine("eft işlemi başarılı"); }
                        else
                        { Console.WriteLine("işlem başarısız"); }

                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu2; }

                        else if (tus == 0)
                        { goto cıkıs; }

                    }
                    else if (scm == 2)
                    {
                        Console.WriteLine("hesap için 11 haneli numarayı giriniz");
                        string no = Convert.ToString(Console.ReadLine());

                        if (no.Length == 11)
                        { Console.WriteLine("transfer başarılı"); }

                        Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                        int tus = Convert.ToInt32(Console.ReadLine());

                        if (tus == 9)
                        { goto anamenu2; }

                        else if (tus == 0)
                        { goto cıkıs; }

                    }
                }
                else if(choice==4)
                {
                    Console.WriteLine("eğitim ödemeleri sayfası arızalı");
                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");

                    int tus = Convert.ToInt32(Console.ReadLine());

                    if (tus == 9)
                    { goto anamenu2; }

                    else if (tus == 0)
                    { goto cıkıs; }

                }
                else if(choice==5)
                {
                    Console.WriteLine("elektrik faturası için 1/telefon faturası için 2/internet faturası için 3/su faturası için 4/ogs ödemeleri için 5i tuşlayınız");
                    int secim5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ödenecek fatura tutarını giriniz");
                    int fatura = Convert.ToInt32(Console.ReadLine());
                    if (fatura < bakiye)
                    {
                        Console.WriteLine("ödeme başarılı");
                    }
                    else
                    { Console.WriteLine("yetersiz bakiye"); }


                    Console.WriteLine("anamenüye dönmek için 9/çıkmak için 0ı tuşlayınız");
                    int tus = Convert.ToInt32(Console.ReadLine());
                    if (tus == 9)
                    { goto anamenu2; }

                    else if (tus == 0)
                    { goto cıkıs; }
                }
            }       




        cıkıs:
            { Console.WriteLine("görüşmek üzere"); }
            
        
        }
    }
}

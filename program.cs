namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharo";

            //Length:
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, "Merhaba!"));

            //CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
                                                             // 0 Birinci değişken ikinci değişkene eşit olursa 
                                                             // 1 Birinci değişken ikinci değişkenden daha büyük bir karakter sayısına sahipse
                                                             //-1 Birinci değişken ikinci değişkenden daha küçük bir karakter sayısına sahipse

            //Compare
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            //IgnoreCase durumu eğer 3. parametreye true dersek büyük küçük harflerin
            //farklı olmasını görmezden gelir.
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            //Değişken1'in içinde değişken2 var mı bulursa "True" dönecek.

            //EndWith
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            //Değişken Hoşgeldiniz ile bitiyor mu?

            //EndWith
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz!"));
            //Değişken Hoşgeldiniz ile başlıyor mu?

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            //Yukarıdaki kod bloğu değişkenin içinde CS'yi arayacak
            //İlk bulduğu yerde C'nin indexini döndürecek
            Console.WriteLine(degisken.IndexOf("CanGokce"));
            //Eğer ifadeyi değişkenin içinde bulamazsa -1 döndürecektir

            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i"));
            //Sondan başa doğru gidip i içeren ilk gördüğü indexi döndürür

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));
            //Belirtili indexten itibaren verilen string'i ekler

            //PadLeft ve PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            //Bu değişken2'nin soluna 30'a tamamlayacak kadar boşluk ekler
            //Yani bu değişkenin karakter sayısı + eklenen boşluk sayısı 30
            //olması gerekiyor
            //
            //Boşluk yerine yazdığımız bir karakteri ekleyen yöntem:
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            //degisken2'nin karakter sayısı 30'dan küçük ise
            //karakter sayısını 30'a tamamlayana kadar solundan yıldız ekle

            //Remove
            int startIndex = 10;
            Console.WriteLine(degisken.Remove(startIndex));
            //Verilen indexten başlayarak son indexe kadar olan veriyi string
            //ifadesi içerisinden siler
            Console.WriteLine(degisken.Remove(10));
            //10. indexten başla ve son index'e kadar sil

            int deleteAmount = 3;
            Console.WriteLine(degisken.Remove(startIndex, deleteAmount));
            Console.WriteLine(degisken.Remove(5, 3));
            //Verilen indexten başlayarak ikinci sayı kadar olan veriyi string
            //ifadesi içerisinden siler
            Console.WriteLine(degisken.Remove(5, 3));
            //5. indexten başla ve 3 karakter sil

            //baştan tek bir karakter silmek için:
            Console.WriteLine(degisken.Remove(0, 1));
            //0. indexten başla 1 karakter sil

            //Replace
            //İlk değeri ikinci değer ile değiştir
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            //CSharp kelimesini görürsen C# olarak değiştir
            Console.WriteLine(degisken.Replace(" ", "*"));
            //Boşluk görürsen yıldız ile değiştir

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);
            //Bütün string dizisini boşluk gördüğün yerde dizi elemanı olarak ayır
            //Ve index numarası 1 olan elemanı getir

            //Substring
            Console.WriteLine(degisken.Substring(4));
            //4. indexten başlayarak son karaktere kadar olanları getir.
            Console.WriteLine(degisken.Substring(4, 6));
            //4. indexten başla 6 adet karakter getir





        }
    }
}

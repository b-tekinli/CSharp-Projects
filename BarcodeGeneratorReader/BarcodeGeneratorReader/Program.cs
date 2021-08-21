using IronBarCode;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BarcodeGeneratorReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BARCODE READER ***");

            string path = Environment.CurrentDirectory;

            string barcodeName, barcodeContent;

            Dictionary<int, string> menu = new();

            menu.Add(1, "Barkod Oluştur");
            menu.Add(2, "Barkodu Göster");

        APoint:
            foreach (var item in menu)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }

            byte code = 0;
            byte.TryParse(Console.ReadLine(), out code);

            switch (code)
            {
                case 1:
                    Console.WriteLine("Barkodun adını giriniz: ");
                    barcodeName = Console.ReadLine();

                    Console.WriteLine("Barkodun içeriğini giriniz: ");
                    barcodeContent = Console.ReadLine();

                    BarcodeWriter.CreateBarcode(barcodeContent, BarcodeWriterEncoding.QRCode).SaveAsJpeg($"{path}\\{barcodeName}.jpg");

                    Console.WriteLine("Barkod başarıyla oluşturuldu.");

                    Process.Start("mspaint.exe", $"{path}\\{barcodeName}.jpg");
                    goto APoint;
                case 2:
                    Console.WriteLine("Barkodun adını giriniz: ");
                    barcodeName = Console.ReadLine();

                    BarcodeResult barcodeResult = BarcodeReader.QuicklyReadOneBarcode($"{path}\\{barcodeName}.jpg");

                    if (barcodeResult != null)
                    {
                        Process.Start("mspaint.exe", $"{path}\\{barcodeName}.jpg");
                        Console.WriteLine($"Barkodun içeriği: {barcodeResult.Text}");
                        goto APoint;
                    }
                    else
                    {
                        Console.WriteLine("Barkod bulunamadı!");
                        goto APoint;
                    }
                default:
                    Console.WriteLine("Geçersiz giriş!");
                    goto APoint;
            }
        }
    }
}

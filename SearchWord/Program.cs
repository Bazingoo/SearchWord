using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchWord
{
    class Program
    {
        static void NewFil(string fileName, string str)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string dir = "Teka";
            string path = Path.Combine(currentDir, dir);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string filePath = Path.Combine(path, fileName);

            using (FileStream fs = File.Create(filePath))
            {
                var bytes = Encoding.UTF8.GetBytes(str);
                fs.Write(bytes);
            }
        }
        static void Main(string[] args)
        {

            //NewFil("Text1.txt", "Креативна людина мотивується бажанням створювати, а не бажанням „перемагати інших”.");
            //NewFil("Text2.txt", "У кожної людини є право і влада вибирати. Але ні в кого немає права уникнути необхідності вибору.");
            //NewFil("Text3.txt", "Раціональність — це визнання того, що немає нічого важливішого за правду.");
            //NewFil("Test4.html", "Людина не запрограмована на несвідоме виживання.");

            //Модифікував файли руками, щоб було більше тексту

            var currentDir = Directory.GetCurrentDirectory();
            string dir = "Teka";
            string path = Path.Combine(currentDir, dir);

            foreach (var txtFiles in Directory.EnumerateFiles(path, "*.txt"))
            {
                Console.WriteLine(txtFiles);
                string[] lines = System.IO.File.ReadAllLines(txtFiles);
                int i = 0;
                string searchword = "не";
                foreach (string line in lines)
                {
                    string[] var = lines[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                    i += 1;
                    foreach (string word in var)
                        if (searchword.Equals(word))
                        {
                            Console.WriteLine($"У цьому файлі є збіг. Номер рядка: {i}");
                            break;
                        }
                }
            }
        }

     
    }
}

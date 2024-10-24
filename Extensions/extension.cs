using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyFile.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// создаем файл, записывает содержимое
        /// </summary>
        /// <param name="nameFile"></param>
        /// <param name="Content">Массив данных в видео текста</param>
        public static void WriteFile(this string nameFile, string? sContent =null, byte[]? bContent= null)
        {
            if (sContent != null)
            {
                using (FileStream fileStream = new FileStream(nameFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] updatedContent = System.Text.Encoding.UTF8.GetBytes(sContent);
                    fileStream.Write(updatedContent, 0, updatedContent.Length);
                }
            }
            else if (bContent != null)
            {
                using (FileStream fileStream = new FileStream(nameFile, FileMode.Create, FileAccess.Write))
                {
                    fileStream.Write(bContent, 0, bContent.Length);
                }
            }
            
        }
        /// <summary>
        /// читаем файл полностью,возращает строку
        /// </summary>
        /// <param name="nameFile"></param>
        /// <param name="Content">Массив данных в видео текста</param>
        public static string? ReadFile(this string filePath)
        {
            try
            {
                byte[] content;
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    content = new byte[fileStream.Length];
                    fileStream.Read(content, 0, content.Length);
                }
                return System.Text.Encoding.UTF8.GetString(content);
            }
            catch (Exception ex)
            {

                return null;
            }
            

        }

    }
}

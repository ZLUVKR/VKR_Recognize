using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Recognize.BL
{
    /// <summary>
    /// Логика общая
    /// </summary>
    internal class GeneralBL
    {
        public string GetMD5Hash(string text)
        {
            return Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(text)));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace User_login_GUI
{
    class GenerateHash
    {
        public GenerateHash()
        {

        }

        public byte[] GenerateHashValue(byte[] passwdByte,  byte[] saltByte)
        {      
            byte[] res;
            using (HMACSHA256 hamacs = new HMACSHA256())
            {
                hamacs.Key = saltByte;
                res = hamacs.ComputeHash(passwdByte);
            }       
            return res;
        }

        public byte[] GenerateSaltValue(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] result = new byte[size];
            rng.GetBytes(result);
            return result;
        }

        public bool CompareHashValues(byte[] value1, byte[] value2)
        {

            if (value1.Length == value2.Length)
            {
                int i = 0;
                while ((i < value1.Length) && (value1[i] == value2[i]))
                {
                    i++;
                }
                if (i == value1.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        
    }
}


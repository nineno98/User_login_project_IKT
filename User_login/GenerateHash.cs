using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace User_login
{
    class GenerateHash
    {
        public GenerateHash()
        {

        }

        public byte[] GenerateHashValue(byte[] passwdByte,  byte[] saltByte)
        {
            //byte[] passwdByte = Encoding.UTF8.GetBytes(passwd);
            //byte[] saltByte = Encoding.UTF8.GetBytes(salt);
            

            HashAlgorithm hashAlgorithm = new SHA256Managed();
            byte[] result = new byte[passwdByte.Length + saltByte.Length];
            for (int i = 0; i < passwdByte.Length; i++)
            {
                result[i] = passwdByte[i];
            }
            for (int i = 0; i < saltByte.Length; i++)
            {
                result[passwdByte.Length + i] = saltByte[i];
            }
            //return (Convert.ToBase64String(hashAlgorithm.ComputeHash(result)), Convert.ToBase64String(saltByte));
            return hashAlgorithm.ComputeHash(result);
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


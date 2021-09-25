using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using encryptDecrypt.Model;
using System.IO;

namespace encryptDecrypt.BLL
{
    class CryptoLab_BLL
    {
        private const string mysecurityKey = "aPdRgUkX";

        public string EncryptText(CryptoLab cryptoLab)
        {
            try
            {
                if (cryptoLab.method == "TripleDES")
                {
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    TripleDESCryptoServiceProvider tDCP = new TripleDESCryptoServiceProvider();

                    byte[] myEncryptArray = utf8.GetBytes(cryptoLab.encryptText);

                    byte[] myEncryptKay = md5.ComputeHash(utf8.GetBytes(mysecurityKey));

                    tDCP.Key = myEncryptKay;
                    tDCP.Mode = CipherMode.ECB;
                    tDCP.Padding = PaddingMode.PKCS7;

                    var MyCrytpoTransform = tDCP.CreateEncryptor();

                    byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(myEncryptArray, 0, myEncryptArray.Length);

                    return Convert.ToBase64String(MyresultArray, 0, MyresultArray.Length);

                }
                else if (cryptoLab.method == "DES")
                {
                    //UTF8Encoding utf8 = new UTF8Encoding();
                    DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();

                    byte[] myEncryptArray = Encoding.UTF8.GetBytes(cryptoLab.encryptText);

                    byte[] myEncryptKay = Encoding.UTF8.GetBytes(mysecurityKey);

                    byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };

                    MemoryStream mst = new MemoryStream();

                    CryptoStream cst = new CryptoStream(mst, DESCSP.CreateEncryptor(myEncryptKay, IV), CryptoStreamMode.Write);

                    cst.Write(myEncryptArray, 0, myEncryptArray.Length);

                    cst.FlushFinalBlock();

                    return Convert.ToBase64String(mst.ToArray());
                }
                else
                {
                    CspParameters CSApars = new CspParameters();
                    CSApars.KeyContainerName = mysecurityKey;

                    RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(CSApars);

                    byte[] data = Encoding.UTF8.GetBytes(cryptoLab.encryptText);

                    byte[] encryptedData = RSA.Encrypt(data, false);

                    return Convert.ToBase64String(encryptedData);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DecryptText(CryptoLab cryptoLab)
        {
            try
            {
                if (cryptoLab.method == "TripleDES")
                {
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    TripleDESCryptoServiceProvider tDCP = new TripleDESCryptoServiceProvider();

                    byte[] myDecryptArray = Convert.FromBase64String(cryptoLab.decryptText);

                    byte[] myEncryptKay = md5.ComputeHash(utf8.GetBytes(mysecurityKey));

                    tDCP.Key = myEncryptKay;
                    tDCP.Mode = CipherMode.ECB;
                    tDCP.Padding = PaddingMode.PKCS7;

                    var MyCrytpoTransform = tDCP.CreateDecryptor();

                    byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(myDecryptArray, 0, myDecryptArray.Length);

                    tDCP.Clear();

                    return UTF8Encoding.UTF8.GetString(MyresultArray);

                }
                else if (cryptoLab.method == "DES")
                {
                    //UTF8Encoding utf8 = new UTF8Encoding();
                    DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();

                    byte[] myDecryptArray = new byte[cryptoLab.decryptText.Length];

                    myDecryptArray = Convert.FromBase64String(cryptoLab.decryptText);

                    byte[] myEncryptKay = Encoding.UTF8.GetBytes(mysecurityKey);

                    byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };

                    MemoryStream mst = new MemoryStream();

                    CryptoStream cst = new CryptoStream(mst, DESCSP.CreateDecryptor(myEncryptKay, IV), CryptoStreamMode.Write);

                    cst.Write(myDecryptArray, 0, myDecryptArray.Length);

                    cst.FlushFinalBlock();

                    return Encoding.UTF8.GetString(mst.ToArray());

                }
                else
                {
                    CspParameters CSApars = new CspParameters();
                    CSApars.KeyContainerName = mysecurityKey;

                    RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(CSApars);

                    byte[] data = Convert.FromBase64String(cryptoLab.decryptText);

                    byte[] decryptedData = RSA.Decrypt(data, false);

                    return Encoding.UTF8.GetString(decryptedData);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

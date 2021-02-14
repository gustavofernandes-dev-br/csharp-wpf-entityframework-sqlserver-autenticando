using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Util
{
    public enum enumCryptografia

    {
        Rijndael,
        RC2,
        DES,
        TripleDES
    }

    public class Criptografia

    {
        private const string V = "*";
        #region Variáveis e Métodos Privados
        private string _key = string.Empty;
        private enumCryptografia _cryptProvider;
        private SymmetricAlgorithm _algorithm;
        
        private void SetIV()
        {
            switch (_cryptProvider)
            {
                case enumCryptografia.Rijndael:
                    _algorithm.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9, 0x5, 0x46, 0x9c, 0xea, 0xa8, 0x4b, 0x73, 0xcc };

                    break;
                default:
                    _algorithm.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9 };
                    break;
            }
        }


        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public Criptografia()

        {
            _algorithm = new RijndaelManaged();
            _algorithm.Mode = CipherMode.CBC;
            _cryptProvider = enumCryptografia.Rijndael;

        }

        public void Cripto(enumCryptografia cryptProvider)

        {
            switch (cryptProvider)
            {
                case enumCryptografia.Rijndael:
                    _algorithm = new RijndaelManaged();
                    _cryptProvider = enumCryptografia.Rijndael;
                    break;

                case enumCryptografia.RC2:
                    _algorithm = new RC2CryptoServiceProvider();
                    _cryptProvider = enumCryptografia.RC2;
                    break;

                case enumCryptografia.DES:
                    _algorithm = new DESCryptoServiceProvider();
                    _cryptProvider = enumCryptografia.DES;
                    break;

                case enumCryptografia.TripleDES:
                    _algorithm = new TripleDESCryptoServiceProvider();
                    _cryptProvider = enumCryptografia.TripleDES;
                    break;

            }

            _algorithm.Mode = CipherMode.CBC;

        }

        public byte[] GetKey()
        {
            string salt = string.Empty;
            if (_algorithm.LegalKeySizes.Length > 0)

            {
                int keySize = _key.Length * 8;
                int minSize = _algorithm.LegalKeySizes[0].MinSize;
                int maxSize = _algorithm.LegalKeySizes[0].MaxSize;
                int skipSize = _algorithm.LegalKeySizes[0].SkipSize;
                if (keySize > maxSize)

                {

                    // Busca o valor máximo da chave

                    _key = _key.Substring(0, maxSize / 8);

                }

                else if (keySize < maxSize)

                {

                    // Seta um tamanho válido

                    int validSize = (keySize <= minSize) ? minSize : (keySize - keySize % skipSize) + skipSize;

                    if (keySize < validSize)

                    {

                        // Preenche a chave com arterisco para corrigir o tamanho

                        _key = _key.PadRight(validSize / 8, '*');

                    }

                }

            }

            PasswordDeriveBytes key = new PasswordDeriveBytes(_key, ASCIIEncoding.ASCII.GetBytes(salt));

            return key.GetBytes(_key.Length);

        }

        /// <summary>

        /// Encripta o dado solicitado.

        /// </summary>

        /// <param name="plainText">Texto a ser criptografado.</param>

        /// <returns>Texto criptografado.</returns>

        public string Encrypt(string texto)

        {
            Cripto(enumCryptografia.DES);
            Key = "Criptografia";

            byte[] plainByte = Encoding.UTF8.GetBytes(texto);

            byte[] keyByte = GetKey();

            // Seta a chave privada

            _algorithm.Key = keyByte;

            SetIV();

            // Interface de criptografia / Cria objeto de criptografia

            ICryptoTransform cryptoTransform = _algorithm.CreateEncryptor();

            MemoryStream _memoryStream = new MemoryStream();

            CryptoStream _cryptoStream = new CryptoStream(_memoryStream, cryptoTransform, CryptoStreamMode.Write);

            // Grava os dados criptografados no MemoryStream

            _cryptoStream.Write(plainByte, 0, plainByte.Length);

            _cryptoStream.FlushFinalBlock();

            // Busca o tamanho dos bytes encriptados

            byte[] cryptoByte = _memoryStream.ToArray();

            // Converte para a base 64 string para uso posterior em um xml

            return Convert.ToBase64String(cryptoByte, 0, cryptoByte.GetLength(0));

        }


        public virtual string Decrypt(string textoCriptografado)

        {
            Cripto(enumCryptografia.DES);
            Key = "Criptografia";

            byte[] cryptoByte = Convert.FromBase64String(textoCriptografado);

            byte[] keyByte = GetKey();
            // Seta a chave privada
            _algorithm.Key = keyByte;

            SetIV();

            ICryptoTransform cryptoTransform = _algorithm.CreateDecryptor();

            try

            {
                MemoryStream _memoryStream = new MemoryStream(cryptoByte, 0, cryptoByte.Length);
                CryptoStream _cryptoStream = new CryptoStream(_memoryStream, cryptoTransform, CryptoStreamMode.Read);
                StreamReader _streamReader = new StreamReader(_cryptoStream);

                return _streamReader.ReadToEnd();

            }

            catch

            {

                return null;

            }

        }

        #endregion

    }
}

using System.Security.Cryptography;

namespace  PasswordGenerator{





    public class Random{


        public int Next(int n){

            RNGCryptoServiceProvider provider  =new RNGCryptoServiceProvider();
            var ByteArray = new byteArray();
            provider.GetBytes(ByteArray);


            var randomInteger =BitConverter.ToInt32(ByteArray,0);
            return (int)(randonInteger % n );
        }
    }
}




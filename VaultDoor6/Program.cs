using System;
using System.Text;


namespace VaultDoor6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] myBytes = {
            0x3b, 0x65, 0x21, 0xa , 0x38, 0x0 , 0x36, 0x1d,
            0xa , 0x3d, 0x61, 0x27, 0x11, 0x66, 0x27, 0xa ,
            0x21, 0x1d, 0x61, 0x3b, 0xa , 0x2d, 0x65, 0x27,
            0xa , 0x34, 0x30, 0x31, 0x30, 0x36, 0x30, 0x31,
            };
            byte[] reponse = new byte[32];

            for (int i = 0; i < 32; i++)
            {
                reponse[i] = myBytes[i];
                reponse[i] ^= 0x55;
            }
            string r = Encoding.UTF8.GetString(reponse,0,reponse.Length);
            string s = "picoCTF{";
            string e = "}";
            Console.WriteLine("La clef est : {0}{1}{2}", s, r, e);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;

        }
    }
}

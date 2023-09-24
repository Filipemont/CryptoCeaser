using CryptoCeaser.Entities;
using CryptoCeaser.Entities.exception;

namespace CryptoCeaser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string word = Console.ReadLine();
                Crypto crypto = new Crypto(word);
                word = crypto.Encrypt(word);
                Console.WriteLine(word);
                word = crypto.Decrypt(word);
                Console.WriteLine(word);
            }
            catch(DomainException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e){
                Console.WriteLine("Unknowm error"+ e.Message);
            }
        }
    }
}
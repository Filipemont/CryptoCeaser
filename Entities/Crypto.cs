using CryptoCeaser.Entities.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCeaser.Entities
{
    internal class Crypto
    {
        public string World { get; set; }

        public Crypto(string world)
        {
            World = world;
        }
        public string Encrypt(string key)
        {
            int[] letters = new int[key.Length];
            char[] chars = new char[key.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                int ascII = key[i];
                if (ascII > 122 || (ascII<97 && ascII != 32))
                {
                    throw new DomainException("This sentence doesn't just have words!");
                }
                if (ascII == 122)
                {
                    ascII = 96;
                }
                if (ascII == 121)
                {
                    ascII = 95;
                }
                if (ascII == 120)
                {
                    ascII = 94;
                }
                if (ascII == 32)
                {
                    ascII = 29;
                }
                letters[i] = ascII + 3;
                chars[i] = (char)letters[i];
            }
            string[] result = chars.Select(i => i.ToString()).ToArray();
            key = String.Join("", result);
            return key;
        }
        public string Decrypt(string key)
        {
            int[] letters = new int[key.Length];
            char[] chars = new char[key.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                int ascII = key[i];
                if (ascII == 97)
                {
                    ascII = 123;
                }
                if (ascII == 98)
                {
                    ascII = 124;
                }
                if (ascII == 99)
                {
                    ascII = 125;
                }
                if( ascII == 32)
                {
                    ascII = 35;
                }
                letters[i] = ascII - 3;
                chars[i] = (char)letters[i];
            }
            string[] result = chars.Select(i => i.ToString()).ToArray();
            key = String.Join("", result);
            return key;
        }
    }
}

using System;
using System.Globalization;

namespace redis
{
    class Program
    {
        static void Main(string[] args)
        {
            var redisDB = RedisDB.Conecction.GetDatabase();

            redisDB.StringSet("1", CultureInfo.CurrentCulture.TextInfo.ToTitleCase("asd"));
            redisDB.StringSet("2", CultureInfo.CurrentCulture.TextInfo.ToTitleCase("aguita"));
            redisDB.StringSet("3", CultureInfo.CurrentCulture.TextInfo.ToTitleCase("jugo"));

            redisDB.KeyDelete("1");
            redisDB.KeyDelete("2");
            redisDB.KeyDelete("3");

            var valor = redisDB.StringGet("1");
            var valor2 = redisDB.StringGet("2");
            var valor3 = redisDB.StringGet("3");

            Console.WriteLine("{0} {1} {2}", valor, valor2, valor3);
        }
    }
}

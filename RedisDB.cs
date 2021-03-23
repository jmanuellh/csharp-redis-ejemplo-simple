using System;
using StackExchange.Redis;

public class RedisDB
{
    private static Lazy<ConnectionMultiplexer> _lazyConnection;

    public static ConnectionMultiplexer Conecction
    {
        get
        {
            return _lazyConnection.Value;
        }
    }

    static RedisDB()
    {
        _lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            ConnectionMultiplexer.Connect("localhost")
        );
    }
}

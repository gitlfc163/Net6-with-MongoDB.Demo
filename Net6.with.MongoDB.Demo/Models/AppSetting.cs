namespace Net6.with.MongoDB.Demo.Models;


/// <summary>
/// mongodb setting
/// </summary>
public interface IAppSetting
{
    /// <summary>
    /// SqlServerSetting
    /// </summary>
     SqlServerSetting SqlServerSetting { get; set; }
    /// <summary>
    /// MysqlSetting
    /// </summary>
     MysqlSetting MysqlSetting { get; set; }
    /// <summary>
    /// RedisSetting
    /// </summary>
     RedisSetting RedisSetting { get; set; }
    /// <summary>
    /// RabbitMQSetting
    /// </summary>
     RabbitMQSetting RabbitMQSetting { get; set; }

    /// <summary>
    /// MongoDbSetting
    /// </summary>
     MongoDbSetting MongoDbSetting { get; set; }
    /// <summary>
    /// KafkaSetting
    /// </summary>
     KafkaSetting KafkaSetting { get; set; }
}

/// <summary>
/// mongodb setting
/// </summary>
public class AppSetting: IAppSetting
{
    /// <summary>
    /// SqlServerSetting
    /// </summary>
    public SqlServerSetting SqlServerSetting { get; set; }
    /// <summary>
    /// MysqlSetting
    /// </summary>
    public MysqlSetting MysqlSetting { get; set; }
    /// <summary>
    /// RedisSetting
    /// </summary>
    public RedisSetting RedisSetting { get; set; }
    /// <summary>
    /// RabbitMQSetting
    /// </summary>
    public RabbitMQSetting RabbitMQSetting { get; set; }

    /// <summary>
    /// MongoDbSetting
    /// </summary>
    public MongoDbSetting MongoDbSetting { get; set; }
    /// <summary>
    /// KafkaSetting
    /// </summary>
    public KafkaSetting KafkaSetting { get; set; }
}
public class RabbitMQSetting
{
    /// <summary>
    /// HostName
    /// </summary>
    public string HostName { get; set; } = "localhost";

    /// <summary>
    /// Password
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// The port to connect on.
    /// </summary>
    public int Port { get; set; } = 5672;
}
public class RedisSetting
{
    /// <summary>
    /// connection string
    /// </summary>
    public string Connection { get; set; }
    /// <summary>
    /// database name
    /// </summary>
    public string Database { get; set; }
}
public class MongoDbSetting
{
    /// <summary>
    /// connection string
    /// </summary>
    public string Connection { get; set; }
    /// <summary>
    /// database name
    /// </summary>
    public string Database { get; set; }
    /// <summary>
    /// CollectionName
    /// </summary>

    public string CollectionName { get; set; }
}
public class SqlServerSetting
{
    /// <summary>
    /// connection string
    /// </summary>
    public string Connection { get; set; }
}
public class MysqlSetting
{
    /// <summary>
    /// connection string
    /// </summary>
    public string Connection { get; set; }
}
public class KafkaSetting
{
    /// <summary>
    /// Servers
    /// </summary>
    public string Servers { get; set; }
}
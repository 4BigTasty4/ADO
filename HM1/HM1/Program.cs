
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

if (false)
{
    var builder = new ConfigurationBuilder();

    builder.AddJsonFile("Settings.json");

    var config = builder.Build();

    var connection = config.GetConnectionString("Default");

    using SqlConnection conn = new SqlConnection(connection);
    conn.Open();

    SqlCommand command = new("select count (*) from People", conn);

    int commandCount = (int)command.ExecuteScalar();

    Console.WriteLine(commandCount);

    command = new("select avg(Age) from People", conn);

    int commandAvg = (int)command.ExecuteScalar();

    Console.WriteLine(commandAvg);

    command = new("select sum(Age) from People",conn);

    int commandSum = (int)command.ExecuteScalar();

    Console.WriteLine(commandSum);
}

if (true)
{
    var bulder = new ConfigurationBuilder();

    bulder.AddJsonFile("Settings.json");

    var config = bulder.Build();

    var connection = config.GetConnectionString("Default");

    using SqlConnection conn = new SqlConnection(connection);
    conn.Open();

    string insertCommand = "insert into People(Name, Surname, Age) values (N'Elvin', N'Azimov', 22)";
    
    SqlCommand command = new(insertCommand, conn);

    int commandInsert = command.ExecuteNonQuery();
    Console.WriteLine("Добавлено объектов: " + commandInsert);

    string updateCommand = "update People set Age = 23 where Name = 'Elvin'";

    command = new (updateCommand, conn);

    int commandUpdate = command.ExecuteNonQuery();
    Console.WriteLine("Updated objects: " + commandUpdate);

    string deleteCommand = "delete from People where Name = 'Elvin'";

    command = new(deleteCommand, conn);

    int commandDelete = command.ExecuteNonQuery();
    Console.WriteLine("Objects deleted: " + commandDelete);

}
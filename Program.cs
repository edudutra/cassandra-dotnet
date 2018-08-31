using System;
using Cassandra;

namespace cassandra_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var cluster = Cluster.Builder()
                     .AddContactPoints("aws.overbug.com.br")
                     .Build();
            // Connect to the nodes using a keyspace
            var session = cluster.Connect("test");
            // Execute a query on a connection synchronously
            var rs = session.Execute("SELECT * FROM emp;");
            // Iterate through the RowSet
            foreach (var row in rs)
            {
            var value = row.GetValue<int>("sample_int_column");
            // Do something with the value
            }

            Console.WriteLine("Hello World!");
        }
    }
}

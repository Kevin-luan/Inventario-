using System;
using MySqlConnector;

internal class Conexao
{
    // String de conexão para o MariaDB
    private static string stringConexao = 
        "Server=192.168.0.107;" +
        "Database=Inventario;" +
        "User ID=kevin;" +
        "Password=KevinLuan;Port=3306;" +
        "SslMode=none;";

    // Método para obter a conexão
    public static MySqlConnection GetConnection()
    {
        // Cria a conexão usando a string de conexão
        return new MySqlConnection(stringConexao);
    }
}

using Projetinho;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Conexao
    {

            MySqlConnection conexao;

        Conexao new MySqlConnection("server=localhost;database=projetinho;uid=root;");
            try
            {​​​​​​
                Conexao.Open();
            }​​​​​​
           
    {
    }

    Exception s()
            {​​​​​​
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }​​​​​​
            Console.WriteLine("Digite um usuario para cadastrar:");
            string usuario = Console.ReadLine();
Console.WriteLine("Digite uma senha para cadastrar");
            string senha = Console.ReadLine();

            string sql = "insert into usuarios values (null,@usuario,@senha)";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.ExecuteNonQuery();

            string sqlselect = "select * from usuarios where id > @valor";
            cmd.Parameters.AddWithValue("@valor", 10);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();


            while (resultado.Read())
            {​​​​​​
                Console.WriteLine("id:" + resultado["id"]);
                Console.WriteLine("usuario:" + resultado["usuario"]);
                Console.WriteLine("senha:" + resultado["senha"]);
            }​​​​​​



           Conexao.Close();




    }
}

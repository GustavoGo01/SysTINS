using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    //Classe banco é a nossa Classe de conexão
    public static class Banco //static pois não precisaremos criar uma instancia de Banco para conectar às nossas base de dados
    { //classe que tem uma coleção de métodos para executar no Banco de dados

        public static MySqlCommand Abrir() //método para abrir conexão
        {
            string strcon = @"server=127.0.0.1;database=systinsdb01;user=root;password=";
            MySqlConnection cn = new(strcon);
            MySqlCommand cmd = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex) // catch mostra o erro 
            {
                Console.WriteLine(ex.Message);
             
            }

            return cmd;

        }


    }

}
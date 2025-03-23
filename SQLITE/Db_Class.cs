using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQLITE
{
    class Db_Class
    {
        private static SQLiteConnection conection;

        private static SQLiteConnection DbConnection()
        {
            if (!System.IO.Directory.Exists(Globais.dbPath))
            {
                System.IO.Directory.CreateDirectory(Globais.dbPath);
            }
            conection = new SQLiteConnection("Data Source =" + Globais.dbPath + Globais.db);
            conection.Open();
            return conection;
        }

        private static DataTable ObtAllUser()
        {
            SQLiteDataAdapter adapitar = null;
            DataTable dt = new DataTable();

            try{

                var vcom = DbConnection();
                var comando = DbConnection().CreateCommand();
                comando.CommandText = "SELECT * FROM db_user";
                adapitar = new SQLiteDataAdapter(comando.CommandText, vcom);
                adapitar.Fill(dt);
                vcom.Close();
                return dt;

            }catch (Exception ex) {
                throw ex;
            }
        }

        public static DataTable obtUser(string sql)
        {
            SQLiteDataAdapter adar = null;
            DataTable dt = new DataTable();

            try
            {
                var vcom = DbConnection();
                var cmd = vcom.CreateCommand();
                cmd.CommandText = sql;
                adar = new SQLiteDataAdapter(cmd.CommandText, vcom);
                adar.Fill(dt);
                vcom.Close();
                return dt;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        //funções do form cadastro inicio

        public static void novoUsuario(Usuario NewUser)
        {
            if (existUser(NewUser))
            {
                MessageBox.Show("User already exists");

            }
            else
            {
                try
                {
                    var vcom = DbConnection();
                    var cmd = vcom.CreateCommand();
                    cmd.CommandText = "INSERT INTO db_user (S_NAMEUSER, S_PASSWORD, S_USERNAME, I_NIVELUSER, S_STATUSUSER) VALUES ('" + NewUser.name + "', '" + NewUser.password + "', '" + NewUser.userName + "', " + NewUser.nivel + ", '" + NewUser.status + "')";
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("User successfully registered");
                     vcom.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User Fail registered");
                    throw ex;
                }

            }

        }

        public static bool existUser(Usuario VerUser)
        {
            bool rest = false;
            SQLiteDataAdapter adar = null;
            DataTable dt = new DataTable();
             
            var cmd = DbConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM db_user WHERE S_USERNAME='" + VerUser.userName + "'";
            adar = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
            rest = adar.Fill(dt) > 0;

            return rest;
        }

        //fim

        //fucão para ver os usuario 
        public static DataTable verUsuario()
        {
            SQLiteDataAdapter adar = null;
            DataTable dt = new DataTable();

            var vcom = DbConnection();
            var cmd = vcom.CreateCommand();
            cmd.CommandText = "SELECT I_ID as 'ID', S_USERNAME as 'USER' FROM db_user";

            adar = new SQLiteDataAdapter(cmd.CommandText, vcom);
            adar.Fill(dt);
            return dt;
        }

        public static DataTable verSelecao(string id)
        {
            SQLiteDataAdapter adar = null;
            DataTable dt = new DataTable();

            var vcom = DbConnection();
            var cmd = vcom.CreateCommand();
            cmd.CommandText = "SELECT * FROM db_user WHERE I_ID=" + id;

            adar = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
            adar.Fill(dt);
            return dt;
        }

        public static void UpdateUser(Usuario User)
        {

            try
            {
                var vcom = DbConnection();
                var cmd = vcom.CreateCommand();

                cmd.CommandText = "UPDATE db_user SET S_NAMEUSER = @name, S_PASSWORD = @pass, S_USERNAME = @user, S_STATUSUSER = @status, I_NIVELUSER = @nivel WHERE I_ID = @id";

                cmd.Parameters.AddWithValue("@name", User.name);
                cmd.Parameters.AddWithValue("@pass", User.password);
                cmd.Parameters.AddWithValue("@user", User.userName);
                cmd.Parameters.AddWithValue("@status", User.status);
                cmd.Parameters.AddWithValue("@nivel", User.nivel);
                cmd.Parameters.AddWithValue("@id", User.id);
            
                cmd.ExecuteNonQuery();
                vcom.Close();

                MessageBox.Show("User successfully updated");

            }
            catch(Exception ex)
            {
                MessageBox.Show("User Faill updated");
                throw ex;
            }
        }

        public static void DeleteUser(Usuario user)
        {
            try
            {
                var vcom = DbConnection();
                var cmd = vcom.CreateCommand();

                cmd.CommandText = "DELETE FROM db_user WHERE I_ID = @id ";

                cmd.Parameters.AddWithValue("@id", user.id);

                cmd.ExecuteNonQuery();
                vcom.Close();

                MessageBox.Show("User successfully deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Fail deleted");
                throw ex;
            }
        }

        //fim
    }

}

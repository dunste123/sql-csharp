using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace SQL_CONN_5_oct_2017 {
    public partial class Form1 : Form {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string rowId;

        public Form1() {
            InitializeComponent();
        }

        //Initialize values
        private void Initialize() {
            server = "localhost";
            database = "sharp";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Select statement
        public List<string>[] GetText() {
            string query = "SELECT * FROM test";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true) {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read()) {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["text"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            } else {
                return list;
            }
        }

        //Update statement
        public void UpdateData(String row, String newText) {
            string query = "UPDATE test SET text=@inputText WHERE id=@id";

            //Open connection
            if (this.OpenConnection() == true) {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Set the variables here for more security
                cmd.Parameters.AddWithValue("@inputText", newText);
                cmd.Parameters.AddWithValue("@id", row);
                //Assign the connection using Connection
                cmd.Connection = connection;
                
                //Prepare the statement
                cmd.Prepare();

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                MessageBox.Show("Saved", "Information");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Initialize();
            txbCurrTextDSte.Text = this.GetText()[1][0];
            this.rowId = this.GetText()[0][0];
        }

        private void btnSaveTextDSte_Click(object sender, EventArgs e) {
            //Save text
            this.UpdateData(this.rowId, txbCurrTextDSte.Text);
        }
    }
}

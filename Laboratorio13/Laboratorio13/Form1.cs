using System.Data;
using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=basededatos;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectarSQL_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

            SqlCommand comando = new SqlCommand("SELECT ProductName FROM Products", conexion);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["ProductName"].ToString());
            }

            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }
    }
}

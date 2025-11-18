using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace Laboratorio203
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public bool Nuevo
        {
            get
            {
                // Intenta obtener el valor de ViewState. Si es nulo, devuelve false.
                return ViewState["IsNewProduct"] != null ? (bool)ViewState["IsNewProduct"] : false;
            }
            set
            {
                // Almacena el nuevo valor en ViewState
                ViewState["IsNewProduct"] = value;
            }
        }
        string connectionString = @"Server=localhost;Database=productos;Trusted_Connection=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        protected void tsbNuevo_Click(object sender, ImageClickEventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            Nuevo = true;
        }

        protected void tsbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            if (Nuevo)
            {
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK)"
                             + "VALUES ('" + txtNombre.Text + "', '" + txtPrecio.Text + "', '" + txtStock.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "GuardarExitoso", "window.alert('Registro ingresado correctamente !');", true);
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "GuardarError", $"window.alert('Error: El registro no se guardo.');", true);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE LAPTOPS SET NOMBRE = '" + txtNombre.Text +
                    "', PRECIO = '" + txtPrecio.Text +
                    "', STOCK = '" + txtStock.Text + "' WHERE ID = " + txtId.Text;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "UpdateExitoso", "window.alert('Registro actualizado correctamente !');", true);
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "UpdateError", $"window.alert('Error: El registro no se actualizo');", true);
                }
                finally
                {
                    con.Close();
                }
            }
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            Nuevo = false;
        }

        protected void tsbCancelar_Click(object sender, ImageClickEventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void tsbEliminar_Click(object sender, ImageClickEventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE ID='" + this.txtId.Text + "';";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "EliminarExitoso", "window.alert('Registro eliminado correctamente !');", true);
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "EliminarError", $"window.alert('Error: El registro no fue eliminado');", true);
            }
            finally
            {
                con.Close();
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void tsbBuscar_Click(object sender, ImageClickEventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID =" + tstId.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    tstId.Enabled = false;
                    tsbBuscar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    txtNombre.Focus();
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtPrecio.Text = reader[2].ToString();
                    txtStock.Text = reader[3].ToString();
                    Nuevo = false;
                }
                else
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "ErrorBuscarId", $"window.alert('Ningun registro encontrado con el Id: {tstId.Text} ingresado !')", true);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "ExepcionBuscarId", $"window.alert('Error: al buscar registro.')", true);
            }
            finally
            {
                con.Close();
            }

            tstId.Text = "";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "closeWindow", "window.close(); window.alert('Presiono el botón de salir');", true);
            
        }
    }
}
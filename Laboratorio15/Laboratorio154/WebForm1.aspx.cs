using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(txbNumero1.Text);
                double numero2 = Convert.ToDouble(txbNumero2.Text);

                double suma = numero1 + numero2;

                lblResultado.Text = "El resultado de la suma es: " + suma.ToString();
            }
            catch (FormatException)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "window.alert('Por favor, ingrese números válidos.');", true);
            }
            catch (OverflowException)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "window.alert('Los números ingresados son demasiado grandes o pequeños.');", true);
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "window.alert('Ocurrió un error inesperado.');", true);
            }

        }
    }
}
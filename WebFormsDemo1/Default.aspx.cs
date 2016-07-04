using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Label2.Text = "Hello, " + TextBox1.Text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Check1.Checked)
        {
            Label4.Text = "The box is checked";
        }
        else {
            Label4.Text = "The box isn't checked.";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue != "")
        {
            Label6.Text = "You selected " + RadioButtonList1.SelectedValue + ".";
        }
        else
        {
            Label6.Text = "You haven't selected an option.";
        }

    }

    protected void DropDownbutton_Click(object sender, EventArgs e)
    {
        DropDownListLabel.Text = "You selected " + DropDownList1.SelectedValue;
    }



    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        ResponsiveRadioLabel.Text = "You created a response without a button";
    }



    protected void checkChar_Click(object sender, EventArgs e)
    {
        Label7.Text = "There are " + charCheckTextBox.Text.Length + " characters in this sentence";
    }




    protected void Button5_Click(object sender, EventArgs e)
    {
        Label9.Text = Calendar1.SelectedDate.ToLongDateString();
    }
}

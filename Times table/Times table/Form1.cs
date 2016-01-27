using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Times_table
{
    public partial class frm_timesTable : Form
    {
        //Global Variables
        int startingnum = 0;
        int endingnum = 0;
        double mult = 0;
        int operation = 0;
        //1 = multiply
        //2 = divide
        //3 = add
        //4 = subtract
        double answer = 0;
        string sign = "X";
        double max = 0;
        public frm_timesTable()
        {
            InitializeComponent();
        }

        private void Btn_Operation_Click(object sender, EventArgs e)
        {
                //get info from textboxes
                mult = Convert.ToDouble(txt_mult.Text);
                startingnum = Convert.ToInt32(txt_Start.Text);
                endingnum = Convert.ToInt32(txt_End.Text);
                //sets up operation (multiply) for runner method
                operation = 1;
                max = endingnum / mult;
                Runner();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
                //get info from textboxes
                mult = Convert.ToDouble(txt_mult.Text);
                startingnum = Convert.ToInt32(txt_Start.Text);
                endingnum = Convert.ToInt32(txt_End.Text);
                //sets up operation (add) for runner method
                operation = 3;
                max = endingnum - mult;
                Runner();
        }
        private void Runner()
        {
                        //Try-Catch statement to stop idiots
            try
            {
                //for statement, makes magic happen
                for (int i = startingnum; i <= max; i++)
                {
                    if (operation == 1)
                    {
                        answer = i * mult;
                        sign = " * ";
                    }
                    else if (operation == 2)
                    {
                        answer = i / mult;
                        sign = " / ";
                    }
                    else if (operation == 3)
                    {
                        answer = i + mult;
                        sign = " + ";
                    }
                    else if (operation == 4)
                    {
                        answer = i - mult;
                        sign = " - ";
                    }
                    //updates list
                    lst_output.Items.Add(" " + i.ToString() + sign + mult.ToString() + " = " + (answer));
                    //scrolls down
                    lst_output.SelectedIndex = lst_output.Items.Count - 1;
                    //pauses for dramatic affect
                    //System.Threading.Thread.Sleep(200);
                }
            }
            catch
            {
                //idiot catcher
                MessageBox.Show("No Possible answers were entered", "You Must Be An Idiot");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
                //get info from textboxes
                mult = Convert.ToDouble(txt_mult.Text);
                startingnum = Convert.ToInt32(txt_Start.Text);
                endingnum = Convert.ToInt32(txt_End.Text);
                //sets up operation (Subtract) for runner method
                operation = 4;
                max = endingnum + mult;
                Runner();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
                 //get info from textboxes
                mult = Convert.ToDouble(txt_mult.Text);
                startingnum = Convert.ToInt32(txt_Start.Text);
                endingnum = Convert.ToInt32(txt_End.Text);
                //sets up operation (Divide) for runner method
                operation = 2;
                max = mult * endingnum;
                Runner();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            //cleans out textbox
            lst_output.Items.Clear();
        }
    }

}

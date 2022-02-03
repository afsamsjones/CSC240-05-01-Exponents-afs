using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:
 * Date:
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class UxDemoForm : Form
    {
        public UxDemoForm()
        {
            InitializeComponent();
        }

        private void UxGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE

            int num;

            // INPUT

            num = Convert.ToInt32(UxInputTextBox.Text);
            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */

            UxOutputLabel.Text = String.Format("The square is {0}", num * num);
            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            UxOutputLabel.Text += String.Format("\nThe cube is {0}", num * num * num);

            // OUTPUT
            // set the output to visible
            UxOutputLabel.Visible = true;
            // turn the Go button off
        }

        public int Square(int num)
        {
            // we will create this code in class
            return 1;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return 1;
        }

        private void UxResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
        }

    }
}

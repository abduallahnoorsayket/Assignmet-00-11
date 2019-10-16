using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {

        Refrigarator refrigarator; 
           // = new Refrigarator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            refrigarator = new Refrigarator( Convert.ToDouble ( maxWeightTakeTextBox.Text));
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            refrigarator.NoItem =Convert.ToInt32 (itemTextBox.Text);

            refrigarator.UnitWeight = Convert.ToDouble(weightTextBox.Text);
            

           //efrigarator.OverFlow(refrigarator.NoItem, refrigarator.UnitWeight);

              
                  refrigarator.Add(refrigarator.NoItem, refrigarator.UnitWeight);

              
              //else
              //{

              //    MessageBox.Show(" Can not be entered Overflow !!");
              //}
              

            currentWeightTextBox.Text = Convert.ToString( refrigarator.GetCurrentWeight());

            remainingWeightTextBox.Text = Convert.ToString(refrigarator.GetRemainingWeight());






            itemTextBox.Clear();
            weightTextBox.Clear();
        }




    }
}

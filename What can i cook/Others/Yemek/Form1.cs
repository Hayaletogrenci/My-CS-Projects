using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek
{
    public partial class Wmdyh : Form
    {
        public Wmdyh()
        {
            InitializeComponent();
        }

        private void Rice_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool anyIngredientSelected = Rice.Checked || Onions.Checked || Salt.Checked || OliveOil.Checked ||
                                        Pasta.Checked || Eggs.Checked || BlackPepper.Checked || Milk.Checked || Garlic.Checked ||
                                        Chicken.Checked || Flour.Checked || Potatoes.Checked || Yogurt.Checked ||
                                        CannedTomatoes.Checked || TomatoPaste.Checked || Bread.Checked;

            bool enoughIngredients = Rice.Checked && Onions.Checked && Salt.Checked && OliveOil.Checked &&
                                    Pasta.Checked && Eggs.Checked && BlackPepper.Checked && Milk.Checked && Garlic.Checked &&
                                    Chicken.Checked && Flour.Checked && Potatoes.Checked && Yogurt.Checked &&
                                    CannedTomatoes.Checked && TomatoPaste.Checked && Bread.Checked;

            if (anyIngredientSelected)
            {
                string message = "";

                if (enoughIngredients)
                {
                    if (Rice.Checked && Onions.Checked && Salt.Checked && OliveOil.Checked)
                        message += "You can cook Rice Pilaf" + Environment.NewLine;

                    if (Pasta.Checked && Eggs.Checked && Salt.Checked && BlackPepper.Checked && Milk.Checked && Garlic.Checked && OliveOil.Checked)
                        message += "You can cook Pasta Carbonara" + Environment.NewLine;

                    if (Chicken.Checked && Flour.Checked && Eggs.Checked && BlackPepper.Checked && Milk.Checked && OliveOil.Checked)
                        message += "You can cook Flour Chicken" + Environment.NewLine;

                    if (Potatoes.Checked && Yogurt.Checked && Salt.Checked && Garlic.Checked && OliveOil.Checked)
                        message += "You can cook Potatoes Salad" + Environment.NewLine;

                    if (Chicken.Checked && Onions.Checked && Garlic.Checked && TomatoPaste.Checked && Salt.Checked && BlackPepper.Checked && OliveOil.Checked)
                        message += "You can cook Chicken in sauce" + Environment.NewLine;

                    if (Eggs.Checked && Salt.Checked && Milk.Checked && BlackPepper.Checked && OliveOil.Checked)
                        message += "You can cook Omelette" + Environment.NewLine;

                    if (Potatoes.Checked && Salt.Checked && OliveOil.Checked)
                        message += "You can cook Fried Potatoes" + Environment.NewLine;

                    if (Onions.Checked && Flour.Checked && Salt.Checked && Milk.Checked && OliveOil.Checked)
                        message += "You can cook Onion soup" + Environment.NewLine;

                    if (CannedTomatoes.Checked && Rice.Checked && Onions.Checked && Salt.Checked && BlackPepper.Checked && OliveOil.Checked)
                        message += "You can cook Stuffed Tomatoes with Olive Oil" + Environment.NewLine;

                    if (Bread.Checked && Garlic.Checked && Salt.Checked && OliveOil.Checked)
                        message += "You can cook Garlic bread" + Environment.NewLine;
                }
                else
                {
                    message = "You don't have enough ingredients to cook any dish.";
                }

                MessageBox.Show(message.Trim());
            }
            else
            {
                MessageBox.Show("I guess you can't do anything");
            }
        }




    }
}

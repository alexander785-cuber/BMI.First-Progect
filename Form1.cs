using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double heightCm = double.Parse(textBox1.Text); 
            double weightKg = double.Parse(textBox2.Text); 
            string gender = textBox3.Text.ToLower();       
            int workouts = int.Parse(textBox4.Text);       

            double heightM = heightCm / 100.0;

            
            double bmi = weightKg / (heightM * heightM);
            label5.Text = "BMI: " + Math.Round(bmi, 2);


            double age = double.Parse(textBox5.Text);
            double bmr;

            if (gender == "м" || gender == "m")
            {
                bmr = 10 * weightKg + 6.25 * heightCm - 5 * age + 5;
            }

            else if (gender == "ж" || gender == "f")
            {
                bmr = 10 * weightKg + 6.25 * heightCm - 5 * age - 161;
            }
            else
            {
                label6.Text = "Невалиден пол.";
                return;
            }

            
            double multiplier = 1.2;
            if (workouts == 1) multiplier = 1.375;
            else if (workouts == 2 || workouts == 3) multiplier = 1.55;
            else if (workouts >= 4 && workouts <= 6) multiplier = 1.725;
            else if (workouts > 6) multiplier = 1.9;

            
            double calories = bmr * multiplier;
            label6.Text = "Калории за поддържане: " + Math.Round(calories);
        }
    
    
        
        }
    }


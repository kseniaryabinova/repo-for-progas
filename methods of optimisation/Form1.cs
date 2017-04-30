using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jace;
using System.Text.RegularExpressions;
using System.IO;
using methods_of_optimisation.classes;
    
namespace methods_of_optimisation
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> variables = new Dictionary<string, double>();
        Func<double[], double> f;
        Unconditional_extremum ext;

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            CalculationEngine engine = new CalculationEngine();

            if (check())
            {
                f = (double[] x) =>
                {
                    for (int i = 0; i < x.Length; i++)
                        variables["x" + (i + 1).ToString()] = x[i];
                    return engine.Calculate(equation.Text, variables);
                };

                if (radioButton1.Checked)
                {
                    ext = new Gradient_descent_method(
                        vector.Text.Split(' ').Select(Double.Parse).ToArray(),
                        f,
                        Double.Parse(eps1.Text),
                        Double.Parse(eps2.Text));
                };

                if (radioButton2.Checked)
                {
                    ext = new Fledcher_Rifs_method(
                        vector.Text.Split(' ').Select(Double.Parse).ToArray(),
                        f,
                        Double.Parse(eps1.Text),
                        Double.Parse(eps2.Text));
                }

                if (radioButton3.Checked)
                {
                    ext = new newton_method(
                        vector.Text.Split(' ').Select(Double.Parse).ToArray(),
                        f,
                        Double.Parse(eps1.Text),
                        Double.Parse(eps2.Text));
                }

                if (radioButton4.Checked)
                {
                    ext = new Newton_Ravson_method(
                        vector.Text.Split(' ').Select(Double.Parse).ToArray(),
                        f,
                        Double.Parse(eps1.Text),
                        Double.Parse(eps2.Text));
                }

                output.Text = ext.algorithm();
            }
            else
                MessageBox.Show("заполните все поля");
        }
        
        private void equation_Leave(object sender, EventArgs e)
        {
            if (!equation.Items.Contains(equation.Text) 
                && equation.Text != ""
                && equation.Text != "введите функцию")
            {
                equation.Items.Add(equation.Text);
                StreamWriter file = File.AppendText("../../equations.txt");
                file.WriteLine(equation.Text);
                file.Close();
            }
        }

        private bool check()
        {
            return equation.Text != "введите функцию" &&
                vector.Text != "введите вектор начального приближения" &&
                (radioButton1.Checked || radioButton2.Checked ||
                radioButton3.Checked || radioButton4.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            equation.Items.Clear();
            StreamReader file = new StreamReader("../../equations.txt");
            string line;
            while((line = file.ReadLine()) != null)
                equation.Items.Add(line);
            file.Close();

            vector.Items.Clear();
            file = new StreamReader("../../vectors.txt");
            while ((line = file.ReadLine()) != null)
                vector.Items.Add(line);
            file.Close();
        }

        private void vector_Leave(object sender, EventArgs e)
        {            
            if (!vector.Items.Contains(vector.Text)
                && vector.Text != ""
                && vector.Text != "введите вектор начального приближения")
            {
                vector.Items.Add(vector.Text);
                StreamWriter file = File.AppendText("../../vectors.txt");
                file.WriteLine(vector.Text);
                file.Close();
            }
        }
        
    }
}

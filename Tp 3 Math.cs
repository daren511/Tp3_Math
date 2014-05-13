using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tp3_Math
{
    
    public partial class PI : Form
    {
        private double pchapeau = 0;
        private double qchapeau = 0;
        private double sigma = 0;
        private int essaisdefaut = 1000;
        private double erreur = 0;
        private const double ZPOISSON = 2.575;
        private double pmin = 0;
        private double pmax = 0;
        private Random rand = new Random();
        public PI()
        {
            InitializeComponent();
        }

        private void calculerPi(int essais)
        {
            Coordonnees coord;
            double pi = Math.PI;
            pchapeau = 0;
            qchapeau = 0;

            for (int i = 0; i < essais; ++i)
            {
                coord = new Coordonnees(rand.NextDouble(), rand.NextDouble());

                if (Math.Sqrt(Math.Pow(coord.X, 2) + Math.Pow(coord.Y, 2)) <= 1)
                {
                    pchapeau++;
                }
                else
                {
                    qchapeau++;
                }
            }

            pchapeau = pchapeau / essais;
            qchapeau = qchapeau / essais;

            sigma = Math.Sqrt((pchapeau * qchapeau) / essais);

            erreur = ZPOISSON * sigma;

            pmin = pchapeau - erreur;
            pmax = pchapeau + erreur;
            if (essais == essaisdefaut)
            {
                LBL_PIMIN.Text = (4 * pmin).ToString();
                LBL_PIMAX.Text = (4 * pmax).ToString();
            }
            else
            {
                LBL_REPMIN.Text = (4 * pmin).ToString();
                LBL_REPMAX.Text = (4 * pmax).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculerPi(essaisdefaut);
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            if (TB_Calc.Text != "")
            {
                double err = Double.Parse(TB_Calc.Text);
                TB_Rep.Text = ((long)Math.Ceiling((Math.Pow(ZPOISSON, 2) * pchapeau * qchapeau) / Math.Pow(err/4, 2))).ToString();
                calculerPi(Int32.Parse(TB_Rep.Text));
            }
        }

        private void TB_Calc_TextChanged(object sender, EventArgs e)
        {
            if(TB_Calc.Text != "")
            {
                BTN_Calculer.Enabled = true;
            }
            else
            {
                BTN_Calculer.Enabled = false;
            }
        }
    }
    public class Coordonnees
    {
        private double _X;
        private double _Y;

        public double X { get { return _X; } private set { this._X = value; } }
        public double Y { get { return _Y; } private set { this._Y = value; } }

        public Coordonnees(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

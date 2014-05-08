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
    
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void calculerPi(int essais)
        {
            Coordonnees coord;

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

            LBL_PIMIN.Text = (4 * pmin).ToString();
            LBL_PIMAX.Text = (4 * pmax).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculerPi(essaisdefaut);
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

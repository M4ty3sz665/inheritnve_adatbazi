using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritnve_adatbazi
{
    public partial class Form1 : Form
    {
        dtbasehandler db;
        public Form1()
        {

            InitializeComponent();
            db = new dtbasehandler();
            db.readAll();
            car oneCar = new car();
            oneCar.color = "piros";
            oneCar.hp = 500;
            oneCar.make = "VW";
            oneCar.model = "bogár";
            oneCar.year = 1973;
            oneCar.id = 1;
            //db.addOne(oneCar);
            db.deleteOne(oneCar);
        }
    }
}

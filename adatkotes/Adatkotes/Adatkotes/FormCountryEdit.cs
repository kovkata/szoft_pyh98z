using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkotes
{
    public partial class FormCountryEdit : Form
    {
        public CountryData CountryData;
        public FormCountryEdit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCountryEdit_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = CountryData;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        { }

        //private void buttonEdit_Click(object sender, EventArgs e)
        //{
        //    FormCountryEdit fce = new FormCountryEdit();
        //    fce.CountryData = countryDataBindingSource.Current as CountryData;
        //    fce.Show();
        //}
    }
}

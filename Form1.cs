using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtkrGornRabot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void avtosamosvlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avtosamosvlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Otk_gor_rabDataSet);

        }

        private void avtosamosvlBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.avtosamosvlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Otk_gor_rabDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Otk_gor_rabDataSet.Karer". При необходимости она может быть перемещена или удалена.
            this.karerTableAdapter.Fill(this._Otk_gor_rabDataSet.Karer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Otk_gor_rabDataSet.Avtosamosvl". При необходимости она может быть перемещена или удалена.
            this.avtosamosvlTableAdapter.Fill(this._Otk_gor_rabDataSet.Avtosamosvl);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBoxControl1.CheckedItems.Count == 0) 
            {
                MessageBox.Show("Select at least one report from the list");
                return;
            }

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                foreach (CheckedListBoxItem item in checkedListBoxControl1.CheckedItems)
                {
                    Type reportType = Assembly.GetExecutingAssembly().GetType(item.Value.ToString());
                    XtraReport report = Activator.CreateInstance(reportType) as XtraReport;
                    report.ExportToPdf(folderBrowserDialog1.SelectedPath + "\\" + reportType.Name + ".pdf");
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type curType in allTypes)
                if (curType.BaseType == typeof(XtraReport))
                {
                    checkedListBoxControl1.Items.Add(curType.ToString());
                }

        }
    }
}

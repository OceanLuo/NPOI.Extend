using System;
using System.Windows.Forms;
using NPOI.Extend;
using System.IO;

namespace NPOI.Example
{
    public partial class SampleOne : Form
    {
        public SampleOne()
        {
            InitializeComponent();

            if (File.Exists("sampleone.xls"))
            {
                try
                {
                    ModelOne[] list;
                    using (var factory = new ObjectFactory("sampleone.xls"))
                    {
                        list = factory.SheetToObjects<ModelOne>();
                        dataGridView1.DataSource = list;
                    }
                    using (var factory = new DrawingFactory(string.Format("{0}.xlsx", DateTime.Now.ToFileTimeUtc())))
                    {
                        factory.Draw(0, "Sheet0", list);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show("no find sampleone.xls file.");
        }
    }
}
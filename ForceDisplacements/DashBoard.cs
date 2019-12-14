using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Windows.Forms.DataVisualization.Charting;

namespace ForceDisplacements
{
    public partial class DashBoard : Form
    {
        bool Occupied = false;
        int count = 1;
        string name = "Data ";
        public DashBoard()
        {
            InitializeComponent();
        }
        private void btnSelectForDisplay_Click(object sender, EventArgs e)
        {
            SelectButton();


        }

        private void SelectButton()
        {
            OpenFileDialog file = new OpenFileDialog();
            string filePath = null; ;
            file.ShowDialog();
            file.InitialDirectory = @"C:\";
            file.RestoreDirectory = true;
            file.Title = "Open Data Files";
            file.DefaultExt = "csv";
            file.Filter = "csv files (*.csv)|*.csv";
            file.CheckFileExists = true;
            file.CheckPathExists = true;
            filePath = file.FileName;
            ReadCSV(filePath);
            Occupied = true;
        }

        private void ReadCSV(string filePath)
        {
            if (!Occupied)
            {
                if (filePath != string.Empty)
                {
                    using (var reader = new StreamReader(@filePath))
                    {
                        List<decimal> listForce = new List<decimal>();
                        List<decimal> listDisplacement = new List<decimal>();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            listForce.Add(Convert.ToDecimal(values[0]));
                            listDisplacement.Add(Convert.ToDecimal(values[1]));
                        }
                        Series series1 = new Series(name + Convert.ToString(count));
                        series1.ChartType = SeriesChartType.Line;
                        series1.Name = name + Convert.ToString(count);
                        series1.Points.DataBindXY(listDisplacement, listForce);
                        decimal maxDisplacement = listDisplacement.Max();
                        decimal maxForce = listForce.Max();
                        decimal minDisplacement = listDisplacement.Min();
                        decimal minForce = listForce.Min();
                        decimal avgForce = listForce.Average();
                        txtMaxDisp.Text = Convert.ToString(maxDisplacement);
                        txtMaxForce.Text = Convert.ToString(maxForce);
                        txtMinDisp.Text = Convert.ToString(minDisplacement);
                        txtMinForce.Text = Convert.ToString(minForce);
                        txtAvgForce.Text = Convert.ToString(avgForce);

                        chartMain.Series.Add(series1);
                        count++;
                    }
                }

            }
            else if (Occupied)
            {
                if (filePath != string.Empty)
                {
                    using (var reader = new StreamReader(@filePath))
                    {
                        List<decimal> listForce = new List<decimal>();
                        List<decimal> listDisplacement = new List<decimal>();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            listForce.Add(Convert.ToDecimal(values[0]));
                            listDisplacement.Add(Convert.ToDecimal(values[1]));
                        }
                        Series series1 = new Series(name + Convert.ToString(count));
                        series1.ChartType = SeriesChartType.Line;
                        //series1.Name = "FSeries";
                        series1.Points.DataBindXY(listDisplacement, listForce);
                        decimal maxDisplacement = listDisplacement.Max();
                        decimal maxForce = listForce.Max();
                        decimal minDisplacement = listDisplacement.Min();
                        decimal minForce = listForce.Min();
                        decimal avgForce = listForce.Average();
                        txtMaxDisp.Text = Convert.ToString(maxDisplacement);
                        txtMaxForce.Text = Convert.ToString(maxForce);
                        txtMinDisp.Text = Convert.ToString(minDisplacement);
                        txtMinForce.Text = Convert.ToString(minForce);
                        txtAvgForce.Text = Convert.ToString(avgForce);
                        chartMain.Series.Add(series1);
                        count++;
                    }
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            chartMain.Series.Clear();
            count = 0;
            txtAvgForce.Text = "";
            txtMaxDisp.Text = "";
            txtMaxForce.Text = "";
            txtMinDisp.Text = "";
            txtMinForce.Text = "";
            pbEquipment.Image = null;
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            SelectPicture();
        }

        private void SelectPicture()
        {
            OpenFileDialog filePicture = new OpenFileDialog();
            filePicture.ShowDialog();
            filePicture.InitialDirectory = @"C:\";
            filePicture.RestoreDirectory = false;
            filePicture.Title = "Open Data Files";
            filePicture.DefaultExt = "jpg";
            filePicture.Filter = "jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png|" +
                "webp files (*.webp)|*.webp";
            filePicture.CheckFileExists = true;
            filePicture.CheckPathExists = true;
            string filePath = filePicture.FileName;
            LoadImage(filePath);
        }

        private void LoadImage(string filePath)
        {
            if (filePath != string.Empty)
            {
                pbEquipment.Image = Image.FromFile(@filePath);
                pbEquipment.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveButton();
        }

        private void SaveButton()
        {
            string fileName = "Document 1";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            saveFile.Filter = "jpeg files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            fileName = saveFile.FileName;
            if (fileName != string.Empty)
            {
                chartMain.SaveImage(fileName, ChartImageFormat.Jpeg);
            }
        }

        private void DashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers==Keys.Control && e.KeyCode == Keys.O)
            {
                SelectButton();
            }
            if(e.Modifiers==Keys.Control && e.KeyCode == Keys.S)
            {
                SaveButton();
            }
            if (e.KeyCode == Keys.Escape)
            {
                ClearControls();
            }
            if(e.Modifiers==Keys.Control && e.KeyCode == Keys.I)
            {
                SelectPicture();
            }
        }
    }
}

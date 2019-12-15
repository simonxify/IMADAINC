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
        string currentlyOpenedFile = "";
        string toBeDisplayedFileName="";
        public DashBoard()
        {
            InitializeComponent();
            chartMain.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartMain.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartMain.MouseWheel += chartMain_MouseWheel;
            chartMain.ChartAreas[0].AxisX.Title = "DISPLACEMENT (mm)";
            chartMain.ChartAreas[0].AxisY.Title = "FORCE (N)";
            chartMain.ChartAreas[0].AxisX.LabelStyle.Format = "#.###";
            chartMain.ChartAreas[0].AxisY.LabelStyle.Format = "#.###";
            
        }

        private void chartMain_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                //scrolled down
                //reset magnify
                if (e.Delta < 0)
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();

                }
                //scrolled up
                //magnify
                else if (e.Delta > 0)
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 2;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (xMax - xMin) / 2;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnSelectForDisplay_Click(object sender, EventArgs e)
        {
            SelectButton();

        }

        private void SelectButton()
        {
            OpenFileDialog file = new OpenFileDialog();
            string filePath = null; ;
            string extension;
            file.ShowDialog();
            file.InitialDirectory = @"C:\";
            file.RestoreDirectory = true;
            file.Title = "Open Data Files";
            file.DefaultExt = "csv";
            file.Filter = "CSV files (*.csv)|*.csv";
            file.CheckFileExists = true;
            file.CheckPathExists = true;
            filePath = file.FileName;
            extension = Path.GetExtension(filePath);
            //MessageBox.Show(extension);
            if (extension == ".csv"){
                ReadCSV(filePath);
                string[] separatedFileName = filePath.Split('\\');
                int length = separatedFileName.Length;
                toBeDisplayedFileName = separatedFileName[length - 1];
                currentlyOpenedFile += toBeDisplayedFileName + ',';
                txtFileName.Text = currentlyOpenedFile;
                Occupied = true;

            }
            else
            {
                MessageBox.Show("You Must Select .csv files");
            }
            
        }

        private void ReadCSV(string filePath)
        {
            if (!Occupied)
            {
                if (filePath != string.Empty)
                {
                    //since var cannot be pre initialized
                    string[] x = null;
                    var input = x;
                    long lineCount = 0;
                    try
                    {
                        input = File.ReadAllLines(@filePath);
                        lineCount = input.Length;
                        //MessageBox.Show(lineCount.ToString());
                        List<decimal> listForce = new List<decimal>();
                        List<decimal> listDisplacement = new List<decimal>();
                        //becoz value start from line 14                        
                        string dateOfCreation = input[6];
                        string[] dateOfCreations = dateOfCreation.Split('=');
                        txtDoC.Text = dateOfCreations[1];
                        for (int i = 13; i < lineCount; i++)
                        {
                            var line = input[i];
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error due to " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }

            }
            else if (Occupied)
            {
                if (filePath != string.Empty)
                {
                    string[] x = null;
                    var input=x;
                    try
                    {
                        input = File.ReadAllLines(@filePath);
                        long lineCount = input.Length;
                        List<decimal> listForce = new List<decimal>();
                        List<decimal> listDisplacement = new List<decimal>();
                        string dateOfCreation = input[6];
                        string[] dateOfCreations = dateOfCreation.Split('=');
                        txtDoC.Text = dateOfCreations[1];
                        for (int i = 13; i < lineCount; i++)
                        {
                            var line = input[i];
                            var values = line.Split(',');

                            listForce.Add(Convert.ToDecimal(values[0]));
                            listDisplacement.Add(Convert.ToDecimal(values[1]));
                        }
                        Series series1 = new Series(name + Convert.ToString(count));
                        series1.ChartType = SeriesChartType.Line;
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
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error due to " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string extension = Path.GetExtension(filePath);
            if(extension==".jpg" || extension==".jpeg" || extension==".png" || extension==".gif" || extension == ".bmp")
            {
                LoadImage(filePath);
            }
            else
            {
                MessageBox.Show("Please Select Image Files.");
            }
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

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
    
}

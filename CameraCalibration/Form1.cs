using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.String;

namespace CameraCalibration
{
    public partial class Form1 : Form
    {
        private readonly CalibrationConfig _calibrationConfig;

        public Form1()
        {
            InitializeComponent();
            Text = @"Camera Calibration";
            _calibrationConfig = new CalibrationConfig();
        }

        private void rightTopChoose_Click(object sender, EventArgs e)
        {
            createFileDialogForImage(rightTopDialog, rightTopName);
        }

        private void leftTopChoose_Click(object sender, EventArgs e)
        {
            createFileDialogForImage(leftTopDialog, leftTopName);
        }

        private void rightBottomChoose_Click(object sender, EventArgs e)
        {
            createFileDialogForImage(rightBottomDialog, rightBottomName);
        }

        private void leftBottomChoose_Click(object sender, EventArgs e)
        {
            createFileDialogForImage(leftBottomDialog, leftBottomName);
        }

        private void createFileDialogForImage(OpenFileDialog dialog, TextBox nameBox)
        {
            dialog.Filter =
                "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";
            dialog.ShowDialog();
            nameBox.Text = dialog.FileName;
        }

        private void DrawCalibratingForm(string fileName, int quarter)
        {
            if (IsNullOrEmpty(fileName))
            {
                MessageBox.Show(@"You have to choose a file first", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var calibForm = new Form2(fileName, quarter, this);
                calibForm.Show();
            }
        }

        private void rightTopCalib_Click(object sender, EventArgs e)
        {
            DrawCalibratingForm(rightTopName.Text, 2);
        }

        private void leftTopCalib_Click(object sender, EventArgs e)
        {
            DrawCalibratingForm(leftTopName.Text, 1);
        }

        private void rightBottomCalib_Click(object sender, EventArgs e)
        {
            DrawCalibratingForm(rightBottomName.Text, 3);
        }

        private void leftBottomCalib_Click(object sender, EventArgs e)
        {
            DrawCalibratingForm(leftBottomName.Text, 4);
        }


        public void ApplyPosition(List<Point> polygon, int quarter)
        {
            var points = polygon.ToArray();
            var displayText = "Chosen points: (" + points[0].X + ", " + points[0].Y + ") (" +
                              points[1].X + ", " + points[1].Y + ") (" +
                              points[2].X + ", " + points[2].Y + ") (" +
                              points[3].X + ", " + points[3].Y + ")";

            if (quarter == 1)
            {
                leftTopPos.Text = displayText;
                _calibrationConfig.LeftTop = ChangeOrderForCalibration(polygon);
            }
            else if (quarter == 2)
            {
                rightTopPos.Text = displayText;
                _calibrationConfig.RightTop = ChangeOrderForCalibration(polygon);
            }
            else if (quarter == 3)
            {
                rightBottomPos.Text = displayText;
                _calibrationConfig.RightBottom = ChangeOrderForCalibration(polygon);
            }
            else if (quarter == 4)
            {
                leftBottomPos.Text = displayText;
                _calibrationConfig.LeftBottom = ChangeOrderForCalibration(polygon);
            }

            BringToFront();
        }

        private static List<Point> ChangeOrderForCalibration(List<Point> polygon)
        {
            polygon = polygon.Distinct().ToList();
            var topPoints = polygon.OrderBy(p => p.Y).Take(2).ToList();
            var bottomPoints = polygon.OrderByDescending(p => p.Y).Take(2).ToList();
            var leftPoints = polygon.OrderBy(p => p.X).Take(2).ToList();
            var rightPoints = polygon.OrderByDescending(p => p.X).Take(2).ToList();
            //the right order is starting by left-bottom point and going clockwise
            //it's the way openCV is consuming the values
            var returnList = new List<Point>();
            returnList.Add(bottomPoints.Intersect(leftPoints).ToList().First());
            returnList.Add(topPoints.Intersect(leftPoints).ToList().First());
            returnList.Add(topPoints.Intersect(rightPoints).ToList().First());
            returnList.Add(bottomPoints.Intersect(rightPoints).ToList().First());

            return returnList;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (_calibrationConfig.LeftTop.Count < 0 || _calibrationConfig.LeftBottom.Count < 0 ||
                _calibrationConfig.RightTop.Count < 0 || _calibrationConfig.RightBottom.Count < 0)
            {
                MessageBox.Show(@"You have to calibrate all images", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var jsonCalibration = JsonConvert.SerializeObject(_calibrationConfig);
            using (var saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Json files (*.json)|*.json";
                saveFile.FilterIndex = 2;
                saveFile.RestoreDirectory = true;
                saveFile.FileName = "calibrationConfiguration.json";
                if (saveFile.ShowDialog() != DialogResult.OK) return;
                var path = saveFile.FileName;
                using (var writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(jsonCalibration);
                    writer.Close();
                }
            }
            MessageBox.Show(@"File saved!", @"Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    internal class CalibrationConfig
    {
        public List<Point> LeftBottom = new List<Point>();
        public List<Point> LeftTop = new List<Point>();
        public List<Point> RightTop = new List<Point>();
        public List<Point> RightBottom = new List<Point>();
    }
}

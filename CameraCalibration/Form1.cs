using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.String;

namespace CameraCalibration
{
    public partial class Form1 : Form
    {
        private List<Point> _leftTop;
        private List<Point> _leftBottom;
        private List<Point> _rightTop;
        private List<Point> _rightBottom;

        public Form1()
        {
            InitializeComponent();
            Text = @"Camera Calibration";
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
                MessageBox.Show(@"You have to choose a file first", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //ChooseQuadrangle(pictureBox);
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
                _leftTop = polygon;
            }
            else if (quarter == 2)
            {
                rightTopPos.Text = displayText;
                _rightTop = polygon;
            }
            else if (quarter == 3)
            {
                rightBottomPos.Text = displayText;
                _rightBottom = polygon;
            }
            else if (quarter == 4)
            {
                leftBottomPos.Text = displayText;
                _leftBottom = polygon;
            }

            BringToFront();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (_leftTop == null || _leftBottom == null || _rightTop == null || _rightBottom == null)
            {
                MessageBox.Show(@"You have to calibrate all images", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

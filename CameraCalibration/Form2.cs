using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraCalibration
{
    public partial class Form2 : Form
    {
        private List<Point> _polygon;
        private Point _newPoint;
        private readonly int _quarter;
        private readonly Form1 _mainForm;
        private int _newHeight = 500;
        private double _resizePercent;

        public Form2(string fileName, int quarter, Form1 form1)
        {
            _quarter = quarter;
            _mainForm = form1;
            InitializeComponent();
            Text = @"Please draw a quadrangle representing the calibrated image";
            InitCalibPictureBox(fileName);

        }

        private void InitCalibPictureBox(string fileName)
        {
            var image = Image.FromFile(fileName);
            //shown image will always be 500px high
            _resizePercent = (double) _newHeight / image.Height;
            var newWidth = Convert.ToInt32(image.Width * _resizePercent);

            Image newImage = new Bitmap(newWidth, _newHeight);
            using (var graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, _newHeight);
            }

            Size = new Size(newWidth, _newHeight);
            var pictureBox = new PictureBox
            {
                Image = newImage,
                Size = new Size(newWidth, _newHeight)
            };
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.Paint += pictureBox_Paint;
            Controls.Add(pictureBox);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (_polygon != null)
            {
                if (e.Button == MouseButtons.Right)
                { 
                    if (_polygon.Count < 3) _polygon = null;
                }
                else
                {
                    if (_polygon[_polygon.Count - 1] != e.Location) _polygon.Add(e.Location);
                }
            }
            else
            {
                _polygon = new List<Point>();
                _newPoint = e.Location;
                _polygon.Add(e.Location);
            }

            pictureBox?.Invalidate();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (_polygon == null) return;
            _newPoint = e.Location;
            pictureBox?.Invalidate();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (_polygon == null) return;
            if (_polygon.Count == 5)
            {
                ValidateEnteredPoints();
                return;
            };
            if (_polygon.Count > 1)
            {
                if (_polygon.Count == 4)
                { 
                    var points = _polygon.ToArray();
                    var finishingPoint = new Point(points[0].X, points[0].Y);
                    _polygon.Add(finishingPoint);
                }
                e.Graphics.DrawLines(new Pen(Color.Green, 3), _polygon.ToArray());
            }

            if (_polygon.Count == 0  || _polygon.Count == 5) return;
            using (var dashedPen = new Pen(Color.Green, 3))
            {
                dashedPen.DashPattern = new float[] {3, 3};
                e.Graphics.DrawLine(dashedPen,
                    _polygon[_polygon.Count - 1],
                    _newPoint);
            }
        }

        private void ValidateEnteredPoints()
        {
            var resizedPolygon = new List<Point>();
            var newPoint = new Point();
            foreach (var point in _polygon)
            {
                newPoint.X = (int)(point.X / _resizePercent);
                newPoint.Y = (int)(point.Y / _resizePercent);
                resizedPolygon.Add(newPoint);
            }
            var points = resizedPolygon.ToArray();
            var displayText = "Chosen points:\n" + points[0] + "\n" +
                points[1] + "\n" + points[2] + "\n" + points[3];
            var validationResult = MessageBox.Show(displayText, @"Do you accept the coordinates?", MessageBoxButtons.YesNo);
            if (validationResult == DialogResult.No)
            {
                _polygon = null;
            }
            else
            {
                _mainForm.ApplyPosition(resizedPolygon, _quarter);
                Close();
            }
        }
    }
}

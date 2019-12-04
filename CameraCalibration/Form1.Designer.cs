namespace CameraCalibration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rightTopPos = new System.Windows.Forms.Label();
            this.rightTopCalib = new System.Windows.Forms.Button();
            this.rightTopName = new System.Windows.Forms.TextBox();
            this.rightTopChoose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.leftTopPos = new System.Windows.Forms.Label();
            this.leftTopCalib = new System.Windows.Forms.Button();
            this.leftTopName = new System.Windows.Forms.TextBox();
            this.leftTopChoose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.leftBottomPos = new System.Windows.Forms.Label();
            this.leftBottomCalib = new System.Windows.Forms.Button();
            this.leftBottomName = new System.Windows.Forms.TextBox();
            this.leftBottomChoose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rightBottomPos = new System.Windows.Forms.Label();
            this.rightBottomCalib = new System.Windows.Forms.Button();
            this.rightBottomName = new System.Windows.Forms.TextBox();
            this.rightBottomChoose = new System.Windows.Forms.Button();
            this.rightTopDialog = new System.Windows.Forms.OpenFileDialog();
            this.leftTopDialog = new System.Windows.Forms.OpenFileDialog();
            this.rightBottomDialog = new System.Windows.Forms.OpenFileDialog();
            this.leftBottomDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightTopPos);
            this.groupBox1.Controls.Add(this.rightTopCalib);
            this.groupBox1.Controls.Add(this.rightTopName);
            this.groupBox1.Controls.Add(this.rightTopChoose);
            this.groupBox1.Location = new System.Drawing.Point(408, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Right-Top Image";
            // 
            // rightTopPos
            // 
            this.rightTopPos.AutoSize = true;
            this.rightTopPos.Location = new System.Drawing.Point(6, 124);
            this.rightTopPos.Name = "rightTopPos";
            this.rightTopPos.Size = new System.Drawing.Size(91, 13);
            this.rightTopPos.TabIndex = 4;
            this.rightTopPos.Text = "Choosen position:";
            // 
            // rightTopCalib
            // 
            this.rightTopCalib.Location = new System.Drawing.Point(6, 73);
            this.rightTopCalib.Name = "rightTopCalib";
            this.rightTopCalib.Size = new System.Drawing.Size(75, 23);
            this.rightTopCalib.TabIndex = 3;
            this.rightTopCalib.Text = "Calibrate";
            this.rightTopCalib.UseVisualStyleBackColor = true;
            this.rightTopCalib.Click += new System.EventHandler(this.rightTopCalib_Click);
            // 
            // rightTopName
            // 
            this.rightTopName.Location = new System.Drawing.Point(95, 33);
            this.rightTopName.Name = "rightTopName";
            this.rightTopName.ReadOnly = true;
            this.rightTopName.Size = new System.Drawing.Size(249, 20);
            this.rightTopName.TabIndex = 2;
            // 
            // rightTopChoose
            // 
            this.rightTopChoose.Location = new System.Drawing.Point(6, 31);
            this.rightTopChoose.Name = "rightTopChoose";
            this.rightTopChoose.Size = new System.Drawing.Size(85, 23);
            this.rightTopChoose.TabIndex = 1;
            this.rightTopChoose.Text = "Choose image";
            this.rightTopChoose.UseVisualStyleBackColor = true;
            this.rightTopChoose.Click += new System.EventHandler(this.rightTopChoose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leftTopPos);
            this.groupBox2.Controls.Add(this.leftTopCalib);
            this.groupBox2.Controls.Add(this.leftTopName);
            this.groupBox2.Controls.Add(this.leftTopChoose);
            this.groupBox2.Location = new System.Drawing.Point(30, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Left-Top Image";
            // 
            // leftTopPos
            // 
            this.leftTopPos.AutoSize = true;
            this.leftTopPos.Location = new System.Drawing.Point(6, 124);
            this.leftTopPos.Name = "leftTopPos";
            this.leftTopPos.Size = new System.Drawing.Size(91, 13);
            this.leftTopPos.TabIndex = 3;
            this.leftTopPos.Text = "Choosen position:";
            // 
            // leftTopCalib
            // 
            this.leftTopCalib.Location = new System.Drawing.Point(6, 73);
            this.leftTopCalib.Name = "leftTopCalib";
            this.leftTopCalib.Size = new System.Drawing.Size(75, 23);
            this.leftTopCalib.TabIndex = 2;
            this.leftTopCalib.Text = "Calibrate";
            this.leftTopCalib.UseVisualStyleBackColor = true;
            this.leftTopCalib.Click += new System.EventHandler(this.leftTopCalib_Click);
            // 
            // leftTopName
            // 
            this.leftTopName.Location = new System.Drawing.Point(98, 33);
            this.leftTopName.Name = "leftTopName";
            this.leftTopName.ReadOnly = true;
            this.leftTopName.Size = new System.Drawing.Size(246, 20);
            this.leftTopName.TabIndex = 1;
            // 
            // leftTopChoose
            // 
            this.leftTopChoose.Location = new System.Drawing.Point(6, 31);
            this.leftTopChoose.Name = "leftTopChoose";
            this.leftTopChoose.Size = new System.Drawing.Size(85, 23);
            this.leftTopChoose.TabIndex = 0;
            this.leftTopChoose.Text = "Choose image";
            this.leftTopChoose.UseVisualStyleBackColor = true;
            this.leftTopChoose.Click += new System.EventHandler(this.leftTopChoose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.leftBottomPos);
            this.groupBox3.Controls.Add(this.leftBottomCalib);
            this.groupBox3.Controls.Add(this.leftBottomName);
            this.groupBox3.Controls.Add(this.leftBottomChoose);
            this.groupBox3.Location = new System.Drawing.Point(30, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 170);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Left-Bottom Image";
            // 
            // leftBottomPos
            // 
            this.leftBottomPos.AutoSize = true;
            this.leftBottomPos.Location = new System.Drawing.Point(6, 127);
            this.leftBottomPos.Name = "leftBottomPos";
            this.leftBottomPos.Size = new System.Drawing.Size(91, 13);
            this.leftBottomPos.TabIndex = 3;
            this.leftBottomPos.Text = "Choosen position:";
            // 
            // leftBottomCalib
            // 
            this.leftBottomCalib.Location = new System.Drawing.Point(6, 74);
            this.leftBottomCalib.Name = "leftBottomCalib";
            this.leftBottomCalib.Size = new System.Drawing.Size(75, 23);
            this.leftBottomCalib.TabIndex = 2;
            this.leftBottomCalib.Text = "Calibrate";
            this.leftBottomCalib.UseVisualStyleBackColor = true;
            this.leftBottomCalib.Click += new System.EventHandler(this.leftBottomCalib_Click);
            // 
            // leftBottomName
            // 
            this.leftBottomName.Location = new System.Drawing.Point(97, 34);
            this.leftBottomName.Name = "leftBottomName";
            this.leftBottomName.ReadOnly = true;
            this.leftBottomName.Size = new System.Drawing.Size(247, 20);
            this.leftBottomName.TabIndex = 1;
            // 
            // leftBottomChoose
            // 
            this.leftBottomChoose.Location = new System.Drawing.Point(6, 32);
            this.leftBottomChoose.Name = "leftBottomChoose";
            this.leftBottomChoose.Size = new System.Drawing.Size(85, 23);
            this.leftBottomChoose.TabIndex = 0;
            this.leftBottomChoose.Text = "Choose image";
            this.leftBottomChoose.UseVisualStyleBackColor = true;
            this.leftBottomChoose.Click += new System.EventHandler(this.leftBottomChoose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rightBottomPos);
            this.groupBox4.Controls.Add(this.rightBottomCalib);
            this.groupBox4.Controls.Add(this.rightBottomName);
            this.groupBox4.Controls.Add(this.rightBottomChoose);
            this.groupBox4.Location = new System.Drawing.Point(408, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 170);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right-Bottom Image";
            // 
            // rightBottomPos
            // 
            this.rightBottomPos.AutoSize = true;
            this.rightBottomPos.Location = new System.Drawing.Point(6, 127);
            this.rightBottomPos.Name = "rightBottomPos";
            this.rightBottomPos.Size = new System.Drawing.Size(91, 13);
            this.rightBottomPos.TabIndex = 3;
            this.rightBottomPos.Text = "Choosen position:";
            // 
            // rightBottomCalib
            // 
            this.rightBottomCalib.Location = new System.Drawing.Point(6, 74);
            this.rightBottomCalib.Name = "rightBottomCalib";
            this.rightBottomCalib.Size = new System.Drawing.Size(75, 23);
            this.rightBottomCalib.TabIndex = 2;
            this.rightBottomCalib.Text = "Calibrate";
            this.rightBottomCalib.UseVisualStyleBackColor = true;
            this.rightBottomCalib.Click += new System.EventHandler(this.rightBottomCalib_Click);
            // 
            // rightBottomName
            // 
            this.rightBottomName.Location = new System.Drawing.Point(95, 34);
            this.rightBottomName.Name = "rightBottomName";
            this.rightBottomName.ReadOnly = true;
            this.rightBottomName.Size = new System.Drawing.Size(249, 20);
            this.rightBottomName.TabIndex = 1;
            // 
            // rightBottomChoose
            // 
            this.rightBottomChoose.Location = new System.Drawing.Point(6, 32);
            this.rightBottomChoose.Name = "rightBottomChoose";
            this.rightBottomChoose.Size = new System.Drawing.Size(85, 23);
            this.rightBottomChoose.TabIndex = 0;
            this.rightBottomChoose.Text = "Choose image";
            this.rightBottomChoose.UseVisualStyleBackColor = true;
            this.rightBottomChoose.Click += new System.EventHandler(this.rightBottomChoose_Click);
            // 
            // rightTopDialog
            // 
            this.rightTopDialog.FileName = "openFileDialog1";
            // 
            // leftTopDialog
            // 
            this.leftTopDialog.FileName = "openFileDialog2";
            // 
            // rightBottomDialog
            // 
            this.rightBottomDialog.FileName = "openFileDialog3";
            // 
            // leftBottomDialog
            // 
            this.leftBottomDialog.FileName = "openFileDialog4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate configuration JSON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button rightTopChoose;
        private System.Windows.Forms.Button leftTopChoose;
        private System.Windows.Forms.Button leftBottomChoose;
        private System.Windows.Forms.Button rightBottomChoose;
        private System.Windows.Forms.TextBox rightTopName;
        private System.Windows.Forms.TextBox leftTopName;
        private System.Windows.Forms.TextBox leftBottomName;
        private System.Windows.Forms.TextBox rightBottomName;
        private System.Windows.Forms.Button rightTopCalib;
        private System.Windows.Forms.Button leftTopCalib;
        private System.Windows.Forms.Button leftBottomCalib;
        private System.Windows.Forms.Button rightBottomCalib;
        private System.Windows.Forms.Label rightTopPos;
        private System.Windows.Forms.Label leftTopPos;
        private System.Windows.Forms.Label leftBottomPos;
        private System.Windows.Forms.Label rightBottomPos;
        private System.Windows.Forms.OpenFileDialog rightTopDialog;
        private System.Windows.Forms.OpenFileDialog leftTopDialog;
        private System.Windows.Forms.OpenFileDialog rightBottomDialog;
        private System.Windows.Forms.OpenFileDialog leftBottomDialog;
        private System.Windows.Forms.Button button1;
    }
}


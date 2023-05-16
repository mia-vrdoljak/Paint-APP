using System;

namespace Signature_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlUpperMenu = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.PnlMainMenu = new System.Windows.Forms.Panel();
            this.BtnFill = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.PicColorPicker = new System.Windows.Forms.PictureBox();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnColorPalet = new System.Windows.Forms.Button();
            this.PicCurrentColor = new System.Windows.Forms.Button();
            this.BtnLinesize2 = new System.Windows.Forms.Button();
            this.BtnLinesize1 = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnTextbox = new System.Windows.Forms.Button();
            this.BtnLinesize3 = new System.Windows.Forms.Button();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PnlUpperMenu.SuspendLayout();
            this.PnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicColorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlUpperMenu
            // 
            this.PnlUpperMenu.BackColor = System.Drawing.Color.Teal;
            this.PnlUpperMenu.Controls.Add(this.BtnClear);
            this.PnlUpperMenu.Controls.Add(this.BtnSave);
            this.PnlUpperMenu.Controls.Add(this.BtnUpload);
            this.PnlUpperMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUpperMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlUpperMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlUpperMenu.Name = "PnlUpperMenu";
            this.PnlUpperMenu.Size = new System.Drawing.Size(1245, 39);
            this.PnlUpperMenu.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Teal;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.Color.Teal;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(1193, 0);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(35, 39);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Teal;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.Teal;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(60, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(35, 34);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackColor = System.Drawing.Color.Teal;
            this.BtnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpload.ForeColor = System.Drawing.Color.Teal;
            this.BtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpload.Image")));
            this.BtnUpload.Location = new System.Drawing.Point(13, 2);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(35, 34);
            this.BtnUpload.TabIndex = 11;
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // PnlMainMenu
            // 
            this.PnlMainMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PnlMainMenu.Controls.Add(this.BtnFill);
            this.PnlMainMenu.Controls.Add(this.BtnLine);
            this.PnlMainMenu.Controls.Add(this.BtnEllipse);
            this.PnlMainMenu.Controls.Add(this.BtnRectangle);
            this.PnlMainMenu.Controls.Add(this.PicColorPicker);
            this.PnlMainMenu.Controls.Add(this.BtnEraser);
            this.PnlMainMenu.Controls.Add(this.BtnColorPalet);
            this.PnlMainMenu.Controls.Add(this.PicCurrentColor);
            this.PnlMainMenu.Controls.Add(this.BtnLinesize2);
            this.PnlMainMenu.Controls.Add(this.BtnLinesize1);
            this.PnlMainMenu.Controls.Add(this.BtnPencil);
            this.PnlMainMenu.Controls.Add(this.BtnTextbox);
            this.PnlMainMenu.Controls.Add(this.BtnLinesize3);
            this.PnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMainMenu.Location = new System.Drawing.Point(0, 39);
            this.PnlMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainMenu.Name = "PnlMainMenu";
            this.PnlMainMenu.Size = new System.Drawing.Size(1245, 90);
            this.PnlMainMenu.TabIndex = 1;
            // 
            // BtnFill
            // 
            this.BtnFill.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFill.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnFill.Image = ((System.Drawing.Image)(resources.GetObject("BtnFill.Image")));
            this.BtnFill.Location = new System.Drawing.Point(487, 12);
            this.BtnFill.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFill.Name = "BtnFill";
            this.BtnFill.Size = new System.Drawing.Size(65, 65);
            this.BtnFill.TabIndex = 15;
            this.BtnFill.UseVisualStyleBackColor = false;
            this.BtnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.Location = new System.Drawing.Point(340, 12);
            this.BtnLine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(65, 65);
            this.BtnLine.TabIndex = 14;
            this.BtnLine.UseVisualStyleBackColor = false;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllipse.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("BtnEllipse.Image")));
            this.BtnEllipse.Location = new System.Drawing.Point(267, 12);
            this.BtnEllipse.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(65, 65);
            this.BtnEllipse.TabIndex = 13;
            this.BtnEllipse.UseVisualStyleBackColor = false;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("BtnRectangle.Image")));
            this.BtnRectangle.Location = new System.Drawing.Point(187, 12);
            this.BtnRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(65, 65);
            this.BtnRectangle.TabIndex = 12;
            this.BtnRectangle.UseVisualStyleBackColor = false;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // PicColorPicker
            // 
            this.PicColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("PicColorPicker.Image")));
            this.PicColorPicker.Location = new System.Drawing.Point(753, 10);
            this.PicColorPicker.Margin = new System.Windows.Forms.Padding(0);
            this.PicColorPicker.Name = "PicColorPicker";
            this.PicColorPicker.Size = new System.Drawing.Size(413, 74);
            this.PicColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicColorPicker.TabIndex = 11;
            this.PicColorPicker.TabStop = false;
            this.PicColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicColorPicker_MouseClick);
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("BtnEraser.Image")));
            this.BtnEraser.Location = new System.Drawing.Point(407, 12);
            this.BtnEraser.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(65, 65);
            this.BtnEraser.TabIndex = 10;
            this.BtnEraser.UseVisualStyleBackColor = false;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnColorPalet
            // 
            this.BtnColorPalet.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnColorPalet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorPalet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColorPalet.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnColorPalet.Image = ((System.Drawing.Image)(resources.GetObject("BtnColorPalet.Image")));
            this.BtnColorPalet.Location = new System.Drawing.Point(673, 12);
            this.BtnColorPalet.Margin = new System.Windows.Forms.Padding(0);
            this.BtnColorPalet.Name = "BtnColorPalet";
            this.BtnColorPalet.Size = new System.Drawing.Size(65, 65);
            this.BtnColorPalet.TabIndex = 9;
            this.BtnColorPalet.UseVisualStyleBackColor = false;
            this.BtnColorPalet.Click += new System.EventHandler(this.BtnColorPalet_Click);
            // 
            // PicCurrentColor
            // 
            this.PicCurrentColor.BackColor = System.Drawing.Color.Teal;
            this.PicCurrentColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCurrentColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PicCurrentColor.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.PicCurrentColor.Location = new System.Drawing.Point(1180, 25);
            this.PicCurrentColor.Margin = new System.Windows.Forms.Padding(0);
            this.PicCurrentColor.Name = "PicCurrentColor";
            this.PicCurrentColor.Size = new System.Drawing.Size(40, 39);
            this.PicCurrentColor.TabIndex = 8;
            this.PicCurrentColor.UseVisualStyleBackColor = false;
            // 
            // BtnLinesize2
            // 
            this.BtnLinesize2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLinesize2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLinesize2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinesize2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLinesize2.Image = ((System.Drawing.Image)(resources.GetObject("BtnLinesize2.Image")));
            this.BtnLinesize2.Location = new System.Drawing.Point(593, 32);
            this.BtnLinesize2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLinesize2.Name = "BtnLinesize2";
            this.BtnLinesize2.Size = new System.Drawing.Size(65, 20);
            this.BtnLinesize2.TabIndex = 6;
            this.BtnLinesize2.UseVisualStyleBackColor = false;
            this.BtnLinesize2.Click += new System.EventHandler(this.BtnLinesize2_Click);
            // 
            // BtnLinesize1
            // 
            this.BtnLinesize1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLinesize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLinesize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinesize1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLinesize1.Image = ((System.Drawing.Image)(resources.GetObject("BtnLinesize1.Image")));
            this.BtnLinesize1.Location = new System.Drawing.Point(593, 12);
            this.BtnLinesize1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLinesize1.Name = "BtnLinesize1";
            this.BtnLinesize1.Size = new System.Drawing.Size(65, 20);
            this.BtnLinesize1.TabIndex = 5;
            this.BtnLinesize1.UseVisualStyleBackColor = false;
            this.BtnLinesize1.Click += new System.EventHandler(this.BtnLinesize1_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnPencil.Image = ((System.Drawing.Image)(resources.GetObject("BtnPencil.Image")));
            this.BtnPencil.Location = new System.Drawing.Point(107, 12);
            this.BtnPencil.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(65, 65);
            this.BtnPencil.TabIndex = 4;
            this.BtnPencil.UseVisualStyleBackColor = false;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnTextbox
            // 
            this.BtnTextbox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTextbox.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnTextbox.Image = ((System.Drawing.Image)(resources.GetObject("BtnTextbox.Image")));
            this.BtnTextbox.Location = new System.Drawing.Point(27, 12);
            this.BtnTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTextbox.Name = "BtnTextbox";
            this.BtnTextbox.Size = new System.Drawing.Size(65, 65);
            this.BtnTextbox.TabIndex = 3;
            this.BtnTextbox.UseVisualStyleBackColor = false;
            this.BtnTextbox.Click += new System.EventHandler(this.BtnTextbox_Click);
            // 
            // BtnLinesize3
            // 
            this.BtnLinesize3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLinesize3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLinesize3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinesize3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLinesize3.Image = ((System.Drawing.Image)(resources.GetObject("BtnLinesize3.Image")));
            this.BtnLinesize3.Location = new System.Drawing.Point(593, 52);
            this.BtnLinesize3.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLinesize3.Name = "BtnLinesize3";
            this.BtnLinesize3.Size = new System.Drawing.Size(65, 32);
            this.BtnLinesize3.TabIndex = 7;
            this.BtnLinesize3.UseVisualStyleBackColor = false;
            this.BtnLinesize3.Click += new System.EventHandler(this.BtnLinesize3_Click);
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 794);
            this.PnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(1245, 20);
            this.PnlFooter.TabIndex = 2;
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 0);
            this.Pic.Margin = new System.Windows.Forms.Padding(0);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(1245, 814);
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 814);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlMainMenu);
            this.Controls.Add(this.PnlUpperMenu);
            this.Controls.Add(this.Pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlUpperMenu.ResumeLayout(false);
            this.PnlMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicColorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUpperMenu;
        private System.Windows.Forms.Panel PnlMainMenu;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Button BtnTextbox;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnLinesize3;
        private System.Windows.Forms.Button BtnLinesize2;
        private System.Windows.Forms.Button BtnLinesize1;
        private System.Windows.Forms.Button PicCurrentColor;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnColorPalet;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.PictureBox PicColorPicker;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnEllipse;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public EventHandler Pic_Click { get; private set; }
    }
}


﻿namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            SuspendLayout();
            // 
            // drawingPanel
            // 
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Location = new Point(0, 0);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(523, 390);
            drawingPanel.TabIndex = 0;
            drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(drawingPanel_MouseDown);
            drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(drawingPanel_MouseMove);
            drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(drawingPanel_MouseUp);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 390);
            Controls.Add(drawingPanel);
            Name = "Form1";
            Text = "Paint ";
            ResumeLayout(false);
        }

        #endregion

        private Panel drawingPanel;


    }
}

﻿namespace SeismographApp
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult1 = new System.Windows.Forms.Label();
            this.labelResult2 = new System.Windows.Forms.Label();
            this.labelResult3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(10, 93);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1041, 448);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // labelResult1
            // 
            this.labelResult1.AutoSize = true;
            this.labelResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult1.Location = new System.Drawing.Point(262, 52);
            this.labelResult1.Name = "labelResult1";
            this.labelResult1.Size = new System.Drawing.Size(70, 25);
            this.labelResult1.TabIndex = 4;
            this.labelResult1.Text = "label1";
            // 
            // labelResult2
            // 
            this.labelResult2.AutoSize = true;
            this.labelResult2.BackColor = System.Drawing.Color.Red;
            this.labelResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult2.Location = new System.Drawing.Point(12, 9);
            this.labelResult2.MaximumSize = new System.Drawing.Size(1039, 41);
            this.labelResult2.MinimumSize = new System.Drawing.Size(5, 41);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(5, 41);
            this.labelResult2.TabIndex = 5;
            this.labelResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult3
            // 
            this.labelResult3.AutoSize = true;
            this.labelResult3.BackColor = System.Drawing.Color.GreenYellow;
            this.labelResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult3.Location = new System.Drawing.Point(12, 9);
            this.labelResult3.MaximumSize = new System.Drawing.Size(1039, 41);
            this.labelResult3.MinimumSize = new System.Drawing.Size(1039, 41);
            this.labelResult3.Name = "labelResult3";
            this.labelResult3.Size = new System.Drawing.Size(1039, 41);
            this.labelResult3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acceleration Magnitude:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelResult2);
            this.Controls.Add(this.labelResult3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " Earthquake Detection Seismograph";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelResult1;
        private System.Windows.Forms.Label labelResult2;
        private System.Windows.Forms.Label labelResult3;
        private System.Windows.Forms.Label label1;
    }
}


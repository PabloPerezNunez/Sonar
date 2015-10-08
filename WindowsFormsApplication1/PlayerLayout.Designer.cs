using System;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Sonar
{
    partial class PlayerLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerLayout));
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.customTrackBar1 = new Sonar.CustomTrackBar();
            this.button1 = new Sonar.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(50, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 50);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(675, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(725, 1);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 17;
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTrackBar1.AutoSize = false;
            this.customTrackBar1.BarraColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.customTrackBar1.Location = new System.Drawing.Point(81, 18);
            this.customTrackBar1.MargenBarra = 1;
            this.customTrackBar1.MargenProgreso = 3;
            this.customTrackBar1.MargenSlider = 1;
            this.customTrackBar1.Maximum = 100;
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customTrackBar1.Size = new System.Drawing.Size(587, 14);
            this.customTrackBar1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.customTrackBar1.TabIndex = 18;
            this.customTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.customTrackBar1.Valor = 0;
            this.customTrackBar1.ValorCambiado += new Sonar.customTrackBarHandle(this.customTrackBar1_ValorCambiado);
            // 
            // button1
            // 
            this.button1.ClickedIcon = ((System.Drawing.Image)(resources.GetObject("button1.ClickedIcon")));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.HoverClickedIcon = ((System.Drawing.Image)(resources.GetObject("button1.HoverClickedIcon")));
            this.button1.HoverIcon = ((System.Drawing.Image)(resources.GetObject("button1.HoverIcon")));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.NormalIcon = ((System.Drawing.Image)(resources.GetObject("button1.NormalIcon")));
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.customTrackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "PlayerLayout";
            this.Size = new System.Drawing.Size(725, 50);
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private ImageButton button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private ProgressBar progressBar1;
        private CustomTrackBar customTrackBar1;
    }
}

﻿
namespace Formula
{
    partial class RCVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCVP));
            this.Result = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Button();
            this.Voltage = new System.Windows.Forms.Button();
            this.Current = new System.Windows.Forms.Button();
            this.Resistance = new System.Windows.Forms.Button();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(376, 348);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(43, 13);
            this.Result.TabIndex = 13;
            this.Result.Text = "Result :";
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(448, 264);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(115, 23);
            this.Power.TabIndex = 12;
            this.Power.Text = "Power";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Voltage
            // 
            this.Voltage.Location = new System.Drawing.Point(241, 264);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(112, 23);
            this.Voltage.TabIndex = 11;
            this.Voltage.Text = "Voltage";
            this.Voltage.UseVisualStyleBackColor = true;
            this.Voltage.Click += new System.EventHandler(this.Voltage_Click_1);
            // 
            // Current
            // 
            this.Current.Location = new System.Drawing.Point(448, 179);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(116, 23);
            this.Current.TabIndex = 10;
            this.Current.Text = "Current";
            this.Current.UseVisualStyleBackColor = true;
            this.Current.Click += new System.EventHandler(this.Current_Click_1);
            // 
            // Resistance
            // 
            this.Resistance.Location = new System.Drawing.Point(241, 179);
            this.Resistance.Name = "Resistance";
            this.Resistance.Size = new System.Drawing.Size(112, 23);
            this.Resistance.TabIndex = 9;
            this.Resistance.Text = "Resistance";
            this.Resistance.UseVisualStyleBackColor = true;
            this.Resistance.Click += new System.EventHandler(this.Resistance_Click_1);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(424, 89);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(159, 20);
            this.Value2.TabIndex = 8;
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(218, 89);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(152, 20);
            this.Value1.TabIndex = 7;
            // 
            // RCVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Voltage);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.Resistance);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RCVP";
            this.Text = "RCVP";
            this.Load += new System.EventHandler(this.RCVP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Voltage;
        private System.Windows.Forms.Button Current;
        private System.Windows.Forms.Button Resistance;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.TextBox Value1;
    }
}
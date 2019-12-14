namespace ForceDisplacements
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnSelectForDisplay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMaxDisp = new System.Windows.Forms.TextBox();
            this.txtMinForce = new System.Windows.Forms.TextBox();
            this.txtMinDisp = new System.Windows.Forms.TextBox();
            this.txtAvgForce = new System.Windows.Forms.TextBox();
            this.txtMaxForce = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.pbEquipment = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectForDisplay
            // 
            this.btnSelectForDisplay.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectForDisplay.Location = new System.Drawing.Point(17, 22);
            this.btnSelectForDisplay.Name = "btnSelectForDisplay";
            this.btnSelectForDisplay.Size = new System.Drawing.Size(146, 39);
            this.btnSelectForDisplay.TabIndex = 0;
            this.btnSelectForDisplay.Text = "Select File (Ctrl+O)";
            this.btnSelectForDisplay.UseVisualStyleBackColor = true;
            this.btnSelectForDisplay.Click += new System.EventHandler(this.btnSelectForDisplay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtMaxDisp);
            this.panel1.Controls.Add(this.txtMinForce);
            this.panel1.Controls.Add(this.txtMinDisp);
            this.panel1.Controls.Add(this.txtAvgForce);
            this.panel1.Controls.Add(this.txtMaxForce);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelectPicture);
            this.panel1.Controls.Add(this.pbEquipment);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.chartMain);
            this.panel1.Controls.Add(this.btnSelectForDisplay);
            this.panel1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 502);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(169, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 39);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save (Ctrl+S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMaxDisp
            // 
            this.txtMaxDisp.Location = new System.Drawing.Point(647, 135);
            this.txtMaxDisp.Name = "txtMaxDisp";
            this.txtMaxDisp.Size = new System.Drawing.Size(66, 25);
            this.txtMaxDisp.TabIndex = 28;
            // 
            // txtMinForce
            // 
            this.txtMinForce.Location = new System.Drawing.Point(647, 166);
            this.txtMinForce.Name = "txtMinForce";
            this.txtMinForce.Size = new System.Drawing.Size(66, 25);
            this.txtMinForce.TabIndex = 27;
            // 
            // txtMinDisp
            // 
            this.txtMinDisp.Location = new System.Drawing.Point(647, 200);
            this.txtMinDisp.Name = "txtMinDisp";
            this.txtMinDisp.Size = new System.Drawing.Size(66, 25);
            this.txtMinDisp.TabIndex = 26;
            // 
            // txtAvgForce
            // 
            this.txtAvgForce.Location = new System.Drawing.Point(647, 234);
            this.txtAvgForce.Name = "txtAvgForce";
            this.txtAvgForce.Size = new System.Drawing.Size(66, 25);
            this.txtAvgForce.TabIndex = 25;
            // 
            // txtMaxForce
            // 
            this.txtMaxForce.Location = new System.Drawing.Point(647, 100);
            this.txtMaxForce.Name = "txtMaxForce";
            this.txtMaxForce.Size = new System.Drawing.Size(66, 25);
            this.txtMaxForce.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(719, 234);
            this.label9.MinimumSize = new System.Drawing.Size(32, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "N";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(719, 165);
            this.label10.MinimumSize = new System.Drawing.Size(32, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "N";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(719, 200);
            this.label11.MinimumSize = new System.Drawing.Size(25, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "mm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(719, 100);
            this.label13.MinimumSize = new System.Drawing.Size(32, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "N";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(719, 135);
            this.label12.MinimumSize = new System.Drawing.Size(25, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "mm";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(591, 200);
            this.label7.MinimumSize = new System.Drawing.Size(50, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Disp.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(591, 165);
            this.label8.MinimumSize = new System.Drawing.Size(50, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Force";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(591, 135);
            this.label6.MinimumSize = new System.Drawing.Size(50, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Disp.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(591, 100);
            this.label5.MinimumSize = new System.Drawing.Size(50, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Force";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(465, 234);
            this.label4.MinimumSize = new System.Drawing.Size(120, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average Force";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(465, 165);
            this.label3.MinimumSize = new System.Drawing.Size(120, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(465, 100);
            this.label2.MinimumSize = new System.Drawing.Size(120, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 60);
            this.label2.TabIndex = 7;
            this.label2.Text = "Maximum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 67);
            this.label1.MinimumSize = new System.Drawing.Size(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPicture.Location = new System.Drawing.Point(644, 421);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(110, 39);
            this.btnSelectPicture.TabIndex = 5;
            this.btnSelectPicture.Text = "Select (Ctrl+I)";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // pbEquipment
            // 
            this.pbEquipment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbEquipment.Location = new System.Drawing.Point(465, 269);
            this.pbEquipment.Name = "pbEquipment";
            this.pbEquipment.Size = new System.Drawing.Size(289, 146);
            this.pbEquipment.TabIndex = 4;
            this.pbEquipment.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(310, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear (ESC)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chartMain
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMain.Legends.Add(legend2);
            this.chartMain.Location = new System.Drawing.Point(17, 100);
            this.chartMain.Name = "chartMain";
            this.chartMain.Size = new System.Drawing.Size(442, 358);
            this.chartMain.TabIndex = 1;
            this.chartMain.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 67);
            this.label14.MinimumSize = new System.Drawing.Size(300, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(300, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Chart of Force and Displacement";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(323, 66);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(135, 25);
            this.txtFileName.TabIndex = 31;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "DashBoard";
            this.Text = "IMADA";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DashBoard_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectForDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.PictureBox pbEquipment;
        private System.Windows.Forms.TextBox txtMaxDisp;
        private System.Windows.Forms.TextBox txtMinForce;
        private System.Windows.Forms.TextBox txtMinDisp;
        private System.Windows.Forms.TextBox txtAvgForce;
        private System.Windows.Forms.TextBox txtMaxForce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFileName;
    }
}


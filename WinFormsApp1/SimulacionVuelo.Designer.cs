﻿namespace WinFormsApp1
{
    partial class SimulacionVuelo
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
            components = new System.ComponentModel.Container();
            miPanel = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            hoverInfoLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            flightDataGridView = new DataGridView();
            label4 = new Label();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)miPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightDataGridView).BeginInit();
            SuspendLayout();
            // 
            // miPanel
            // 
            miPanel.BorderStyle = BorderStyle.FixedSingle;
            miPanel.Cursor = Cursors.Cross;
            miPanel.Location = new Point(10, 9);
            miPanel.Margin = new Padding(3, 2, 3, 2);
            miPanel.Name = "miPanel";
            miPanel.Size = new Size(700, 700);
            miPanel.TabIndex = 0;
            miPanel.TabStop = false;
            miPanel.Click += MiPanel_Click_1;
            miPanel.MouseLeave += miPanel_MouseLeave;
            miPanel.MouseHover += miPanel_MouseHover;
            miPanel.MouseMove += miPanel_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(738, 370);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 45);
            button1.TabIndex = 1;
            button1.Text = "Manual";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(738, 478);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 45);
            button2.TabIndex = 2;
            button2.Text = "Auto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(738, 433);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 28);
            button3.TabIndex = 3;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(716, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // hoverInfoLabel
            // 
            hoverInfoLabel.AutoSize = true;
            hoverInfoLabel.Location = new Point(18, 17);
            hoverInfoLabel.Name = "hoverInfoLabel";
            hoverInfoLabel.Size = new Size(38, 15);
            hoverInfoLabel.TabIndex = 5;
            hoverInfoLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(799, 62);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 6;
            label1.Text = "Datos de Vuelo";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(757, 665);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 7;
            label3.Text = "hay que definir limites";
            // 
            // flightDataGridView
            // 
            flightDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flightDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            flightDataGridView.Location = new Point(738, 92);
            flightDataGridView.Name = "flightDataGridView";
            flightDataGridView.Size = new Size(209, 149);
            flightDataGridView.TabIndex = 8;
            flightDataGridView.CellContentDoubleClick += flightDataGridView_CellContentDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(789, 335);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 9;
            label4.Text = "Chuli";
            // 
            // button4
            // 
            button4.Location = new Point(858, 425);
            button4.Name = "button4";
            button4.Size = new Size(75, 36);
            button4.TabIndex = 10;
            button4.Text = "Check";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(858, 400);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(738, 335);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 12;
            label6.Text = "STATUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(757, 680);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 13;
            label7.Text = "usar lat,lon pronto";
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(858, 467);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Fix";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // SimulacionVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 724);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(flightDataGridView);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(hoverInfoLabel);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(miPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SimulacionVuelo";
            Text = "SimulacionVuelo";
            Load += SimulacionVuelo_Load_1;
            ((System.ComponentModel.ISupportInitialize)miPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox miPanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
        private Label hoverInfoLabel;
        private Label label1;
        private Label label3;
        private DataGridView flightDataGridView;
        private Label label4;
        private Button button4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button5;
    }
}
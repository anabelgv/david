﻿namespace WinFormsApp1
{
    partial class DatosGuardados
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
            CerrarBoton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CerrarBoton
            // 
            CerrarBoton.Location = new Point(68, 58);
            CerrarBoton.Name = "CerrarBoton";
            CerrarBoton.Size = new Size(75, 23);
            CerrarBoton.TabIndex = 0;
            CerrarBoton.Text = "Cerrar";
            CerrarBoton.UseVisualStyleBackColor = true;
            CerrarBoton.Click += CerrarBoton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 201);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 30);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 2;
            label2.Text = "Datos guardados correctamente.";
            // 
            // DatosGuardados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 105);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CerrarBoton);
            Name = "DatosGuardados";
            Load += DatosGuardados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CerrarBoton;
        private Label label1;
        private Label label2;
    }
}
﻿namespace SistemaGestionUI
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_Usuario = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            PanelPrincipal = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Usuario);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 450);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 209);
            button3.Name = "button3";
            button3.Size = new Size(206, 33);
            button3.TabIndex = 3;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 176);
            button2.Name = "button2";
            button2.Size = new Size(206, 33);
            button2.TabIndex = 2;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 143);
            button1.Name = "button1";
            button1.Size = new Size(206, 33);
            button1.TabIndex = 1;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Usuario
            // 
            btn_Usuario.Dock = DockStyle.Top;
            btn_Usuario.Location = new Point(0, 110);
            btn_Usuario.Name = "btn_Usuario";
            btn_Usuario.Size = new Size(206, 33);
            btn_Usuario.TabIndex = 0;
            btn_Usuario.Text = "Usuarios";
            btn_Usuario.UseVisualStyleBackColor = true;
            btn_Usuario.Click += btn_Usuario_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 110);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(206, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 39);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(363, 9);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 0;
            label2.Text = "Sistema Gestión";
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(206, 39);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(844, 411);
            PanelPrincipal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(244, 176);
            label1.Name = "label1";
            label1.Size = new Size(363, 27);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido  a Sistema Gestión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(PanelPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Usuario;
        private Panel panel4;
        private Panel panel2;
        private Panel PanelPrincipal;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
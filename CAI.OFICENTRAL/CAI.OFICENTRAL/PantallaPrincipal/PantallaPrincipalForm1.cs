using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAI.OFICENTRAL
{
    public partial class PantallaPrincipalForm1 : Form
    {
        public PantallaPrincipalForm1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 0;
            label1.Text = "Solicitud de Materiales";
            // 
            // button1
            // 
            button1.Location = new Point(124, 49);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 1;
            button1.Text = "Solicitud de Materiales";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(124, 78);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 2;
            button2.Text = "Aprobación de Solicitudes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(124, 107);
            button3.Name = "button3";
            button3.Size = new Size(166, 23);
            button3.TabIndex = 3;
            button3.Text = "Orden de Compra";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(124, 136);
            button4.Name = "button4";
            button4.Size = new Size(166, 23);
            button4.TabIndex = 4;
            button4.Text = "Entrega de Materiales";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(124, 165);
            button5.Name = "button5";
            button5.Size = new Size(166, 23);
            button5.TabIndex = 5;
            button5.Text = "Confirmación de Recepción";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(306, 208);
            button6.Name = "button6";
            button6.Size = new Size(82, 29);
            button6.TabIndex = 6;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipalForm1
            // 
            ClientSize = new Size(420, 261);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PantallaPrincipalForm1";
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}

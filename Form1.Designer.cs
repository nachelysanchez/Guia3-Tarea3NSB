
namespace Guia3_Tarea3NSB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textcod1 = new System.Windows.Forms.TextBox();
            this.textnom1 = new System.Windows.Forms.TextBox();
            this.textape1 = new System.Windows.Forms.TextBox();
            this.textedad1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // textcod1
            // 
            this.textcod1.Location = new System.Drawing.Point(86, 28);
            this.textcod1.Name = "textcod1";
            this.textcod1.Size = new System.Drawing.Size(100, 20);
            this.textcod1.TabIndex = 4;
            // 
            // textnom1
            // 
            this.textnom1.Location = new System.Drawing.Point(86, 74);
            this.textnom1.Name = "textnom1";
            this.textnom1.Size = new System.Drawing.Size(100, 20);
            this.textnom1.TabIndex = 5;
            this.textnom1.Visible = false;
            // 
            // textape1
            // 
            this.textape1.Location = new System.Drawing.Point(86, 120);
            this.textape1.Name = "textape1";
            this.textape1.Size = new System.Drawing.Size(100, 20);
            this.textape1.TabIndex = 6;
            this.textape1.Visible = false;
            // 
            // textedad1
            // 
            this.textedad1.Location = new System.Drawing.Point(86, 166);
            this.textedad1.Name = "textedad1";
            this.textedad1.Size = new System.Drawing.Size(100, 20);
            this.textedad1.TabIndex = 7;
            this.textedad1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 254);
            this.Controls.Add(this.textedad1);
            this.Controls.Add(this.textape1);
            this.Controls.Add(this.textnom1);
            this.Controls.Add(this.textcod1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textcod1;
        private System.Windows.Forms.TextBox textnom1;
        private System.Windows.Forms.TextBox textape1;
        private System.Windows.Forms.TextBox textedad1;
    }
}


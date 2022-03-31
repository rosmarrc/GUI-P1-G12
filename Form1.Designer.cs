
namespace Calculadora_RRC
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
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_borratodo = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_res = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_signo = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_resultado
            // 
            this.txt_resultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_resultado.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_resultado.Location = new System.Drawing.Point(13, 13);
            this.txt_resultado.MaxLength = 16;
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(361, 55);
            this.txt_resultado.TabIndex = 0;
            this.txt_resultado.Text = "0";
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(14, 147);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(60, 60);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(80, 147);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(60, 60);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(146, 147);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(60, 60);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(146, 213);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(60, 60);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(80, 213);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(60, 60);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(14, 213);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(60, 60);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(146, 279);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 60);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(80, 279);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 60);
            this.btn_2.TabIndex = 8;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(14, 279);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 60);
            this.btn_1.TabIndex = 7;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(80, 345);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(60, 60);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_quitar.Location = new System.Drawing.Point(146, 81);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(60, 60);
            this.btn_quitar.TabIndex = 13;
            this.btn_quitar.Text = "←";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_borratodo
            // 
            this.btn_borratodo.Font = new System.Drawing.Font("Odin Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borratodo.Location = new System.Drawing.Point(80, 81);
            this.btn_borratodo.Name = "btn_borratodo";
            this.btn_borratodo.Size = new System.Drawing.Size(60, 60);
            this.btn_borratodo.TabIndex = 12;
            this.btn_borratodo.Text = "C";
            this.btn_borratodo.UseVisualStyleBackColor = true;
            this.btn_borratodo.Click += new System.EventHandler(this.btn_borratodo_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Font = new System.Drawing.Font("Odin Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.Location = new System.Drawing.Point(14, 81);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(60, 60);
            this.btn_borrar.TabIndex = 11;
            this.btn_borrar.Text = "CE";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sum.Location = new System.Drawing.Point(248, 81);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(60, 60);
            this.btn_sum.TabIndex = 17;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_div.Location = new System.Drawing.Point(314, 147);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(60, 60);
            this.btn_div.TabIndex = 16;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_mult
            // 
            this.btn_mult.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mult.Location = new System.Drawing.Point(248, 147);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(60, 60);
            this.btn_mult.TabIndex = 15;
            this.btn_mult.Text = "x";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_res
            // 
            this.btn_res.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_res.Location = new System.Drawing.Point(314, 81);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(60, 60);
            this.btn_res.TabIndex = 14;
            this.btn_res.Text = "-";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_punto
            // 
            this.btn_punto.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_punto.Location = new System.Drawing.Point(146, 345);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(60, 60);
            this.btn_punto.TabIndex = 18;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = true;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_signo
            // 
            this.btn_signo.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signo.Location = new System.Drawing.Point(14, 345);
            this.btn_signo.Name = "btn_signo";
            this.btn_signo.Size = new System.Drawing.Size(60, 60);
            this.btn_signo.TabIndex = 19;
            this.btn_signo.Text = "±";
            this.btn_signo.UseVisualStyleBackColor = true;
            this.btn_signo.Click += new System.EventHandler(this.btn_signo_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Font = new System.Drawing.Font("Odin Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_igual.Location = new System.Drawing.Point(248, 213);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(126, 60);
            this.btn_igual.TabIndex = 20;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(387, 414);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_signo);
            this.Controls.Add(this.btn_punto);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_borratodo);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.txt_resultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora RRC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_borratodo;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_signo;
        private System.Windows.Forms.Button btn_igual;
    }
}


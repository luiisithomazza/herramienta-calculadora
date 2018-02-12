namespace Calculadora_de_Horas
{
    partial class calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.numigual = new System.Windows.Forms.Button();
            this.nummas = new System.Windows.Forms.Button();
            this.nummenos = new System.Windows.Forms.Button();
            this.numpor = new System.Windows.Forms.Button();
            this.numentre = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.TextBox();
            this.pago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.extra = new System.Windows.Forms.Label();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CALCULAR
            // 
            this.CALCULAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CALCULAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CALCULAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CALCULAR.Location = new System.Drawing.Point(195, 152);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(100, 32);
            this.CALCULAR.TabIndex = 36;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = false;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // numigual
            // 
            this.numigual.BackColor = System.Drawing.Color.Green;
            this.numigual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numigual.Location = new System.Drawing.Point(466, 228);
            this.numigual.Name = "numigual";
            this.numigual.Size = new System.Drawing.Size(117, 32);
            this.numigual.TabIndex = 35;
            this.numigual.Text = "=";
            this.numigual.UseVisualStyleBackColor = false;
            // 
            // nummas
            // 
            this.nummas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nummas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nummas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nummas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nummas.Location = new System.Drawing.Point(527, 190);
            this.nummas.Name = "nummas";
            this.nummas.Size = new System.Drawing.Size(56, 32);
            this.nummas.TabIndex = 34;
            this.nummas.Text = "+";
            this.nummas.UseVisualStyleBackColor = false;
            // 
            // nummenos
            // 
            this.nummenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nummenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nummenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nummenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummenos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nummenos.Location = new System.Drawing.Point(527, 152);
            this.nummenos.Name = "nummenos";
            this.nummenos.Size = new System.Drawing.Size(56, 32);
            this.nummenos.TabIndex = 33;
            this.nummenos.Text = "-";
            this.nummenos.UseVisualStyleBackColor = false;
            // 
            // numpor
            // 
            this.numpor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numpor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numpor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numpor.Location = new System.Drawing.Point(527, 114);
            this.numpor.Name = "numpor";
            this.numpor.Size = new System.Drawing.Size(56, 32);
            this.numpor.TabIndex = 32;
            this.numpor.Text = "X";
            this.numpor.UseVisualStyleBackColor = false;
            // 
            // numentre
            // 
            this.numentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numentre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numentre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numentre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numentre.Location = new System.Drawing.Point(527, 76);
            this.numentre.Name = "numentre";
            this.numentre.Size = new System.Drawing.Size(56, 32);
            this.numentre.TabIndex = 31;
            this.numentre.Text = "/";
            this.numentre.UseVisualStyleBackColor = false;
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num0.Location = new System.Drawing.Point(341, 228);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(57, 32);
            this.num0.TabIndex = 30;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num.Location = new System.Drawing.Point(404, 228);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(56, 32);
            this.num.TabIndex = 29;
            this.num.Text = ",";
            this.num.UseVisualStyleBackColor = false;
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num9.Location = new System.Drawing.Point(465, 114);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(56, 32);
            this.num9.TabIndex = 28;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num8.Location = new System.Drawing.Point(403, 114);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(56, 32);
            this.num8.TabIndex = 27;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num7.Location = new System.Drawing.Point(341, 114);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(56, 32);
            this.num7.TabIndex = 26;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click_1);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num6.Location = new System.Drawing.Point(465, 152);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(56, 32);
            this.num6.TabIndex = 25;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num5.Location = new System.Drawing.Point(403, 152);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(56, 32);
            this.num5.TabIndex = 24;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num4.Location = new System.Drawing.Point(341, 152);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(56, 32);
            this.num4.TabIndex = 23;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num3.Location = new System.Drawing.Point(465, 190);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(56, 32);
            this.num3.TabIndex = 22;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num2.Location = new System.Drawing.Point(403, 190);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(56, 32);
            this.num2.TabIndex = 21;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num1.Location = new System.Drawing.Point(341, 190);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(56, 32);
            this.num1.TabIndex = 20;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total de Horas";
            // 
            // horas
            // 
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.Location = new System.Drawing.Point(195, 32);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(100, 31);
            this.horas.TabIndex = 38;
            // 
            // pago
            // 
            this.pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago.Location = new System.Drawing.Point(195, 69);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(100, 31);
            this.pago.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Pago por Horas";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(195, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 40);
            this.textBox1.TabIndex = 44;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(20, 213);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(169, 33);
            this.total.TabIndex = 43;
            this.total.Text = "Su pago es:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(195, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 42;
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra.Location = new System.Drawing.Point(98, 109);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(101, 25);
            this.extra.TabIndex = 41;
            this.extra.Text = "Hrs Extra";
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(341, 25);
            this.pantalla.Name = "pantalla";
            this.pantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pantalla.Size = new System.Drawing.Size(242, 40);
            this.pantalla.TabIndex = 45;
            this.pantalla.Text = "0";
            this.pantalla.TextChanged += new System.EventHandler(this.pantalla_TextChanged);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CE.Location = new System.Drawing.Point(341, 76);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(56, 32);
            this.CE.TabIndex = 46;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "label4";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.extra);
            this.Controls.Add(this.pago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.numigual);
            this.Controls.Add(this.nummas);
            this.Controls.Add(this.nummenos);
            this.Controls.Add(this.numpor);
            this.Controls.Add(this.numentre);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "calculadora";
            this.Text = "Pago de Horas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button numigual;
        private System.Windows.Forms.Button nummas;
        private System.Windows.Forms.Button nummenos;
        private System.Windows.Forms.Button numpor;
        private System.Windows.Forms.Button numentre;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox horas;
        private System.Windows.Forms.TextBox pago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label extra;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


namespace Lab7
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hist = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.multiplica = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "CalculadoraView";
            this.panel1.Controls.Add(this.hist);
            this.panel1.Controls.Add(this.pantalla);
            this.panel1.Controls.Add(this.ocho);
            this.panel1.Controls.Add(this.nueve);
            this.panel1.Controls.Add(this.AC);
            this.panel1.Controls.Add(this.seis);
            this.panel1.Controls.Add(this.cuatro);
            this.panel1.Controls.Add(this.cero);
            this.panel1.Controls.Add(this.punto);
            this.panel1.Controls.Add(this.Ans);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.igual);
            this.panel1.Controls.Add(this.uno);
            this.panel1.Controls.Add(this.DEL);
            this.panel1.Controls.Add(this.dos);
            this.panel1.Controls.Add(this.tres);
            this.panel1.Controls.Add(this.resta);
            this.panel1.Controls.Add(this.suma);
            this.panel1.Controls.Add(this.multiplica);
            this.panel1.Controls.Add(this.cinco);
            this.panel1.Controls.Add(this.siete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 219);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hist
            // 
            this.hist.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.hist.Location = new System.Drawing.Point(9, 185);
            this.hist.Name = "hist";
            this.hist.Size = new System.Drawing.Size(66, 26);
            this.hist.TabIndex = 20;
            this.hist.Text = "Historial";
            this.hist.UseVisualStyleBackColor = true;
            this.hist.Click += new System.EventHandler(this.hist_Click);
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(9, 26);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(213, 20);
            this.pantalla.TabIndex = 19;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ocho
            // 
            this.ocho.Location = new System.Drawing.Point(47, 64);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(40, 26);
            this.ocho.TabIndex = 18;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // nueve
            // 
            this.nueve.Location = new System.Drawing.Point(93, 64);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(40, 26);
            this.nueve.TabIndex = 17;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(185, 63);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(40, 26);
            this.AC.TabIndex = 16;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(93, 96);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(40, 26);
            this.seis.TabIndex = 15;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cuatro
            // 
            this.cuatro.Location = new System.Drawing.Point(9, 96);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(35, 26);
            this.cuatro.TabIndex = 14;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(9, 153);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(35, 26);
            this.cero.TabIndex = 13;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // punto
            // 
            this.punto.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.punto.Location = new System.Drawing.Point(47, 153);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(40, 26);
            this.punto.TabIndex = 12;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(139, 153);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(40, 26);
            this.Ans.TabIndex = 11;
            this.Ans.Text = "Ans";
            this.Ans.UseVisualStyleBackColor = true;
            this.Ans.Click += new System.EventHandler(this.Ans_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(185, 96);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(40, 26);
            this.divide.TabIndex = 10;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(185, 153);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(40, 26);
            this.igual.TabIndex = 9;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(9, 125);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(35, 26);
            this.uno.TabIndex = 8;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(139, 63);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(40, 26);
            this.DEL.TabIndex = 7;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // dos
            // 
            this.dos.Location = new System.Drawing.Point(47, 125);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(40, 26);
            this.dos.TabIndex = 6;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(93, 125);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(40, 26);
            this.tres.TabIndex = 5;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(185, 125);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(40, 26);
            this.resta.TabIndex = 4;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(139, 125);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(40, 26);
            this.suma.TabIndex = 3;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // multiplica
            // 
            this.multiplica.Location = new System.Drawing.Point(139, 96);
            this.multiplica.Name = "multiplica";
            this.multiplica.Size = new System.Drawing.Size(40, 26);
            this.multiplica.TabIndex = 2;
            this.multiplica.Text = "x";
            this.multiplica.UseVisualStyleBackColor = true;
            this.multiplica.Click += new System.EventHandler(this.multiplica_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(47, 96);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(40, 26);
            this.cinco.TabIndex = 1;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // siete
            // 
            this.siete.Location = new System.Drawing.Point(9, 64);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(35, 26);
            this.siete.TabIndex = 0;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 219);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button Ans;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button multiplica;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button hist;
    }
}


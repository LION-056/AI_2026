namespace AI_2026
{
    partial class FRMOchoPuzzle
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
            this.LBL00 = new System.Windows.Forms.Label();
            this.LBL01 = new System.Windows.Forms.Label();
            this.LBL02 = new System.Windows.Forms.Label();
            this.LBL20 = new System.Windows.Forms.Label();
            this.LBL11 = new System.Windows.Forms.Label();
            this.LBL12 = new System.Windows.Forms.Label();
            this.LBL10 = new System.Windows.Forms.Label();
            this.LBL21 = new System.Windows.Forms.Label();
            this.LBL22 = new System.Windows.Forms.Label();
            this.BTNDesordenar = new System.Windows.Forms.Button();
            this.TMRReloj = new System.Windows.Forms.Timer(this.components);
            this.LBLContador = new System.Windows.Forms.Label();
            this.BTNGenerarHijos = new System.Windows.Forms.Button();
            this.BTNEsFinal = new System.Windows.Forms.Button();
            this.BTNAnchuraPrioritaria = new System.Windows.Forms.Button();
            this.TMRSolucion = new System.Windows.Forms.Timer(this.components);
            this.BTNProfundidadLimitada = new System.Windows.Forms.Button();
            this.NUDLimitada = new System.Windows.Forms.NumericUpDown();
            this.BTNProfundidadIterativa = new System.Windows.Forms.Button();
            this.NUDLimitadaIterativa = new System.Windows.Forms.NumericUpDown();
            this.BTNH1 = new System.Windows.Forms.Button();
            this.BTNH2 = new System.Windows.Forms.Button();
            this.BTNH3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLimitada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLimitadaIterativa)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL00
            // 
            this.LBL00.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL00.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL00.Location = new System.Drawing.Point(12, 9);
            this.LBL00.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL00.Name = "LBL00";
            this.LBL00.Size = new System.Drawing.Size(130, 130);
            this.LBL00.TabIndex = 0;
            this.LBL00.Text = "1";
            this.LBL00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL00.Click += new System.EventHandler(this.LBL00_Click);
            // 
            // LBL01
            // 
            this.LBL01.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL01.Location = new System.Drawing.Point(151, 9);
            this.LBL01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL01.Name = "LBL01";
            this.LBL01.Size = new System.Drawing.Size(130, 130);
            this.LBL01.TabIndex = 1;
            this.LBL01.Text = "2";
            this.LBL01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL01.Click += new System.EventHandler(this.LBL01_Click);
            // 
            // LBL02
            // 
            this.LBL02.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL02.Location = new System.Drawing.Point(290, 9);
            this.LBL02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL02.Name = "LBL02";
            this.LBL02.Size = new System.Drawing.Size(130, 130);
            this.LBL02.TabIndex = 2;
            this.LBL02.Text = "3";
            this.LBL02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL02.Click += new System.EventHandler(this.LBL02_Click);
            // 
            // LBL20
            // 
            this.LBL20.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL20.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL20.Location = new System.Drawing.Point(12, 289);
            this.LBL20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL20.Name = "LBL20";
            this.LBL20.Size = new System.Drawing.Size(130, 130);
            this.LBL20.TabIndex = 3;
            this.LBL20.Text = "7";
            this.LBL20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL20.Click += new System.EventHandler(this.LBL20_Click);
            // 
            // LBL11
            // 
            this.LBL11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL11.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL11.Location = new System.Drawing.Point(151, 150);
            this.LBL11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL11.Name = "LBL11";
            this.LBL11.Size = new System.Drawing.Size(130, 130);
            this.LBL11.TabIndex = 4;
            this.LBL11.Text = "0";
            this.LBL11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL11.Click += new System.EventHandler(this.LBL11_Click);
            // 
            // LBL12
            // 
            this.LBL12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL12.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL12.Location = new System.Drawing.Point(290, 150);
            this.LBL12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL12.Name = "LBL12";
            this.LBL12.Size = new System.Drawing.Size(130, 130);
            this.LBL12.TabIndex = 5;
            this.LBL12.Text = "4";
            this.LBL12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL12.Click += new System.EventHandler(this.LBL12_Click);
            // 
            // LBL10
            // 
            this.LBL10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL10.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL10.Location = new System.Drawing.Point(12, 150);
            this.LBL10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL10.Name = "LBL10";
            this.LBL10.Size = new System.Drawing.Size(130, 130);
            this.LBL10.TabIndex = 6;
            this.LBL10.Text = "8";
            this.LBL10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL10.Click += new System.EventHandler(this.LBL10_Click);
            // 
            // LBL21
            // 
            this.LBL21.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL21.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL21.Location = new System.Drawing.Point(151, 289);
            this.LBL21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL21.Name = "LBL21";
            this.LBL21.Size = new System.Drawing.Size(130, 130);
            this.LBL21.TabIndex = 7;
            this.LBL21.Text = "6";
            this.LBL21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL21.Click += new System.EventHandler(this.LBL21_Click);
            // 
            // LBL22
            // 
            this.LBL22.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL22.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL22.Location = new System.Drawing.Point(290, 289);
            this.LBL22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL22.Name = "LBL22";
            this.LBL22.Size = new System.Drawing.Size(130, 130);
            this.LBL22.TabIndex = 8;
            this.LBL22.Text = "5";
            this.LBL22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL22.Click += new System.EventHandler(this.LBL22_Click);
            // 
            // BTNDesordenar
            // 
            this.BTNDesordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDesordenar.Location = new System.Drawing.Point(440, 9);
            this.BTNDesordenar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNDesordenar.Name = "BTNDesordenar";
            this.BTNDesordenar.Size = new System.Drawing.Size(130, 45);
            this.BTNDesordenar.TabIndex = 9;
            this.BTNDesordenar.Text = "Desordenar";
            this.BTNDesordenar.UseVisualStyleBackColor = true;
            this.BTNDesordenar.Click += new System.EventHandler(this.BTNDesordenar_Click);
            // 
            // TMRReloj
            // 
            this.TMRReloj.Tick += new System.EventHandler(this.TMRReloj_Tick);
            // 
            // LBLContador
            // 
            this.LBLContador.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBLContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContador.Location = new System.Drawing.Point(442, 57);
            this.LBLContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLContador.Name = "LBLContador";
            this.LBLContador.Size = new System.Drawing.Size(128, 100);
            this.LBLContador.TabIndex = 10;
            this.LBLContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNGenerarHijos
            // 
            this.BTNGenerarHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGenerarHijos.Location = new System.Drawing.Point(440, 211);
            this.BTNGenerarHijos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNGenerarHijos.Name = "BTNGenerarHijos";
            this.BTNGenerarHijos.Size = new System.Drawing.Size(130, 45);
            this.BTNGenerarHijos.TabIndex = 11;
            this.BTNGenerarHijos.Text = "Generar Hijos";
            this.BTNGenerarHijos.UseVisualStyleBackColor = true;
            this.BTNGenerarHijos.Click += new System.EventHandler(this.BTNGenerarHijos_Click);
            // 
            // BTNEsFinal
            // 
            this.BTNEsFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEsFinal.Location = new System.Drawing.Point(440, 160);
            this.BTNEsFinal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNEsFinal.Name = "BTNEsFinal";
            this.BTNEsFinal.Size = new System.Drawing.Size(130, 45);
            this.BTNEsFinal.TabIndex = 12;
            this.BTNEsFinal.Text = "Es Final";
            this.BTNEsFinal.UseVisualStyleBackColor = true;
            this.BTNEsFinal.Click += new System.EventHandler(this.BTNEsFinal_Click);
            // 
            // BTNAnchuraPrioritaria
            // 
            this.BTNAnchuraPrioritaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAnchuraPrioritaria.Location = new System.Drawing.Point(440, 262);
            this.BTNAnchuraPrioritaria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNAnchuraPrioritaria.Name = "BTNAnchuraPrioritaria";
            this.BTNAnchuraPrioritaria.Size = new System.Drawing.Size(130, 50);
            this.BTNAnchuraPrioritaria.TabIndex = 13;
            this.BTNAnchuraPrioritaria.Text = "Anchura Prioritaria";
            this.BTNAnchuraPrioritaria.UseVisualStyleBackColor = true;
            this.BTNAnchuraPrioritaria.Click += new System.EventHandler(this.BTNAnchuraPrioritaria_Click);
            // 
            // TMRSolucion
            // 
            this.TMRSolucion.Interval = 500;
            this.TMRSolucion.Tick += new System.EventHandler(this.TMRSolucion_Tick);
            // 
            // BTNProfundidadLimitada
            // 
            this.BTNProfundidadLimitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProfundidadLimitada.Location = new System.Drawing.Point(440, 318);
            this.BTNProfundidadLimitada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNProfundidadLimitada.Name = "BTNProfundidadLimitada";
            this.BTNProfundidadLimitada.Size = new System.Drawing.Size(130, 50);
            this.BTNProfundidadLimitada.TabIndex = 14;
            this.BTNProfundidadLimitada.Text = "Profundidad Limitada";
            this.BTNProfundidadLimitada.UseVisualStyleBackColor = true;
            this.BTNProfundidadLimitada.Click += new System.EventHandler(this.BTNProfundidadLimitada_Click);
            // 
            // NUDLimitada
            // 
            this.NUDLimitada.Location = new System.Drawing.Point(574, 336);
            this.NUDLimitada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NUDLimitada.Name = "NUDLimitada";
            this.NUDLimitada.Size = new System.Drawing.Size(53, 20);
            this.NUDLimitada.TabIndex = 15;
            this.NUDLimitada.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // BTNProfundidadIterativa
            // 
            this.BTNProfundidadIterativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProfundidadIterativa.Location = new System.Drawing.Point(440, 374);
            this.BTNProfundidadIterativa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNProfundidadIterativa.Name = "BTNProfundidadIterativa";
            this.BTNProfundidadIterativa.Size = new System.Drawing.Size(130, 50);
            this.BTNProfundidadIterativa.TabIndex = 16;
            this.BTNProfundidadIterativa.Text = "Profundidad Iterativa";
            this.BTNProfundidadIterativa.UseVisualStyleBackColor = true;
            this.BTNProfundidadIterativa.Click += new System.EventHandler(this.BTNProfundidadIterativa_Click);
            // 
            // NUDLimitadaIterativa
            // 
            this.NUDLimitadaIterativa.Location = new System.Drawing.Point(574, 392);
            this.NUDLimitadaIterativa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NUDLimitadaIterativa.Name = "NUDLimitadaIterativa";
            this.NUDLimitadaIterativa.Size = new System.Drawing.Size(53, 20);
            this.NUDLimitadaIterativa.TabIndex = 17;
            this.NUDLimitadaIterativa.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // BTNH1
            // 
            this.BTNH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNH1.Location = new System.Drawing.Point(574, 9);
            this.BTNH1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNH1.Name = "BTNH1";
            this.BTNH1.Size = new System.Drawing.Size(77, 45);
            this.BTNH1.TabIndex = 18;
            this.BTNH1.Text = "H1";
            this.BTNH1.UseVisualStyleBackColor = true;
            this.BTNH1.Click += new System.EventHandler(this.BTNH1_Click_1);
            // 
            // BTNH2
            // 
            this.BTNH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNH2.Location = new System.Drawing.Point(574, 60);
            this.BTNH2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNH2.Name = "BTNH2";
            this.BTNH2.Size = new System.Drawing.Size(77, 45);
            this.BTNH2.TabIndex = 19;
            this.BTNH2.Text = "H2";
            this.BTNH2.UseVisualStyleBackColor = true;
            this.BTNH2.Click += new System.EventHandler(this.BTNH2_Click_1);
            // 
            // BTNH3
            // 
            this.BTNH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNH3.Location = new System.Drawing.Point(574, 111);
            this.BTNH3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNH3.Name = "BTNH3";
            this.BTNH3.Size = new System.Drawing.Size(77, 45);
            this.BTNH3.TabIndex = 20;
            this.BTNH3.Text = "H3";
            this.BTNH3.UseVisualStyleBackColor = true;
            this.BTNH3.Click += new System.EventHandler(this.BTNH3_Click_1);
            // 
            // FRMOchoPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.BTNH3);
            this.Controls.Add(this.BTNH2);
            this.Controls.Add(this.BTNH1);
            this.Controls.Add(this.NUDLimitadaIterativa);
            this.Controls.Add(this.BTNProfundidadIterativa);
            this.Controls.Add(this.NUDLimitada);
            this.Controls.Add(this.BTNProfundidadLimitada);
            this.Controls.Add(this.BTNAnchuraPrioritaria);
            this.Controls.Add(this.BTNEsFinal);
            this.Controls.Add(this.BTNGenerarHijos);
            this.Controls.Add(this.LBLContador);
            this.Controls.Add(this.BTNDesordenar);
            this.Controls.Add(this.LBL22);
            this.Controls.Add(this.LBL21);
            this.Controls.Add(this.LBL10);
            this.Controls.Add(this.LBL12);
            this.Controls.Add(this.LBL11);
            this.Controls.Add(this.LBL20);
            this.Controls.Add(this.LBL02);
            this.Controls.Add(this.LBL01);
            this.Controls.Add(this.LBL00);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FRMOchoPuzzle";
            this.Text = "8 Puzzle";
            ((System.ComponentModel.ISupportInitialize)(this.NUDLimitada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLimitadaIterativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL00;
        private System.Windows.Forms.Label LBL01;
        private System.Windows.Forms.Label LBL02;
        private System.Windows.Forms.Label LBL20;
        private System.Windows.Forms.Label LBL11;
        private System.Windows.Forms.Label LBL12;
        private System.Windows.Forms.Label LBL10;
        private System.Windows.Forms.Label LBL21;
        private System.Windows.Forms.Label LBL22;
        private System.Windows.Forms.Button BTNDesordenar;
        private System.Windows.Forms.Timer TMRReloj;
        private System.Windows.Forms.Label LBLContador;
        private System.Windows.Forms.Button BTNGenerarHijos;
        private System.Windows.Forms.Button BTNEsFinal;
        private System.Windows.Forms.Button BTNAnchuraPrioritaria;
        private System.Windows.Forms.Timer TMRSolucion;
        private System.Windows.Forms.Button BTNProfundidadLimitada;
        private System.Windows.Forms.NumericUpDown NUDLimitada;
        private System.Windows.Forms.Button BTNProfundidadIterativa;
        private System.Windows.Forms.NumericUpDown NUDLimitadaIterativa;
        private System.Windows.Forms.Button BTNH1;
        private System.Windows.Forms.Button BTNH2;
        private System.Windows.Forms.Button BTNH3;
    }
}


namespace Aplicativo_Cotações
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_USD = new System.Windows.Forms.Button();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ValorConvertido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_EUR = new System.Windows.Forms.Button();
            this.btn_GBP = new System.Windows.Forms.Button();
            this.btn_AUD = new System.Windows.Forms.Button();
            this.btn_CAD = new System.Windows.Forms.Button();
            this.btn_ARS = new System.Windows.Forms.Button();
            this.btn_BTC = new System.Windows.Forms.Button();
            this.btn_CNY = new System.Windows.Forms.Button();
            this.btn_JPY = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_USD
            // 
            this.btn_USD.BackColor = System.Drawing.Color.Transparent;
            this.btn_USD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_USD.BackgroundImage")));
            this.btn_USD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_USD.FlatAppearance.BorderSize = 0;
            this.btn_USD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_USD.ForeColor = System.Drawing.Color.Black;
            this.btn_USD.Location = new System.Drawing.Point(12, 186);
            this.btn_USD.Name = "btn_USD";
            this.btn_USD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_USD.Size = new System.Drawing.Size(63, 65);
            this.btn_USD.TabIndex = 0;
            this.btn_USD.Text = "USD";
            this.btn_USD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_USD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_USD.UseVisualStyleBackColor = false;
            this.btn_USD.Click += new System.EventHandler(this.btn_USD_Click);
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(51, 73);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(88, 30);
            this.tb_valor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Valor a Ser Convertido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione A Moeda";
            // 
            // lb_ValorConvertido
            // 
            this.lb_ValorConvertido.AutoSize = true;
            this.lb_ValorConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorConvertido.Location = new System.Drawing.Point(161, 80);
            this.lb_ValorConvertido.Name = "lb_ValorConvertido";
            this.lb_ValorConvertido.Size = new System.Drawing.Size(123, 20);
            this.lb_ValorConvertido.TabIndex = 4;
            this.lb_ValorConvertido.Text = "Valor convertido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "R$";
            // 
            // btn_EUR
            // 
            this.btn_EUR.BackColor = System.Drawing.Color.Transparent;
            this.btn_EUR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EUR.BackgroundImage")));
            this.btn_EUR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EUR.FlatAppearance.BorderSize = 0;
            this.btn_EUR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_EUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EUR.ForeColor = System.Drawing.Color.Transparent;
            this.btn_EUR.Location = new System.Drawing.Point(116, 186);
            this.btn_EUR.Name = "btn_EUR";
            this.btn_EUR.Size = new System.Drawing.Size(63, 65);
            this.btn_EUR.TabIndex = 6;
            this.btn_EUR.Text = "EUR";
            this.btn_EUR.UseVisualStyleBackColor = false;
            this.btn_EUR.Click += new System.EventHandler(this.btn_EUR_Click);
            // 
            // btn_GBP
            // 
            this.btn_GBP.BackColor = System.Drawing.Color.Transparent;
            this.btn_GBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GBP.BackgroundImage")));
            this.btn_GBP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GBP.FlatAppearance.BorderSize = 0;
            this.btn_GBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GBP.ForeColor = System.Drawing.Color.Transparent;
            this.btn_GBP.Location = new System.Drawing.Point(220, 186);
            this.btn_GBP.Name = "btn_GBP";
            this.btn_GBP.Size = new System.Drawing.Size(63, 65);
            this.btn_GBP.TabIndex = 7;
            this.btn_GBP.Text = "GBP";
            this.btn_GBP.UseVisualStyleBackColor = false;
            this.btn_GBP.Click += new System.EventHandler(this.btn_GBP_Click);
            // 
            // btn_AUD
            // 
            this.btn_AUD.BackColor = System.Drawing.Color.Transparent;
            this.btn_AUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AUD.BackgroundImage")));
            this.btn_AUD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AUD.FlatAppearance.BorderSize = 0;
            this.btn_AUD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AUD.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AUD.Location = new System.Drawing.Point(220, 292);
            this.btn_AUD.Name = "btn_AUD";
            this.btn_AUD.Size = new System.Drawing.Size(63, 65);
            this.btn_AUD.TabIndex = 10;
            this.btn_AUD.Text = "AUD";
            this.btn_AUD.UseVisualStyleBackColor = false;
            this.btn_AUD.Click += new System.EventHandler(this.btn_AUD_Click);
            // 
            // btn_CAD
            // 
            this.btn_CAD.BackColor = System.Drawing.Color.Transparent;
            this.btn_CAD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CAD.BackgroundImage")));
            this.btn_CAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CAD.FlatAppearance.BorderSize = 0;
            this.btn_CAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CAD.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CAD.Location = new System.Drawing.Point(116, 292);
            this.btn_CAD.Name = "btn_CAD";
            this.btn_CAD.Size = new System.Drawing.Size(63, 65);
            this.btn_CAD.TabIndex = 9;
            this.btn_CAD.Text = "CAD";
            this.btn_CAD.UseVisualStyleBackColor = false;
            this.btn_CAD.Click += new System.EventHandler(this.btn_CAD_Click);
            // 
            // btn_ARS
            // 
            this.btn_ARS.BackColor = System.Drawing.Color.Transparent;
            this.btn_ARS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ARS.BackgroundImage")));
            this.btn_ARS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ARS.FlatAppearance.BorderSize = 0;
            this.btn_ARS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ARS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ARS.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ARS.Location = new System.Drawing.Point(12, 292);
            this.btn_ARS.Name = "btn_ARS";
            this.btn_ARS.Size = new System.Drawing.Size(63, 65);
            this.btn_ARS.TabIndex = 8;
            this.btn_ARS.Text = "ARS";
            this.btn_ARS.UseVisualStyleBackColor = false;
            this.btn_ARS.Click += new System.EventHandler(this.btn_ARS_Click);
            // 
            // btn_BTC
            // 
            this.btn_BTC.BackColor = System.Drawing.Color.Transparent;
            this.btn_BTC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BTC.BackgroundImage")));
            this.btn_BTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BTC.FlatAppearance.BorderSize = 0;
            this.btn_BTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BTC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_BTC.Location = new System.Drawing.Point(220, 400);
            this.btn_BTC.Name = "btn_BTC";
            this.btn_BTC.Size = new System.Drawing.Size(63, 54);
            this.btn_BTC.TabIndex = 13;
            this.btn_BTC.Text = "BTC";
            this.btn_BTC.UseVisualStyleBackColor = false;
            this.btn_BTC.Click += new System.EventHandler(this.btn_BTC_Click);
            // 
            // btn_CNY
            // 
            this.btn_CNY.BackColor = System.Drawing.Color.Transparent;
            this.btn_CNY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CNY.BackgroundImage")));
            this.btn_CNY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CNY.FlatAppearance.BorderSize = 0;
            this.btn_CNY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CNY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CNY.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CNY.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CNY.Location = new System.Drawing.Point(116, 400);
            this.btn_CNY.Name = "btn_CNY";
            this.btn_CNY.Size = new System.Drawing.Size(63, 65);
            this.btn_CNY.TabIndex = 12;
            this.btn_CNY.Text = "CNY";
            this.btn_CNY.UseVisualStyleBackColor = false;
            this.btn_CNY.Click += new System.EventHandler(this.btn_CNY_Click);
            // 
            // btn_JPY
            // 
            this.btn_JPY.BackColor = System.Drawing.Color.Transparent;
            this.btn_JPY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_JPY.BackgroundImage")));
            this.btn_JPY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JPY.FlatAppearance.BorderSize = 0;
            this.btn_JPY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_JPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JPY.ForeColor = System.Drawing.Color.Transparent;
            this.btn_JPY.Location = new System.Drawing.Point(12, 400);
            this.btn_JPY.Name = "btn_JPY";
            this.btn_JPY.Size = new System.Drawing.Size(63, 65);
            this.btn_JPY.TabIndex = 11;
            this.btn_JPY.Text = "JPY";
            this.btn_JPY.UseVisualStyleBackColor = false;
            this.btn_JPY.Click += new System.EventHandler(this.btn_JPY_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "USD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "EUR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "GBP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "ARS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "CAD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "AUD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "JPY";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "CNY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(231, 457);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "BTC";
            // 
            // lb_debug
            // 
            this.lb_debug.AutoSize = true;
            this.lb_debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_debug.ForeColor = System.Drawing.Color.Red;
            this.lb_debug.Location = new System.Drawing.Point(20, 117);
            this.lb_debug.Name = "lb_debug";
            this.lb_debug.Size = new System.Drawing.Size(0, 20);
            this.lb_debug.TabIndex = 23;
            this.lb_debug.Click += new System.EventHandler(this.label3_Click);
            // 
            // F_Principal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(307, 496);
            this.Controls.Add(this.lb_debug);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_BTC);
            this.Controls.Add(this.btn_CNY);
            this.Controls.Add(this.btn_JPY);
            this.Controls.Add(this.btn_AUD);
            this.Controls.Add(this.btn_CAD);
            this.Controls.Add(this.btn_ARS);
            this.Controls.Add(this.btn_GBP);
            this.Controls.Add(this.btn_EUR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_ValorConvertido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.btn_USD);
            this.Name = "F_Principal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo de Cotação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_USD;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ValorConvertido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_EUR;
        private System.Windows.Forms.Button btn_GBP;
        private System.Windows.Forms.Button btn_AUD;
        private System.Windows.Forms.Button btn_CAD;
        private System.Windows.Forms.Button btn_ARS;
        private System.Windows.Forms.Button btn_BTC;
        private System.Windows.Forms.Button btn_CNY;
        private System.Windows.Forms.Button btn_JPY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_debug;
    }
}


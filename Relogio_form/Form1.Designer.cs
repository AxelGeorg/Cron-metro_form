namespace Relogio_form
{
    partial class form_cronometro
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
            this.components = new System.ComponentModel.Container();
            this.lbl_data = new System.Windows.Forms.Label();
            this.timerDataTime = new System.Windows.Forms.Timer(this.components);
            this.lbl_horario = new System.Windows.Forms.Label();
            this.lbl_cronometro = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_zerar = new System.Windows.Forms.Button();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(725, 22);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(28, 13);
            this.lbl_data.TabIndex = 8;
            this.lbl_data.Text = "data";
            // 
            // timerDataTime
            // 
            this.timerDataTime.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(734, 47);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(39, 13);
            this.lbl_horario.TabIndex = 9;
            this.lbl_horario.Text = "horario";
            // 
            // lbl_cronometro
            // 
            this.lbl_cronometro.AutoSize = true;
            this.lbl_cronometro.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cronometro.Location = new System.Drawing.Point(195, 116);
            this.lbl_cronometro.Name = "lbl_cronometro";
            this.lbl_cronometro.Size = new System.Drawing.Size(412, 64);
            this.lbl_cronometro.TabIndex = 10;
            this.lbl_cronometro.Text = "00:00:00.000";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(147, 249);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(129, 29);
            this.btn_iniciar.TabIndex = 11;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(332, 250);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(129, 28);
            this.btn_parar.TabIndex = 12;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_zerar
            // 
            this.btn_zerar.Location = new System.Drawing.Point(520, 250);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(129, 28);
            this.btn_zerar.TabIndex = 13;
            this.btn_zerar.Text = "Zerar";
            this.btn_zerar.UseVisualStyleBackColor = true;
            this.btn_zerar.Click += new System.EventHandler(this.btn_zerar_Click);
            // 
            // timerCronometro
            // 
            this.timerCronometro.Tick += new System.EventHandler(this.timerCronometro_Tick);
            // 
            // form_cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_zerar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_cronometro);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.lbl_data);
            this.Name = "form_cronometro";
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer timerDataTime;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.Label lbl_cronometro;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_zerar;
        private System.Windows.Forms.Timer timerCronometro;
    }
}


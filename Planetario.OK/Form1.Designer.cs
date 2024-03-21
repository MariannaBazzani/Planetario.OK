namespace Planetario.OK
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstPianeti = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tiktak = new System.Windows.Forms.Timer(this.components);
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.txtVelocita = new System.Windows.Forms.TextBox();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.Velocita = new System.Windows.Forms.Label();
            this.Posizione = new System.Windows.Forms.Label();
            this.Massa = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPianeti
            // 
            this.lstPianeti.FormattingEnabled = true;
            this.lstPianeti.Location = new System.Drawing.Point(12, 139);
            this.lstPianeti.Name = "lstPianeti";
            this.lstPianeti.Size = new System.Drawing.Size(186, 82);
            this.lstPianeti.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tiktak
            // 
            this.tiktak.Tick += new System.EventHandler(this.tiktak_Tick);
            // 
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(65, 57);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(132, 20);
            this.txtMassa.TabIndex = 2;
            // 
            // txtVelocita
            // 
            this.txtVelocita.Location = new System.Drawing.Point(65, 5);
            this.txtVelocita.Name = "txtVelocita";
            this.txtVelocita.Size = new System.Drawing.Size(132, 20);
            this.txtVelocita.TabIndex = 3;
            // 
            // txtPosizione
            // 
            this.txtPosizione.Location = new System.Drawing.Point(65, 31);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(132, 20);
            this.txtPosizione.TabIndex = 4;
            // 
            // Velocita
            // 
            this.Velocita.AutoSize = true;
            this.Velocita.Location = new System.Drawing.Point(9, 8);
            this.Velocita.Name = "Velocita";
            this.Velocita.Size = new System.Drawing.Size(45, 13);
            this.Velocita.TabIndex = 5;
            this.Velocita.Text = "Velocità";
            // 
            // Posizione
            // 
            this.Posizione.AutoSize = true;
            this.Posizione.Location = new System.Drawing.Point(9, 34);
            this.Posizione.Name = "Posizione";
            this.Posizione.Size = new System.Drawing.Size(52, 13);
            this.Posizione.TabIndex = 6;
            this.Posizione.Text = "Posizione";
            // 
            // Massa
            // 
            this.Massa.AutoSize = true;
            this.Massa.Location = new System.Drawing.Point(9, 60);
            this.Massa.Name = "Massa";
            this.Massa.Size = new System.Drawing.Size(38, 13);
            this.Massa.TabIndex = 7;
            this.Massa.Text = "Massa";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(76, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.Massa);
            this.panel1.Controls.Add(this.Posizione);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lstPianeti);
            this.panel1.Controls.Add(this.Velocita);
            this.panel1.Controls.Add(this.txtMassa);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtVelocita);
            this.panel1.Controls.Add(this.txtPosizione);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 257);
            this.panel1.TabIndex = 12;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(108, 227);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 23);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 20);
            this.txtNome.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPianeti;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer tiktak;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtVelocita;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.Label Velocita;
        private System.Windows.Forms.Label Posizione;
        private System.Windows.Forms.Label Massa;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnStop;
    }
}


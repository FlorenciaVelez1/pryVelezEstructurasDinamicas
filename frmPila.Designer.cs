namespace pryVelezEstructurasDinamicas
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.mskCodigoNE = new System.Windows.Forms.MaskedTextBox();
            this.txtTramiteNE = new System.Windows.Forms.TextBox();
            this.txtNombreNE = new System.Windows.Forms.TextBox();
            this.lblCodigoNE = new System.Windows.Forms.Label();
            this.lblNombreNE = new System.Windows.Forms.Label();
            this.lblTramiteNE = new System.Windows.Forms.Label();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteInfo = new System.Windows.Forms.Label();
            this.lblNombreInfo = new System.Windows.Forms.Label();
            this.lblCodigoInfo = new System.Windows.Forms.Label();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.lblNombreEE = new System.Windows.Forms.Label();
            this.lblTramiteEE = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.GrillaPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.mskCodigoNE);
            this.mrcNuevoElemento.Controls.Add(this.txtTramiteNE);
            this.mrcNuevoElemento.Controls.Add(this.txtNombreNE);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigoNE);
            this.mrcNuevoElemento.Controls.Add(this.lblNombreNE);
            this.mrcNuevoElemento.Controls.Add(this.lblTramiteNE);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(253, 17);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(262, 157);
            this.mrcNuevoElemento.TabIndex = 0;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // mskCodigoNE
            // 
            this.mskCodigoNE.Location = new System.Drawing.Point(99, 36);
            this.mskCodigoNE.Mask = "000000";
            this.mskCodigoNE.Name = "mskCodigoNE";
            this.mskCodigoNE.Size = new System.Drawing.Size(142, 22);
            this.mskCodigoNE.TabIndex = 1;
            // 
            // txtTramiteNE
            // 
            this.txtTramiteNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTramiteNE.Location = new System.Drawing.Point(99, 120);
            this.txtTramiteNE.Name = "txtTramiteNE";
            this.txtTramiteNE.Size = new System.Drawing.Size(142, 22);
            this.txtTramiteNE.TabIndex = 3;
            // 
            // txtNombreNE
            // 
            this.txtNombreNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreNE.Location = new System.Drawing.Point(99, 76);
            this.txtNombreNE.Name = "txtNombreNE";
            this.txtNombreNE.Size = new System.Drawing.Size(142, 22);
            this.txtNombreNE.TabIndex = 2;
            // 
            // lblCodigoNE
            // 
            this.lblCodigoNE.AutoSize = true;
            this.lblCodigoNE.Location = new System.Drawing.Point(23, 33);
            this.lblCodigoNE.Name = "lblCodigoNE";
            this.lblCodigoNE.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoNE.TabIndex = 0;
            this.lblCodigoNE.Text = "Código";
            // 
            // lblNombreNE
            // 
            this.lblNombreNE.AutoSize = true;
            this.lblNombreNE.Location = new System.Drawing.Point(23, 76);
            this.lblNombreNE.Name = "lblNombreNE";
            this.lblNombreNE.Size = new System.Drawing.Size(56, 16);
            this.lblNombreNE.TabIndex = 1;
            this.lblNombreNE.Text = "Nombre";
            // 
            // lblTramiteNE
            // 
            this.lblTramiteNE.AutoSize = true;
            this.lblTramiteNE.Location = new System.Drawing.Point(23, 119);
            this.lblTramiteNE.Name = "lblTramiteNE";
            this.lblTramiteNE.Size = new System.Drawing.Size(53, 16);
            this.lblTramiteNE.TabIndex = 2;
            this.lblTramiteNE.Text = "Trámite";
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteInfo);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreInfo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoInfo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreEE);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteEE);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(532, 17);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(264, 157);
            this.mrcElementoEliminado.TabIndex = 0;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramiteInfo
            // 
            this.lblTramiteInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTramiteInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteInfo.Location = new System.Drawing.Point(104, 122);
            this.lblTramiteInfo.Name = "lblTramiteInfo";
            this.lblTramiteInfo.Size = new System.Drawing.Size(142, 22);
            this.lblTramiteInfo.TabIndex = 11;
            // 
            // lblNombreInfo
            // 
            this.lblNombreInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombreInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreInfo.Location = new System.Drawing.Point(104, 78);
            this.lblNombreInfo.Name = "lblNombreInfo";
            this.lblNombreInfo.Size = new System.Drawing.Size(142, 22);
            this.lblNombreInfo.TabIndex = 10;
            // 
            // lblCodigoInfo
            // 
            this.lblCodigoInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCodigoInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoInfo.Location = new System.Drawing.Point(104, 34);
            this.lblCodigoInfo.Name = "lblCodigoInfo";
            this.lblCodigoInfo.Size = new System.Drawing.Size(142, 22);
            this.lblCodigoInfo.TabIndex = 9;
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(28, 36);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoEE.TabIndex = 6;
            this.lblCodigoEE.Text = "Código";
            // 
            // lblNombreEE
            // 
            this.lblNombreEE.AutoSize = true;
            this.lblNombreEE.Location = new System.Drawing.Point(28, 79);
            this.lblNombreEE.Name = "lblNombreEE";
            this.lblNombreEE.Size = new System.Drawing.Size(56, 16);
            this.lblNombreEE.TabIndex = 7;
            this.lblNombreEE.Text = "Nombre";
            // 
            // lblTramiteEE
            // 
            this.lblTramiteEE.AutoSize = true;
            this.lblTramiteEE.Location = new System.Drawing.Point(28, 122);
            this.lblTramiteEE.Name = "lblTramiteEE";
            this.lblTramiteEE.Size = new System.Drawing.Size(53, 16);
            this.lblTramiteEE.TabIndex = 8;
            this.lblTramiteEE.Text = "Trámite";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(352, 180);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(101, 38);
            this.cmdAgregar.TabIndex = 4;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(636, 180);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(101, 38);
            this.cmdEliminar.TabIndex = 5;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // GrillaPila
            // 
            this.GrillaPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GrillaPila.Location = new System.Drawing.Point(253, 224);
            this.GrillaPila.Name = "GrillaPila";
            this.GrillaPila.RowHeadersVisible = false;
            this.GrillaPila.RowHeadersWidth = 51;
            this.GrillaPila.RowTemplate.Height = 24;
            this.GrillaPila.Size = new System.Drawing.Size(543, 229);
            this.GrillaPila.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.ItemHeight = 16;
            this.lstListado.Location = new System.Drawing.Point(12, 223);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(216, 228);
            this.lstListado.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 187);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.GrillaPila);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica - Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.TextBox txtTramiteNE;
        private System.Windows.Forms.TextBox txtNombreNE;
        private System.Windows.Forms.Label lblCodigoNE;
        private System.Windows.Forms.Label lblNombreNE;
        private System.Windows.Forms.Label lblTramiteNE;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.Label lblNombreEE;
        private System.Windows.Forms.Label lblTramiteEE;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.DataGridView GrillaPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.Label lblTramiteInfo;
        private System.Windows.Forms.Label lblNombreInfo;
        private System.Windows.Forms.Label lblCodigoInfo;
        private System.Windows.Forms.MaskedTextBox mskCodigoNE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
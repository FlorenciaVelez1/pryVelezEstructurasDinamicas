namespace pryVelezEstructurasDinamicas
{
    partial class frmListaEnlazadaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaEnlazadaSimple));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.GrillaListaSimple = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.mskCodigoNE = new System.Windows.Forms.MaskedTextBox();
            this.txtTramiteNE = new System.Windows.Forms.TextBox();
            this.txtNombreNE = new System.Windows.Forms.TextBox();
            this.lblCodigoNE = new System.Windows.Forms.Label();
            this.lblNombreNE = new System.Windows.Forms.Label();
            this.lblTramiteNE = new System.Windows.Forms.Label();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaSimple)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.ItemHeight = 16;
            this.lstListado.Location = new System.Drawing.Point(8, 216);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(216, 228);
            this.lstListado.TabIndex = 10;
            // 
            // GrillaListaSimple
            // 
            this.GrillaListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GrillaListaSimple.Location = new System.Drawing.Point(249, 217);
            this.GrillaListaSimple.Name = "GrillaListaSimple";
            this.GrillaListaSimple.RowHeadersVisible = false;
            this.GrillaListaSimple.RowHeadersWidth = 51;
            this.GrillaListaSimple.RowTemplate.Height = 24;
            this.GrillaListaSimple.Size = new System.Drawing.Size(543, 229);
            this.GrillaListaSimple.TabIndex = 9;
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
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(632, 173);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(101, 38);
            this.cmdEliminar.TabIndex = 12;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(348, 173);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(101, 38);
            this.cmdAgregar.TabIndex = 4;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.cbCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(528, 10);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(264, 157);
            this.mrcElementoEliminado.TabIndex = 7;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(6, 36);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoEE.TabIndex = 6;
            this.lblCodigoEE.Text = "Código";
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.mskCodigoNE);
            this.mrcNuevoElemento.Controls.Add(this.txtTramiteNE);
            this.mrcNuevoElemento.Controls.Add(this.txtNombreNE);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigoNE);
            this.mrcNuevoElemento.Controls.Add(this.lblNombreNE);
            this.mrcNuevoElemento.Controls.Add(this.lblTramiteNE);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(249, 10);
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
            this.lblCodigoNE.Location = new System.Drawing.Point(23, 39);
            this.lblCodigoNE.Name = "lblCodigoNE";
            this.lblCodigoNE.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoNE.TabIndex = 0;
            this.lblCodigoNE.Text = "Código";
            // 
            // lblNombreNE
            // 
            this.lblNombreNE.AutoSize = true;
            this.lblNombreNE.Location = new System.Drawing.Point(23, 79);
            this.lblNombreNE.Name = "lblNombreNE";
            this.lblNombreNE.Size = new System.Drawing.Size(56, 16);
            this.lblNombreNE.TabIndex = 1;
            this.lblNombreNE.Text = "Nombre";
            // 
            // lblTramiteNE
            // 
            this.lblTramiteNE.AutoSize = true;
            this.lblTramiteNE.Location = new System.Drawing.Point(23, 120);
            this.lblTramiteNE.Name = "lblTramiteNE";
            this.lblTramiteNE.Size = new System.Drawing.Size(53, 16);
            this.lblTramiteNE.TabIndex = 2;
            this.lblTramiteNE.Text = "Trámite";
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(84, 33);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(121, 24);
            this.cbCodigo.TabIndex = 7;
            this.cbCodigo.SelectedIndexChanged += new System.EventHandler(this.cbCodigo_SelectedIndexChanged);
            // 
            // frmListaEnlazadaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.GrillaListaSimple);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmListaEnlazadaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Enlazada Simple";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaSimple)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.DataGridView GrillaListaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.MaskedTextBox mskCodigoNE;
        private System.Windows.Forms.TextBox txtTramiteNE;
        private System.Windows.Forms.TextBox txtNombreNE;
        private System.Windows.Forms.Label lblCodigoNE;
        private System.Windows.Forms.Label lblNombreNE;
        private System.Windows.Forms.Label lblTramiteNE;
    }
}
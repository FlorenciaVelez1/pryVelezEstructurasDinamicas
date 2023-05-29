namespace pryVelezEstructurasDinamicas
{
    partial class frmListaEnlazadaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaEnlazadaDoble));
            this.lstListado = new System.Windows.Forms.ListBox();
            this.GrillaListaDoble = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.mskCodigoNE = new System.Windows.Forms.MaskedTextBox();
            this.txtTramiteNE = new System.Windows.Forms.TextBox();
            this.txtNombreNE = new System.Windows.Forms.TextBox();
            this.lblCodigoNE = new System.Windows.Forms.Label();
            this.lblNombreNE = new System.Windows.Forms.Label();
            this.lblTramiteNE = new System.Windows.Forms.Label();
            this.mrcListaDatos = new System.Windows.Forms.GroupBox();
            this.rtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendete = new System.Windows.Forms.RadioButton();
            this.picListaEnlazadaDoble = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaDoble)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcListaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListaEnlazadaDoble)).BeginInit();
            this.SuspendLayout();
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.ItemHeight = 16;
            this.lstListado.Location = new System.Drawing.Point(8, 216);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(216, 180);
            this.lstListado.TabIndex = 18;
            // 
            // GrillaListaDoble
            // 
            this.GrillaListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GrillaListaDoble.Location = new System.Drawing.Point(249, 217);
            this.GrillaListaDoble.Name = "GrillaListaDoble";
            this.GrillaListaDoble.ReadOnly = true;
            this.GrillaListaDoble.RowHeadersVisible = false;
            this.GrillaListaDoble.RowHeadersWidth = 51;
            this.GrillaListaDoble.RowTemplate.Height = 24;
            this.GrillaListaDoble.Size = new System.Drawing.Size(502, 179);
            this.GrillaListaDoble.TabIndex = 17;
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
            this.cmdEliminar.Location = new System.Drawing.Point(581, 87);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(101, 38);
            this.cmdEliminar.TabIndex = 19;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(348, 173);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(101, 38);
            this.cmdAgregar.TabIndex = 15;
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
            this.mrcElementoEliminado.Size = new System.Drawing.Size(223, 71);
            this.mrcElementoEliminado.TabIndex = 16;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
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
            this.mrcNuevoElemento.TabIndex = 14;
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
            this.mskCodigoNE.TextChanged += new System.EventHandler(this.mskCodigoNE_TextChanged);
            // 
            // txtTramiteNE
            // 
            this.txtTramiteNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTramiteNE.Location = new System.Drawing.Point(99, 120);
            this.txtTramiteNE.Name = "txtTramiteNE";
            this.txtTramiteNE.Size = new System.Drawing.Size(142, 22);
            this.txtTramiteNE.TabIndex = 3;
            this.txtTramiteNE.TextChanged += new System.EventHandler(this.txtTramiteNE_TextChanged);
            // 
            // txtNombreNE
            // 
            this.txtNombreNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreNE.Location = new System.Drawing.Point(99, 76);
            this.txtNombreNE.Name = "txtNombreNE";
            this.txtNombreNE.Size = new System.Drawing.Size(142, 22);
            this.txtNombreNE.TabIndex = 2;
            this.txtNombreNE.TextChanged += new System.EventHandler(this.txtNombreNE_TextChanged);
            this.txtNombreNE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreNE_KeyPress);
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
            // mrcListaDatos
            // 
            this.mrcListaDatos.Controls.Add(this.rtnDescendente);
            this.mrcListaDatos.Controls.Add(this.rbtnAscendete);
            this.mrcListaDatos.Location = new System.Drawing.Point(528, 130);
            this.mrcListaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcListaDatos.Name = "mrcListaDatos";
            this.mrcListaDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcListaDatos.Size = new System.Drawing.Size(223, 79);
            this.mrcListaDatos.TabIndex = 21;
            this.mrcListaDatos.TabStop = false;
            this.mrcListaDatos.Text = "Listar los Datos";
            // 
            // rtnDescendente
            // 
            this.rtnDescendente.AutoSize = true;
            this.rtnDescendente.Location = new System.Drawing.Point(8, 52);
            this.rtnDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.rtnDescendente.Name = "rtnDescendente";
            this.rtnDescendente.Size = new System.Drawing.Size(109, 20);
            this.rtnDescendente.TabIndex = 3;
            this.rtnDescendente.TabStop = true;
            this.rtnDescendente.Text = "Descendente";
            this.rtnDescendente.UseVisualStyleBackColor = true;
            this.rtnDescendente.CheckedChanged += new System.EventHandler(this.rtnDescendente_CheckedChanged);
            // 
            // rbtnAscendete
            // 
            this.rbtnAscendete.AutoSize = true;
            this.rbtnAscendete.Location = new System.Drawing.Point(8, 23);
            this.rbtnAscendete.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAscendete.Name = "rbtnAscendete";
            this.rbtnAscendete.Size = new System.Drawing.Size(100, 20);
            this.rbtnAscendete.TabIndex = 2;
            this.rbtnAscendete.TabStop = true;
            this.rbtnAscendete.Text = "Ascendente";
            this.rbtnAscendete.UseVisualStyleBackColor = true;
            this.rbtnAscendete.CheckedChanged += new System.EventHandler(this.rbtnAscendete_CheckedChanged);
            // 
            // picListaEnlazadaDoble
            // 
            this.picListaEnlazadaDoble.Image = ((System.Drawing.Image)(resources.GetObject("picListaEnlazadaDoble.Image")));
            this.picListaEnlazadaDoble.Location = new System.Drawing.Point(8, 5);
            this.picListaEnlazadaDoble.Name = "picListaEnlazadaDoble";
            this.picListaEnlazadaDoble.Size = new System.Drawing.Size(216, 187);
            this.picListaEnlazadaDoble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picListaEnlazadaDoble.TabIndex = 20;
            this.picListaEnlazadaDoble.TabStop = false;
            // 
            // frmListaEnlazadaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 411);
            this.Controls.Add(this.mrcListaDatos);
            this.Controls.Add(this.picListaEnlazadaDoble);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.GrillaListaDoble);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmListaEnlazadaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Enlazada Doble";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaDoble)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcListaDatos.ResumeLayout(false);
            this.mrcListaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListaEnlazadaDoble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.DataGridView GrillaListaDoble;
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
        private System.Windows.Forms.GroupBox mrcListaDatos;
        private System.Windows.Forms.RadioButton rtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendete;
        private System.Windows.Forms.PictureBox picListaEnlazadaDoble;
    }
}
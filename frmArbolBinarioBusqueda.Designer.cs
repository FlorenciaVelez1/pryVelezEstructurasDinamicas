namespace pryVelezEstructurasDinamicas
{
    partial class frmArbolBinarioBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinarioBusqueda));
            this.picArbolBinario = new System.Windows.Forms.PictureBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.GrillaArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigoNE = new System.Windows.Forms.Label();
            this.lblNombreNE = new System.Windows.Forms.Label();
            this.lblTramiteNE = new System.Windows.Forms.Label();
            this.mrcListaDatos = new System.Windows.Forms.GroupBox();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendete = new System.Windows.Forms.RadioButton();
            this.treevDatos = new System.Windows.Forms.TreeView();
            this.mrcOrden = new System.Windows.Forms.GroupBox();
            this.rbtnPostOrden = new System.Windows.Forms.RadioButton();
            this.rbtnPreOrden = new System.Windows.Forms.RadioButton();
            this.rbtnInOrden = new System.Windows.Forms.RadioButton();
            this.cmdEquilibrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picArbolBinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaArbolBinario)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcListaDatos.SuspendLayout();
            this.mrcOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // picArbolBinario
            // 
            this.picArbolBinario.Image = ((System.Drawing.Image)(resources.GetObject("picArbolBinario.Image")));
            this.picArbolBinario.Location = new System.Drawing.Point(8, 5);
            this.picArbolBinario.Name = "picArbolBinario";
            this.picArbolBinario.Size = new System.Drawing.Size(216, 187);
            this.picArbolBinario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArbolBinario.TabIndex = 20;
            this.picArbolBinario.TabStop = false;
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.ItemHeight = 16;
            this.lstListado.Location = new System.Drawing.Point(8, 216);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(216, 228);
            this.lstListado.TabIndex = 18;
            // 
            // GrillaArbolBinario
            // 
            this.GrillaArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GrillaArbolBinario.Location = new System.Drawing.Point(249, 217);
            this.GrillaArbolBinario.Name = "GrillaArbolBinario";
            this.GrillaArbolBinario.ReadOnly = true;
            this.GrillaArbolBinario.RowHeadersVisible = false;
            this.GrillaArbolBinario.RowHeadersWidth = 51;
            this.GrillaArbolBinario.RowTemplate.Height = 24;
            this.GrillaArbolBinario.Size = new System.Drawing.Size(543, 229);
            this.GrillaArbolBinario.TabIndex = 17;
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
            this.cmdEliminar.Location = new System.Drawing.Point(528, 174);
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
            this.mrcElementoEliminado.Size = new System.Drawing.Size(264, 110);
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
            this.mrcNuevoElemento.Controls.Add(this.mskCodigo);
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
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
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(99, 36);
            this.mskCodigo.Mask = "000000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(142, 22);
            this.mskCodigo.TabIndex = 1;
            this.mskCodigo.TextChanged += new System.EventHandler(this.mskCodigoNE_TextChanged);
            // 
            // txtTramite
            // 
            this.txtTramite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTramite.Location = new System.Drawing.Point(99, 120);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(142, 22);
            this.txtTramite.TabIndex = 3;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramiteNE_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(99, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombreNE_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.mrcListaDatos.Controls.Add(this.rbtnDescendente);
            this.mrcListaDatos.Controls.Add(this.rbtnAscendete);
            this.mrcListaDatos.Location = new System.Drawing.Point(822, 128);
            this.mrcListaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcListaDatos.Name = "mrcListaDatos";
            this.mrcListaDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcListaDatos.Size = new System.Drawing.Size(264, 78);
            this.mrcListaDatos.TabIndex = 22;
            this.mrcListaDatos.TabStop = false;
            this.mrcListaDatos.Text = "Listar los Datos";
            // 
            // rbtnDescendente
            // 
            this.rbtnDescendente.AutoSize = true;
            this.rbtnDescendente.Location = new System.Drawing.Point(8, 52);
            this.rbtnDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDescendente.Name = "rbtnDescendente";
            this.rbtnDescendente.Size = new System.Drawing.Size(109, 20);
            this.rbtnDescendente.TabIndex = 3;
            this.rbtnDescendente.TabStop = true;
            this.rbtnDescendente.Text = "Descendente";
            this.rbtnDescendente.UseVisualStyleBackColor = true;
            this.rbtnDescendente.CheckedChanged += new System.EventHandler(this.rbtnDescendente_CheckedChanged);
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
            // treevDatos
            // 
            this.treevDatos.Location = new System.Drawing.Point(822, 217);
            this.treevDatos.Name = "treevDatos";
            this.treevDatos.Size = new System.Drawing.Size(264, 227);
            this.treevDatos.TabIndex = 23;
            // 
            // mrcOrden
            // 
            this.mrcOrden.Controls.Add(this.rbtnPostOrden);
            this.mrcOrden.Controls.Add(this.rbtnPreOrden);
            this.mrcOrden.Controls.Add(this.rbtnInOrden);
            this.mrcOrden.Location = new System.Drawing.Point(822, 13);
            this.mrcOrden.Margin = new System.Windows.Forms.Padding(4);
            this.mrcOrden.Name = "mrcOrden";
            this.mrcOrden.Padding = new System.Windows.Forms.Padding(4);
            this.mrcOrden.Size = new System.Drawing.Size(264, 107);
            this.mrcOrden.TabIndex = 24;
            this.mrcOrden.TabStop = false;
            this.mrcOrden.Text = "Orden de los Datos";
            // 
            // rbtnPostOrden
            // 
            this.rbtnPostOrden.AutoSize = true;
            this.rbtnPostOrden.Location = new System.Drawing.Point(8, 79);
            this.rbtnPostOrden.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPostOrden.Name = "rbtnPostOrden";
            this.rbtnPostOrden.Size = new System.Drawing.Size(92, 20);
            this.rbtnPostOrden.TabIndex = 4;
            this.rbtnPostOrden.TabStop = true;
            this.rbtnPostOrden.Text = "PostOrden";
            this.rbtnPostOrden.UseVisualStyleBackColor = true;
            this.rbtnPostOrden.CheckedChanged += new System.EventHandler(this.rbtnPostOrden_CheckedChanged);
            // 
            // rbtnPreOrden
            // 
            this.rbtnPreOrden.AutoSize = true;
            this.rbtnPreOrden.Location = new System.Drawing.Point(8, 51);
            this.rbtnPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPreOrden.Name = "rbtnPreOrden";
            this.rbtnPreOrden.Size = new System.Drawing.Size(86, 20);
            this.rbtnPreOrden.TabIndex = 3;
            this.rbtnPreOrden.TabStop = true;
            this.rbtnPreOrden.Text = "PreOrden";
            this.rbtnPreOrden.UseVisualStyleBackColor = true;
            this.rbtnPreOrden.CheckedChanged += new System.EventHandler(this.rbtnPreOrden_CheckedChanged);
            // 
            // rbtnInOrden
            // 
            this.rbtnInOrden.AutoSize = true;
            this.rbtnInOrden.Location = new System.Drawing.Point(8, 23);
            this.rbtnInOrden.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnInOrden.Name = "rbtnInOrden";
            this.rbtnInOrden.Size = new System.Drawing.Size(75, 20);
            this.rbtnInOrden.TabIndex = 2;
            this.rbtnInOrden.TabStop = true;
            this.rbtnInOrden.Text = "InOrden";
            this.rbtnInOrden.UseVisualStyleBackColor = true;
            this.rbtnInOrden.CheckedChanged += new System.EventHandler(this.rbtnInOrden_CheckedChanged);
            // 
            // cmdEquilibrar
            // 
            this.cmdEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEquilibrar.Location = new System.Drawing.Point(663, 174);
            this.cmdEquilibrar.Name = "cmdEquilibrar";
            this.cmdEquilibrar.Size = new System.Drawing.Size(101, 38);
            this.cmdEquilibrar.TabIndex = 25;
            this.cmdEquilibrar.Text = "Equilibrar";
            this.cmdEquilibrar.UseVisualStyleBackColor = true;
            this.cmdEquilibrar.Click += new System.EventHandler(this.cmdEquilibrar_Click);
            // 
            // frmArbolBinarioBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.cmdEquilibrar);
            this.Controls.Add(this.mrcOrden);
            this.Controls.Add(this.treevDatos);
            this.Controls.Add(this.mrcListaDatos);
            this.Controls.Add(this.picArbolBinario);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.GrillaArbolBinario);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmArbolBinarioBusqueda";
            this.Text = "Arbol Binario de Búsqueda";
            ((System.ComponentModel.ISupportInitialize)(this.picArbolBinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaArbolBinario)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcListaDatos.ResumeLayout(false);
            this.mrcListaDatos.PerformLayout();
            this.mrcOrden.ResumeLayout(false);
            this.mrcOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picArbolBinario;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.DataGridView GrillaArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigoNE;
        private System.Windows.Forms.Label lblNombreNE;
        private System.Windows.Forms.Label lblTramiteNE;
        private System.Windows.Forms.GroupBox mrcListaDatos;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendete;
        private System.Windows.Forms.TreeView treevDatos;
        private System.Windows.Forms.GroupBox mrcOrden;
        private System.Windows.Forms.RadioButton rbtnPostOrden;
        private System.Windows.Forms.RadioButton rbtnPreOrden;
        private System.Windows.Forms.RadioButton rbtnInOrden;
        private System.Windows.Forms.Button cmdEquilibrar;
    }
}
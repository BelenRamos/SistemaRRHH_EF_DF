namespace Presentacion
{
    partial class frmPerfiles
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
            this.ListaPerfiles = new System.Windows.Forms.ListBox();
            this.btnEliminarPerfil = new FontAwesome.Sharp.IconButton();
            this.btmEditarPerfil = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionarPerfil = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // ListaPerfiles
            // 
            this.ListaPerfiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListaPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListaPerfiles.FormattingEnabled = true;
            this.ListaPerfiles.ItemHeight = 16;
            this.ListaPerfiles.Location = new System.Drawing.Point(0, 0);
            this.ListaPerfiles.Name = "ListaPerfiles";
            this.ListaPerfiles.Size = new System.Drawing.Size(443, 341);
            this.ListaPerfiles.TabIndex = 0;
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarPerfil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.btnEliminarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPerfil.IconSize = 20;
            this.btnEliminarPerfil.Location = new System.Drawing.Point(480, 181);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.Size = new System.Drawing.Size(75, 38);
            this.btnEliminarPerfil.TabIndex = 1;
            this.btnEliminarPerfil.Text = "Eliminar";
            this.btnEliminarPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarPerfil.UseVisualStyleBackColor = true;
            // 
            // btmEditarPerfil
            // 
            this.btmEditarPerfil.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btmEditarPerfil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.btmEditarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btmEditarPerfil.IconSize = 20;
            this.btmEditarPerfil.Location = new System.Drawing.Point(480, 117);
            this.btmEditarPerfil.Name = "btmEditarPerfil";
            this.btmEditarPerfil.Size = new System.Drawing.Size(75, 38);
            this.btmEditarPerfil.TabIndex = 2;
            this.btmEditarPerfil.Text = "Editar";
            this.btmEditarPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmEditarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btmEditarPerfil.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarPerfil
            // 
            this.btnSeleccionarPerfil.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSeleccionarPerfil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.btnSeleccionarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarPerfil.IconSize = 20;
            this.btnSeleccionarPerfil.Location = new System.Drawing.Point(480, 50);
            this.btnSeleccionarPerfil.Name = "btnSeleccionarPerfil";
            this.btnSeleccionarPerfil.Size = new System.Drawing.Size(75, 38);
            this.btnSeleccionarPerfil.TabIndex = 3;
            this.btnSeleccionarPerfil.Text = "Seleccionar";
            this.btnSeleccionarPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeleccionarPerfil.UseVisualStyleBackColor = true;
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.btnSeleccionarPerfil);
            this.Controls.Add(this.btmEditarPerfil);
            this.Controls.Add(this.btnEliminarPerfil);
            this.Controls.Add(this.ListaPerfiles);
            this.Name = "frmPerfiles";
            this.Text = "Perfiles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaPerfiles;
        private FontAwesome.Sharp.IconButton btnEliminarPerfil;
        private FontAwesome.Sharp.IconButton btmEditarPerfil;
        private FontAwesome.Sharp.IconButton btnSeleccionarPerfil;
    }
}
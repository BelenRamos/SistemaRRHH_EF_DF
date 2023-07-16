namespace Presentacion
{
    partial class FrmMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTurnos = new FontAwesome.Sharp.IconButton();
            this.btnOfertasLaborales = new FontAwesome.Sharp.IconButton();
            this.btnPostulantes = new FontAwesome.Sharp.IconButton();
            this.btnPerfiles = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildFrm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildFrm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFrm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.panelMenu.Controls.Add(this.btnTurnos);
            this.panelMenu.Controls.Add(this.btnOfertasLaborales);
            this.panelMenu.Controls.Add(this.btnPostulantes);
            this.panelMenu.Controls.Add(this.btnPerfiles);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnTurnos
            // 
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnTurnos.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnTurnos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTurnos.IconSize = 30;
            this.btnTurnos.Location = new System.Drawing.Point(0, 235);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnTurnos.Size = new System.Drawing.Size(200, 45);
            this.btnTurnos.TabIndex = 6;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnOfertasLaborales
            // 
            this.btnOfertasLaborales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfertasLaborales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfertasLaborales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertasLaborales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnOfertasLaborales.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnOfertasLaborales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnOfertasLaborales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOfertasLaborales.IconSize = 30;
            this.btnOfertasLaborales.Location = new System.Drawing.Point(0, 190);
            this.btnOfertasLaborales.Name = "btnOfertasLaborales";
            this.btnOfertasLaborales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOfertasLaborales.Size = new System.Drawing.Size(200, 45);
            this.btnOfertasLaborales.TabIndex = 5;
            this.btnOfertasLaborales.Text = "Ofertas Laborales";
            this.btnOfertasLaborales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOfertasLaborales.UseVisualStyleBackColor = true;
            this.btnOfertasLaborales.Click += new System.EventHandler(this.btnOfertasLaborales_Click);
            // 
            // btnPostulantes
            // 
            this.btnPostulantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostulantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostulantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnPostulantes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnPostulantes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnPostulantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPostulantes.IconSize = 30;
            this.btnPostulantes.Location = new System.Drawing.Point(0, 145);
            this.btnPostulantes.Name = "btnPostulantes";
            this.btnPostulantes.Size = new System.Drawing.Size(200, 45);
            this.btnPostulantes.TabIndex = 4;
            this.btnPostulantes.Text = "Postulantes";
            this.btnPostulantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPostulantes.UseVisualStyleBackColor = true;
            this.btnPostulantes.Click += new System.EventHandler(this.btnPostulantes_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnPerfiles.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnPerfiles.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.btnPerfiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfiles.IconSize = 30;
            this.btnPerfiles.Location = new System.Drawing.Point(0, 100);
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnPerfiles.Size = new System.Drawing.Size(200, 45);
            this.btnPerfiles.TabIndex = 3;
            this.btnPerfiles.Text = "Perfiles";
            this.btnPerfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfiles.UseVisualStyleBackColor = true;
            this.btnPerfiles.Click += new System.EventHandler(this.btnPerfiles_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::Presentacion.Properties.Resources.icons8_m_641;
            this.btnMenu.Location = new System.Drawing.Point(67, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(66, 85);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BarraDeTitulo.Controls.Add(this.btnMinimize);
            this.BarraDeTitulo.Controls.Add(this.btnExit);
            this.BarraDeTitulo.Controls.Add(this.btnMaximize);
            this.BarraDeTitulo.Controls.Add(this.iconCurrentChildFrm);
            this.BarraDeTitulo.Controls.Add(this.lblTitleChildFrm);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(600, 54);
            this.BarraDeTitulo.TabIndex = 1;
            this.BarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraDeTitulo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(520, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(577, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(547, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click_1);
            // 
            // iconCurrentChildFrm
            // 
            this.iconCurrentChildFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.iconCurrentChildFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.iconCurrentChildFrm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildFrm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.iconCurrentChildFrm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFrm.Location = new System.Drawing.Point(6, 16);
            this.iconCurrentChildFrm.Name = "iconCurrentChildFrm";
            this.iconCurrentChildFrm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildFrm.TabIndex = 3;
            this.iconCurrentChildFrm.TabStop = false;
            // 
            // lblTitleChildFrm
            // 
            this.lblTitleChildFrm.AutoSize = true;
            this.lblTitleChildFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.lblTitleChildFrm.Location = new System.Drawing.Point(44, 26);
            this.lblTitleChildFrm.Name = "lblTitleChildFrm";
            this.lblTitleChildFrm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildFrm.TabIndex = 3;
            this.lblTitleChildFrm.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 16);
            this.panel2.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(600, 380);
            this.panelDesktop.TabIndex = 3;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraDeTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.BarraDeTitulo.ResumeLayout(false);
            this.BarraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFrm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleChildFrm;
        private FontAwesome.Sharp.IconButton btnPerfiles;
        private FontAwesome.Sharp.IconButton btnTurnos;
        private FontAwesome.Sharp.IconButton btnOfertasLaborales;
        private FontAwesome.Sharp.IconButton btnPostulantes;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFrm;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private System.Windows.Forms.Panel panelDesktop;
    }
}


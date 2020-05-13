namespace Muestra1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnMostrarImagen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.Evaluar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCentrarComponente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMensaje2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagen.Location = new System.Drawing.Point(761, 86);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(173, 160);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 1;
            this.pbxImagen.TabStop = false;
            // 
            // btnMostrarImagen
            // 
            this.btnMostrarImagen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMostrarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMostrarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarImagen.BorderRadius = 0;
            this.btnMostrarImagen.ButtonText = "Mostrar Imagen";
            this.btnMostrarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarImagen.DisabledColor = System.Drawing.Color.Gray;
            this.btnMostrarImagen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMostrarImagen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMostrarImagen.Iconimage")));
            this.btnMostrarImagen.Iconimage_right = null;
            this.btnMostrarImagen.Iconimage_right_Selected = null;
            this.btnMostrarImagen.Iconimage_Selected = null;
            this.btnMostrarImagen.IconMarginLeft = 0;
            this.btnMostrarImagen.IconMarginRight = 0;
            this.btnMostrarImagen.IconRightVisible = true;
            this.btnMostrarImagen.IconRightZoom = 0D;
            this.btnMostrarImagen.IconVisible = true;
            this.btnMostrarImagen.IconZoom = 90D;
            this.btnMostrarImagen.IsTab = false;
            this.btnMostrarImagen.Location = new System.Drawing.Point(761, 254);
            this.btnMostrarImagen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMostrarImagen.Name = "btnMostrarImagen";
            this.btnMostrarImagen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMostrarImagen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMostrarImagen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMostrarImagen.selected = false;
            this.btnMostrarImagen.Size = new System.Drawing.Size(173, 55);
            this.btnMostrarImagen.TabIndex = 2;
            this.btnMostrarImagen.Text = "Mostrar Imagen";
            this.btnMostrarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarImagen.Textcolor = System.Drawing.Color.White;
            this.btnMostrarImagen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarImagen.Click += new System.EventHandler(this.btnMostrarImagen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 492);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 62);
            this.panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 125;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Mujer",
            "Hombre",
            "Prefiero no decirlo",
            "Otro",
            "1",
            "1",
            "1",
            "1",
            "11",
            "1",
            "1",
            "1",
            "1",
            "12",
            "2",
            "2",
            "2",
            "2",
            "2",
            "f",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "11",
            "1",
            "4",
            "5",
            "6",
            "7",
            "8",
            "8990"});
            this.comboBox1.Location = new System.Drawing.Point(145, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(448, 111);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(304, 17);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Componente Hija aaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(260, 222);
            this.txtTexto1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(228, 22);
            this.txtTexto1.TabIndex = 7;
            // 
            // Evaluar
            // 
            this.Evaluar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Evaluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Evaluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Evaluar.BorderRadius = 0;
            this.Evaluar.ButtonText = "Evaluar";
            this.Evaluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Evaluar.DisabledColor = System.Drawing.Color.Gray;
            this.Evaluar.Iconcolor = System.Drawing.Color.Transparent;
            this.Evaluar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Evaluar.Iconimage")));
            this.Evaluar.Iconimage_right = null;
            this.Evaluar.Iconimage_right_Selected = null;
            this.Evaluar.Iconimage_Selected = null;
            this.Evaluar.IconMarginLeft = 0;
            this.Evaluar.IconMarginRight = 0;
            this.Evaluar.IconRightVisible = true;
            this.Evaluar.IconRightZoom = 0D;
            this.Evaluar.IconVisible = true;
            this.Evaluar.IconZoom = 90D;
            this.Evaluar.IsTab = false;
            this.Evaluar.Location = new System.Drawing.Point(260, 292);
            this.Evaluar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Evaluar.Name = "Evaluar";
            this.Evaluar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Evaluar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Evaluar.OnHoverTextColor = System.Drawing.Color.White;
            this.Evaluar.selected = false;
            this.Evaluar.Size = new System.Drawing.Size(229, 34);
            this.Evaluar.TabIndex = 8;
            this.Evaluar.Text = "Evaluar";
            this.Evaluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Evaluar.Textcolor = System.Drawing.Color.White;
            this.Evaluar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evaluar.Click += new System.EventHandler(this.Evaluar_Click);
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(347, 256);
            this.lblTexto1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(55, 17);
            this.lblTexto1.TabIndex = 9;
            this.lblTexto1.Text = "Texto 1";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(584, 256);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 17);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(497, 222);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(228, 22);
            this.txtContraseña.TabIndex = 10;
            // 
            // btnCentrarComponente
            // 
            this.btnCentrarComponente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCentrarComponente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCentrarComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCentrarComponente.BorderRadius = 0;
            this.btnCentrarComponente.ButtonText = "Centrar componentes";
            this.btnCentrarComponente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCentrarComponente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCentrarComponente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCentrarComponente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCentrarComponente.Iconimage")));
            this.btnCentrarComponente.Iconimage_right = null;
            this.btnCentrarComponente.Iconimage_right_Selected = null;
            this.btnCentrarComponente.Iconimage_Selected = null;
            this.btnCentrarComponente.IconMarginLeft = 0;
            this.btnCentrarComponente.IconMarginRight = 0;
            this.btnCentrarComponente.IconRightVisible = true;
            this.btnCentrarComponente.IconRightZoom = 0D;
            this.btnCentrarComponente.IconVisible = true;
            this.btnCentrarComponente.IconZoom = 90D;
            this.btnCentrarComponente.IsTab = false;
            this.btnCentrarComponente.Location = new System.Drawing.Point(260, 165);
            this.btnCentrarComponente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCentrarComponente.Name = "btnCentrarComponente";
            this.btnCentrarComponente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCentrarComponente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCentrarComponente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCentrarComponente.selected = false;
            this.btnCentrarComponente.Size = new System.Drawing.Size(285, 32);
            this.btnCentrarComponente.TabIndex = 12;
            this.btnCentrarComponente.Text = "Centrar componentes";
            this.btnCentrarComponente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentrarComponente.Textcolor = System.Drawing.Color.White;
            this.btnCentrarComponente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentrarComponente.Click += new System.EventHandler(this.btnCentrarComponente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Mensaje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 362);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumero.Location = new System.Drawing.Point(260, 421);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(116, 31);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(412, 427);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(132, 22);
            this.txtNumero.TabIndex = 17;
            // 
            // btnMensaje2
            // 
            this.btnMensaje2.Location = new System.Drawing.Point(688, 362);
            this.btnMensaje2.Name = "btnMensaje2";
            this.btnMensaje2.Size = new System.Drawing.Size(132, 23);
            this.btnMensaje2.TabIndex = 18;
            this.btnMensaje2.Text = "No le piques";
            this.btnMensaje2.UseVisualStyleBackColor = true;
            this.btnMensaje2.Click += new System.EventHandler(this.btnMensaje2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMensaje2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnCentrarComponente);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.Evaluar);
            this.Controls.Add(this.txtTexto1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrarImagen);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxImagen;
        private Bunifu.Framework.UI.BunifuFlatButton btnMostrarImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtTexto1;
        private Bunifu.Framework.UI.BunifuFlatButton Evaluar;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private Bunifu.Framework.UI.BunifuFlatButton btnCentrarComponente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMensaje2;
    }
}


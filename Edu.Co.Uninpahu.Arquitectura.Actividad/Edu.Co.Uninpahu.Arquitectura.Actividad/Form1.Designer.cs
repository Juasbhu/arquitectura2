namespace Edu.Co.Uninpahu.Arquitectura.Actividad
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
            this.gBLogin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonIng = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUsu = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.gBLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBLogin
            // 
            this.gBLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBLogin.Controls.Add(this.button1);
            this.gBLogin.Controls.Add(this.buttonIng);
            this.gBLogin.Controls.Add(this.textBoxPass);
            this.gBLogin.Controls.Add(this.textBoxUsu);
            this.gBLogin.Controls.Add(this.labelPassword);
            this.gBLogin.Controls.Add(this.labelUsuario);
            this.gBLogin.Location = new System.Drawing.Point(4, 5);
            this.gBLogin.Name = "gBLogin";
            this.gBLogin.Size = new System.Drawing.Size(268, 244);
            this.gBLogin.TabIndex = 0;
            this.gBLogin.TabStop = false;
            this.gBLogin.Enter += new System.EventHandler(this.gBLogin_Enter);
            this.gBLogin.Resize += new System.EventHandler(this.gBLogin_Resize);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonIng
            // 
            this.buttonIng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonIng.BackColor = System.Drawing.Color.Transparent;
            this.buttonIng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonIng.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIng.Location = new System.Drawing.Point(26, 191);
            this.buttonIng.Name = "buttonIng";
            this.buttonIng.Size = new System.Drawing.Size(99, 35);
            this.buttonIng.TabIndex = 25;
            this.buttonIng.Text = "Ingresar";
            this.buttonIng.UseVisualStyleBackColor = false;
            this.buttonIng.Click += new System.EventHandler(this.buttonIng_Click_1);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxPass.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(26, 143);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(216, 26);
            this.textBoxPass.TabIndex = 24;
            // 
            // textBoxUsu
            // 
            this.textBoxUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxUsu.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsu.Location = new System.Drawing.Point(26, 57);
            this.textBoxUsu.Name = "textBoxUsu";
            this.textBoxUsu.Size = new System.Drawing.Size(216, 26);
            this.textBoxUsu.TabIndex = 23;
            this.textBoxUsu.TextChanged += new System.EventHandler(this.textBoxUsu_TextChanged);
            this.textBoxUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsu_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(81, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 19);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(94, 19);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(75, 19);
            this.labelUsuario.TabIndex = 21;
            this.labelUsuario.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gBLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.gBLogin.ResumeLayout(false);
            this.gBLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonIng;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUsu;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsuario;
    }
}


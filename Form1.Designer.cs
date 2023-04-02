namespace Cansat_HMI
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.secondaryDataButton = new System.Windows.Forms.Button();
            this.primaryDataButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sidePanel.Controls.Add(this.exitButton);
            this.sidePanel.Controls.Add(this.configButton);
            this.sidePanel.Controls.Add(this.dataPanel);
            this.sidePanel.Controls.Add(this.dataButton);
            this.sidePanel.Controls.Add(this.startButton);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 561);
            this.sidePanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(0, 516);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(200, 45);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Salir";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // configButton
            // 
            this.configButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.configButton.FlatAppearance.BorderSize = 0;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.configButton.Location = new System.Drawing.Point(0, 325);
            this.configButton.Name = "configButton";
            this.configButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.configButton.Size = new System.Drawing.Size(200, 45);
            this.configButton.TabIndex = 4;
            this.configButton.Text = "Configuración";
            this.configButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.secondaryDataButton);
            this.dataPanel.Controls.Add(this.primaryDataButton);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataPanel.Location = new System.Drawing.Point(0, 237);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(200, 88);
            this.dataPanel.TabIndex = 3;
            // 
            // secondaryDataButton
            // 
            this.secondaryDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.secondaryDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondaryDataButton.FlatAppearance.BorderSize = 0;
            this.secondaryDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondaryDataButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.secondaryDataButton.Location = new System.Drawing.Point(0, 40);
            this.secondaryDataButton.Name = "secondaryDataButton";
            this.secondaryDataButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.secondaryDataButton.Size = new System.Drawing.Size(200, 40);
            this.secondaryDataButton.TabIndex = 4;
            this.secondaryDataButton.Text = "Carga secundaria";
            this.secondaryDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secondaryDataButton.UseVisualStyleBackColor = false;
            this.secondaryDataButton.Click += new System.EventHandler(this.secondaryDataButton_Click);
            // 
            // primaryDataButton
            // 
            this.primaryDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.primaryDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.primaryDataButton.FlatAppearance.BorderSize = 0;
            this.primaryDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primaryDataButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.primaryDataButton.Location = new System.Drawing.Point(0, 0);
            this.primaryDataButton.Name = "primaryDataButton";
            this.primaryDataButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.primaryDataButton.Size = new System.Drawing.Size(200, 40);
            this.primaryDataButton.TabIndex = 3;
            this.primaryDataButton.Text = "Carga primaria";
            this.primaryDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.primaryDataButton.UseVisualStyleBackColor = false;
            this.primaryDataButton.Click += new System.EventHandler(this.primaryDataButton_Click);
            // 
            // dataButton
            // 
            this.dataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataButton.FlatAppearance.BorderSize = 0;
            this.dataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dataButton.Location = new System.Drawing.Point(0, 192);
            this.dataButton.Name = "dataButton";
            this.dataButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataButton.Size = new System.Drawing.Size(200, 45);
            this.dataButton.TabIndex = 2;
            this.dataButton.Text = "Datos";
            this.dataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.startButton.Location = new System.Drawing.Point(0, 147);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.startButton.Size = new System.Drawing.Size(200, 45);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Inicio";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 147);
            this.logoPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(200, 528);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(734, 33);
            this.infoPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(734, 528);
            this.mainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado: Conectado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(434, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carga primaria: 98%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(569, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carga secundaria: 100%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Interface";
            this.Text = "HMI de misión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button secondaryDataButton;
        private System.Windows.Forms.Button primaryDataButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


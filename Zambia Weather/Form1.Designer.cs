namespace Zambia_Weather
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cities_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxtemp_label = new System.Windows.Forms.Label();
            this.mintemp_label = new System.Windows.Forms.Label();
            this.maxtempview_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTempLabel = new System.Windows.Forms.Label();
            this.minTempView = new System.Windows.Forms.Label();
            this.UpdateWeathertimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cities_combobox
            // 
            this.cities_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cities_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cities_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cities_combobox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cities_combobox.FormattingEnabled = true;
            this.cities_combobox.Location = new System.Drawing.Point(191, 84);
            this.cities_combobox.Name = "cities_combobox";
            this.cities_combobox.Size = new System.Drawing.Size(313, 27);
            this.cities_combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zambia Current Weather";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "City : ";
            // 
            // maxtemp_label
            // 
            this.maxtemp_label.AutoSize = true;
            this.maxtemp_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtemp_label.Location = new System.Drawing.Point(159, 253);
            this.maxtemp_label.Name = "maxtemp_label";
            this.maxtemp_label.Size = new System.Drawing.Size(59, 19);
            this.maxtemp_label.TabIndex = 3;
            this.maxtemp_label.Text = "Max temp";
            // 
            // mintemp_label
            // 
            this.mintemp_label.AutoSize = true;
            this.mintemp_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintemp_label.Location = new System.Drawing.Point(462, 253);
            this.mintemp_label.Name = "mintemp_label";
            this.mintemp_label.Size = new System.Drawing.Size(56, 19);
            this.mintemp_label.TabIndex = 4;
            this.mintemp_label.Text = "Min temp";
            // 
            // maxtempview_label
            // 
            this.maxtempview_label.AutoSize = true;
            this.maxtempview_label.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtempview_label.Location = new System.Drawing.Point(159, 280);
            this.maxtempview_label.Name = "maxtempview_label";
            this.maxtempview_label.Size = new System.Drawing.Size(56, 41);
            this.maxtempview_label.TabIndex = 5;
            this.maxtempview_label.Text = "0ºC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainTempLabel
            // 
            this.mainTempLabel.AutoSize = true;
            this.mainTempLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTempLabel.Location = new System.Drawing.Point(298, 152);
            this.mainTempLabel.Name = "mainTempLabel";
            this.mainTempLabel.Size = new System.Drawing.Size(71, 52);
            this.mainTempLabel.TabIndex = 8;
            this.mainTempLabel.Text = "0ºC";
            // 
            // minTempView
            // 
            this.minTempView.AutoSize = true;
            this.minTempView.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempView.Location = new System.Drawing.Point(459, 280);
            this.minTempView.Name = "minTempView";
            this.minTempView.Size = new System.Drawing.Size(56, 41);
            this.minTempView.TabIndex = 9;
            this.minTempView.Text = "0ºC";
            // 
            // UpdateWeathertimer
            // 
            this.UpdateWeathertimer.Interval = 20000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.minTempView);
            this.Controls.Add(this.mainTempLabel);
            this.Controls.Add(this.maxtempview_label);
            this.Controls.Add(this.mintemp_label);
            this.Controls.Add(this.maxtemp_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cities_combobox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cities_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxtemp_label;
        private System.Windows.Forms.Label mintemp_label;
        private System.Windows.Forms.Label maxtempview_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label mainTempLabel;
        private System.Windows.Forms.Label minTempView;
        private System.Windows.Forms.Timer UpdateWeathertimer;
    }
}


namespace ER
{
    /// <summary>
    /// Build Form
    /// </summary>
    partial class WinMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private readonly Font DefaultFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        private readonly Padding DefaultPadding = new System.Windows.Forms.Padding(4);
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonMinimum = new System.Windows.Forms.Button();
            this.NotifyIconER = new System.Windows.Forms.NotifyIcon(this.components);
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxER = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxER)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonQuit.BackColor = System.Drawing.Color.Cyan;
            this.ButtonQuit.BackgroundImage = global::ER.ResourceER.IconQuit;
            this.ButtonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuit.ForeColor = System.Drawing.Color.Red;
            this.ButtonQuit.Location = new System.Drawing.Point(488, 8);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Padding = new System.Windows.Forms.Padding(4);
            this.ButtonQuit.Size = new System.Drawing.Size(26, 26);
            this.ButtonQuit.TabIndex = 0;
            this.ButtonQuit.UseVisualStyleBackColor = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // ButtonMinimum
            // 
            this.ButtonMinimum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMinimum.BackColor = System.Drawing.Color.Cyan;
            this.ButtonMinimum.BackgroundImage = global::ER.ResourceER.IconMinimum;
            this.ButtonMinimum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimum.ForeColor = System.Drawing.Color.Red;
            this.ButtonMinimum.Location = new System.Drawing.Point(454, 8);
            this.ButtonMinimum.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonMinimum.Name = "ButtonMinimum";
            this.ButtonMinimum.Padding = new System.Windows.Forms.Padding(4);
            this.ButtonMinimum.Size = new System.Drawing.Size(26, 26);
            this.ButtonMinimum.TabIndex = 1;
            this.ButtonMinimum.UseVisualStyleBackColor = false;
            this.ButtonMinimum.Click += new System.EventHandler(this.ButtonMinimum_Click);
            // 
            // NotifyIconER
            // 
            this.NotifyIconER.Icon = global::ER.ResourceER.IconER;
            this.NotifyIconER.Text = "Ejaculation Recorder";
            this.NotifyIconER.DoubleClick += new System.EventHandler(this.NotifyIconER_DoubleClick);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(42, 8);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Padding = new System.Windows.Forms.Padding(4);
            this.LabelTitle.Size = new System.Drawing.Size(366, 26);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Ejaculation Recorder - Last 8 Times";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxER
            // 
            this.PictureBoxER.Image = global::ER.ResourceER.IconER_Red;
            this.PictureBoxER.Location = new System.Drawing.Point(8, 8);
            this.PictureBoxER.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxER.Name = "PictureBoxER";
            this.PictureBoxER.Size = new System.Drawing.Size(26, 26);
            this.PictureBoxER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxER.TabIndex = 3;
            this.PictureBoxER.TabStop = false;
            // 
            // WinMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(522, 325);
            this.Controls.Add(this.PictureBoxER);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonMinimum);
            this.Controls.Add(this.ButtonQuit);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::ER.ResourceER.IconER;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "WinMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejaculation Recorder";
            this.Load += new System.EventHandler(this.WinMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonQuit;
        private Button ButtonMinimum;
        private NotifyIcon NotifyIconER;
        private Label LabelTitle;
        private PictureBox PictureBoxER;
    }
}
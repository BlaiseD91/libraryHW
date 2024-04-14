

namespace Desktop
{
    partial class LibraryForm
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
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kolcsonzokPanel = new Panel();
            ListBoxKolcsonzok = new ListBox();
            kolcsonzesekPanel = new Panel();
            ListBoxKolcsonzesek = new ListBox();
            BtnVisszahoz = new Button();
            BtnBezar = new Button();
            kolcsonzokPanel.SuspendLayout();
            kolcsonzesekPanel.SuspendLayout();
            SuspendLayout();
            // 
            // kolcsonzokPanel
            // 
            kolcsonzokPanel.Controls.Add(ListBoxKolcsonzok);
            kolcsonzokPanel.Location = new Point(11, 10);
            kolcsonzokPanel.Name = "kolcsonzokPanel";
            kolcsonzokPanel.Size = new Size(216, 425);
            kolcsonzokPanel.TabIndex = 0;
            kolcsonzokPanel.Paint += panel1_Paint;
            // 
            // ListBoxKolcsonzok
            // 
            ListBoxKolcsonzok.FormattingEnabled = true;
            ListBoxKolcsonzok.ItemHeight = 15;
            ListBoxKolcsonzok.Items.AddRange(new object[] { });
            ListBoxKolcsonzok.Location = new Point(0, 0);
            ListBoxKolcsonzok.Name = "ListBoxKolcsonzok";
            ListBoxKolcsonzok.Size = new Size(216, 424);
            ListBoxKolcsonzok.TabIndex = 0;
            ListBoxKolcsonzok.SelectedIndexChanged += ListBoxKolcsonzok_SelectedIndexChanged;
            // 
            // kolcsonzesekPanel
            // 
            kolcsonzesekPanel.Controls.Add(ListBoxKolcsonzesek);
            kolcsonzesekPanel.Location = new Point(238, 10);
            kolcsonzesekPanel.Name = "kolcsonzesekPanel";
            kolcsonzesekPanel.Size = new Size(556, 177);
            kolcsonzesekPanel.TabIndex = 1;
            // 
            // ListBoxKolcsonzesek
            // 
            ListBoxKolcsonzesek.FormattingEnabled = true;
            ListBoxKolcsonzesek.ItemHeight = 15;
            ListBoxKolcsonzesek.Location = new Point(1, 0);
            ListBoxKolcsonzesek.Name = "ListBoxKolcsonzesek";
            ListBoxKolcsonzesek.Size = new Size(555, 169);
            ListBoxKolcsonzesek.TabIndex = 0;
            ListBoxKolcsonzesek.SelectedIndexChanged += ListBoxKolcsonzesek_SelectedIndexChanged;
            // 
            // BtnVisszahoz
            // 
            BtnVisszahoz.BackColor = Color.ForestGreen;
            BtnVisszahoz.FlatAppearance.BorderColor = Color.LimeGreen;
            BtnVisszahoz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVisszahoz.ForeColor = Color.White;
            BtnVisszahoz.Location = new Point(239, 209);
            BtnVisszahoz.Name = "BtnVisszahoz";
            BtnVisszahoz.Size = new Size(129, 39);
            BtnVisszahoz.TabIndex = 2;
            BtnVisszahoz.Text = "Visszahozva";
            BtnVisszahoz.UseVisualStyleBackColor = false;
            BtnVisszahoz.Click += BtnVisszahoz_Click;
            // 
            // BtnBezar
            // 
            BtnBezar.BackColor = Color.FromArgb(192, 0, 0);
            BtnBezar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBezar.ForeColor = Color.White;
            BtnBezar.Location = new Point(665, 399);
            BtnBezar.Name = "BtnBezar";
            BtnBezar.Size = new Size(129, 39);
            BtnBezar.TabIndex = 3;
            BtnBezar.Text = "Bezár";
            BtnBezar.UseVisualStyleBackColor = false;
            BtnBezar.Click += BtnBezar_Click;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBezar);
            Controls.Add(BtnVisszahoz);
            Controls.Add(kolcsonzesekPanel);
            Controls.Add(kolcsonzokPanel);
            Name = "LibraryForm";
            Text = "Library";
            Load += Form1_Load;
            kolcsonzokPanel.ResumeLayout(false);
            kolcsonzesekPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel kolcsonzokPanel;
        private Panel kolcsonzesekPanel;
        private Button BtnVisszahoz;
        private Button BtnBezar;
        private ListBox ListBoxKolcsonzok;
        private ListBox ListBoxKolcsonzesek;
    }
}
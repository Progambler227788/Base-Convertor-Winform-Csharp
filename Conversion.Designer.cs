namespace Convertor_Decimal
{
    partial class Conversion
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
            this.ComboBox_List = new MaterialSkin.Controls.MaterialComboBox();
            this.Check_List = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bin = new System.Windows.Forms.Label();
            this.Convert_Button = new MaterialSkin.Controls.MaterialButton();
            this.Reset = new MaterialSkin.Controls.MaterialButton();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.BinaryBox = new System.Windows.Forms.TextBox();
            this.OctalBox = new System.Windows.Forms.TextBox();
            this.oct = new System.Windows.Forms.Label();
            this.DecimalBox = new System.Windows.Forms.TextBox();
            this.dec = new System.Windows.Forms.Label();
            this.HexaBox = new System.Windows.Forms.TextBox();
            this.hex = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.binr = new System.Windows.Forms.Label();
            this.octr = new System.Windows.Forms.Label();
            this.decr = new System.Windows.Forms.Label();
            this.hexr = new System.Windows.Forms.Label();
            this.length_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_List
            // 
            this.ComboBox_List.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_List.AutoResize = false;
            this.ComboBox_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.ComboBox_List.Depth = 0;
            this.ComboBox_List.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_List.DropDownHeight = 174;
            this.ComboBox_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_List.DropDownWidth = 121;
            this.ComboBox_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_List.FormattingEnabled = true;
            this.ComboBox_List.IntegralHeight = false;
            this.ComboBox_List.ItemHeight = 43;
            this.ComboBox_List.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "HexaDecimal"});
            this.ComboBox_List.Location = new System.Drawing.Point(50, 87);
            this.ComboBox_List.MaxDropDownItems = 4;
            this.ComboBox_List.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_List.Name = "ComboBox_List";
            this.ComboBox_List.Size = new System.Drawing.Size(307, 49);
            this.ComboBox_List.TabIndex = 3;
            this.ComboBox_List.SelectedIndexChanged += new System.EventHandler(this.ComboBox_List_SelectedIndexChanged_1);
            // 
            // Check_List
            // 
            this.Check_List.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Check_List.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Check_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_List.FormattingEnabled = true;
            this.Check_List.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexa Decimal"});
            this.Check_List.Location = new System.Drawing.Point(381, 87);
            this.Check_List.Name = "Check_List";
            this.Check_List.Size = new System.Drawing.Size(175, 112);
            this.Check_List.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Number:";
            // 
            // bin
            // 
            this.bin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bin.AutoSize = true;
            this.bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin.Location = new System.Drawing.Point(661, 36);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(125, 40);
            this.bin.TabIndex = 9;
            this.bin.Text = "Binary";
            this.bin.Visible = false;
            // 
            // Convert_Button
            // 
            this.Convert_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Convert_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Convert_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.Convert_Button.Depth = 0;
            this.Convert_Button.DrawShadows = true;
            this.Convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_Button.HighEmphasis = true;
            this.Convert_Button.Icon = null;
            this.Convert_Button.Location = new System.Drawing.Point(89, 317);
            this.Convert_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Convert_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(96, 36);
            this.Convert_Button.TabIndex = 11;
            this.Convert_Button.Text = "=Convert";
            this.Convert_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Convert_Button.UseAccentColor = false;
            this.Convert_Button.UseVisualStyleBackColor = false;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.Reset.Depth = 0;
            this.Reset.DrawShadows = true;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.HighEmphasis = true;
            this.Reset.Icon = null;
            this.Reset.Location = new System.Drawing.Point(89, 375);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Reset.MouseState = MaterialSkin.MouseState.HOVER;
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(96, 36);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "RESET";
            this.Reset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Reset.UseAccentColor = false;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(283, 227);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(235, 39);
            this.InputBox.TabIndex = 13;
            this.InputBox.Text = "Enter Here";
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            this.InputBox.MouseHover += new System.EventHandler(this.InputBox_MouseHover);
            // 
            // BinaryBox
            // 
            this.BinaryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BinaryBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BinaryBox.Location = new System.Drawing.Point(682, 87);
            this.BinaryBox.Multiline = true;
            this.BinaryBox.Name = "BinaryBox";
            this.BinaryBox.ReadOnly = true;
            this.BinaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BinaryBox.Size = new System.Drawing.Size(162, 82);
            this.BinaryBox.TabIndex = 14;
            this.BinaryBox.Text = "Output here";
            this.BinaryBox.Visible = false;
            // 
            // OctalBox
            // 
            this.OctalBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OctalBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OctalBox.Location = new System.Drawing.Point(682, 223);
            this.OctalBox.Multiline = true;
            this.OctalBox.Name = "OctalBox";
            this.OctalBox.ReadOnly = true;
            this.OctalBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OctalBox.Size = new System.Drawing.Size(162, 83);
            this.OctalBox.TabIndex = 16;
            this.OctalBox.Text = "Output here";
            this.OctalBox.Visible = false;
            // 
            // oct
            // 
            this.oct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oct.AutoSize = true;
            this.oct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct.Location = new System.Drawing.Point(672, 172);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(106, 40);
            this.oct.TabIndex = 15;
            this.oct.Text = "Octal";
            this.oct.Visible = false;
            // 
            // DecimalBox
            // 
            this.DecimalBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DecimalBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DecimalBox.Location = new System.Drawing.Point(685, 360);
            this.DecimalBox.Multiline = true;
            this.DecimalBox.Name = "DecimalBox";
            this.DecimalBox.ReadOnly = true;
            this.DecimalBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DecimalBox.Size = new System.Drawing.Size(162, 76);
            this.DecimalBox.TabIndex = 18;
            this.DecimalBox.Text = "Output here";
            this.DecimalBox.Visible = false;
            // 
            // dec
            // 
            this.dec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dec.AutoSize = true;
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(675, 309);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(154, 40);
            this.dec.TabIndex = 17;
            this.dec.Text = "Decimal";
            this.dec.Visible = false;
            // 
            // HexaBox
            // 
            this.HexaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HexaBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.HexaBox.Location = new System.Drawing.Point(682, 490);
            this.HexaBox.Multiline = true;
            this.HexaBox.Name = "HexaBox";
            this.HexaBox.ReadOnly = true;
            this.HexaBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HexaBox.Size = new System.Drawing.Size(162, 65);
            this.HexaBox.TabIndex = 20;
            this.HexaBox.Text = "Output here";
            this.HexaBox.Visible = false;
            // 
            // hex
            // 
            this.hex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hex.AutoSize = true;
            this.hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex.Location = new System.Drawing.Point(672, 439);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(236, 40);
            this.hex.TabIndex = 19;
            this.hex.Text = "Hexadecimal";
            this.hex.Visible = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(89, 439);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(67, 36);
            this.info.TabIndex = 21;
            this.info.Text = "info";
            this.info.Visible = false;
            // 
            // binr
            // 
            this.binr.AutoSize = true;
            this.binr.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binr.Location = new System.Drawing.Point(859, 133);
            this.binr.Name = "binr";
            this.binr.Size = new System.Drawing.Size(57, 36);
            this.binr.TabIndex = 22;
            this.binr.Text = "bin";
            this.binr.Visible = false;
            // 
            // octr
            // 
            this.octr.AutoSize = true;
            this.octr.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octr.Location = new System.Drawing.Point(859, 270);
            this.octr.Name = "octr";
            this.octr.Size = new System.Drawing.Size(57, 36);
            this.octr.TabIndex = 23;
            this.octr.Text = "oct";
            this.octr.Visible = false;
            // 
            // decr
            // 
            this.decr.AutoSize = true;
            this.decr.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decr.Location = new System.Drawing.Point(859, 400);
            this.decr.Name = "decr";
            this.decr.Size = new System.Drawing.Size(63, 36);
            this.decr.TabIndex = 24;
            this.decr.Text = "dec";
            this.decr.Visible = false;
            // 
            // hexr
            // 
            this.hexr.AutoSize = true;
            this.hexr.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexr.Location = new System.Drawing.Point(859, 519);
            this.hexr.Name = "hexr";
            this.hexr.Size = new System.Drawing.Size(62, 36);
            this.hexr.TabIndex = 25;
            this.hexr.Text = "hex";
            this.hexr.Visible = false;
            // 
            // length_out
            // 
            this.length_out.AutoSize = true;
            this.length_out.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length_out.Location = new System.Drawing.Point(811, 44);
            this.length_out.Name = "length_out";
            this.length_out.Size = new System.Drawing.Size(217, 31);
            this.length_out.TabIndex = 26;
            this.length_out.Text = "Length of Ouput";
            this.length_out.Visible = false;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1047, 558);
            this.Controls.Add(this.length_out);
            this.Controls.Add(this.hexr);
            this.Controls.Add(this.decr);
            this.Controls.Add(this.octr);
            this.Controls.Add(this.binr);
            this.Controls.Add(this.info);
            this.Controls.Add(this.HexaBox);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.DecimalBox);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.OctalBox);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.BinaryBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check_List);
            this.Controls.Add(this.ComboBox_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Convertor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox ComboBox_List;
        private System.Windows.Forms.CheckedListBox Check_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bin;
        private MaterialSkin.Controls.MaterialButton Convert_Button;
        private MaterialSkin.Controls.MaterialButton Reset;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox BinaryBox;
        private System.Windows.Forms.TextBox OctalBox;
        private System.Windows.Forms.Label oct;
        private System.Windows.Forms.TextBox DecimalBox;
        private System.Windows.Forms.Label dec;
        private System.Windows.Forms.TextBox HexaBox;
        private System.Windows.Forms.Label hex;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label binr;
        private System.Windows.Forms.Label octr;
        private System.Windows.Forms.Label decr;
        private System.Windows.Forms.Label hexr;
        private System.Windows.Forms.Label length_out;
    }
}


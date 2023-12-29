namespace NameGenerator
{
    partial class FrmMain
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
            groupBox1 = new GroupBox();
            CbxLists = new ComboBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            NudSuggestionCount = new NumericUpDown();
            NudSyllableCount = new NumericUpDown();
            label1 = new Label();
            BtnGenerate = new Button();
            groupBox3 = new GroupBox();
            TxtOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudSuggestionCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudSyllableCount).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(CbxLists);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Silbenliste";
            // 
            // CbxLists
            // 
            CbxLists.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbxLists.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxLists.FormattingEnabled = true;
            CbxLists.Location = new Point(6, 22);
            CbxLists.Name = "CbxLists";
            CbxLists.Size = new Size(547, 23);
            CbxLists.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(NudSuggestionCount);
            groupBox2.Controls.Add(NudSyllableCount);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(559, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Optionen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Vorschläge:";
            // 
            // NudSuggestionCount
            // 
            NudSuggestionCount.Location = new Point(93, 56);
            NudSuggestionCount.Name = "NudSuggestionCount";
            NudSuggestionCount.Size = new Size(87, 23);
            NudSuggestionCount.TabIndex = 1;
            NudSuggestionCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // NudSyllableCount
            // 
            NudSyllableCount.Location = new Point(93, 27);
            NudSyllableCount.Name = "NudSyllableCount";
            NudSyllableCount.Size = new Size(87, 23);
            NudSyllableCount.TabIndex = 1;
            NudSyllableCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Anzahl SIlben:";
            // 
            // BtnGenerate
            // 
            BtnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnGenerate.Location = new Point(12, 181);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(559, 23);
            BtnGenerate.TabIndex = 2;
            BtnGenerate.Text = "Generieren";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtOutput);
            groupBox3.Location = new Point(12, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(559, 272);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ergebniss";
            // 
            // TxtOutput
            // 
            TxtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtOutput.Location = new Point(6, 22);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(547, 244);
            TxtOutput.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 494);
            Controls.Add(groupBox3);
            Controls.Add(BtnGenerate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "Namegenerator";
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudSuggestionCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudSyllableCount).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CbxLists;
        private GroupBox groupBox2;
        private NumericUpDown NudSyllableCount;
        private Label label1;
        private Label label2;
        private NumericUpDown NudSuggestionCount;
        private Button BtnGenerate;
        private GroupBox groupBox3;
        private TextBox TxtOutput;
    }
}

namespace AppListBoxComboBox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl = new Label();
            listBox = new ListBox();
            cmbBox = new ComboBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnInsert = new Button();
            btnRemoveST = new Button();
            btnRLast = new Button();
            btnInstances = new Button();
            btnAddMiddle = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Calisto MT", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl.Location = new Point(31, 43);
            lbl.Margin = new Padding(6, 0, 6, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(166, 36);
            lbl.TabIndex = 0;
            lbl.Text = "ELEMENT:";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 35;
            listBox.Items.AddRange(new object[] { "First", "Second", "Third" });
            listBox.Location = new Point(31, 146);
            listBox.Margin = new Padding(6, 5, 6, 5);
            listBox.Name = "listBox";
            listBox.Size = new Size(322, 319);
            listBox.TabIndex = 1;
            // 
            // cmbBox
            // 
            cmbBox.FormattingEnabled = true;
            cmbBox.Items.AddRange(new object[] { "One", "Two", "Three" });
            cmbBox.Location = new Point(485, 84);
            cmbBox.Margin = new Padding(6, 5, 6, 5);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(295, 43);
            cmbBox.TabIndex = 2;
            cmbBox.SelectedIndexChanged += cmbBox_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(425, 286);
            btnAdd.Margin = new Padding(6, 5, 6, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 95);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(425, 402);
            btnClear.Margin = new Padding(6, 5, 6, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 94);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(15, 502);
            btnInsert.Margin = new Padding(6, 5, 6, 5);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(188, 95);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert first";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnRemoveST
            // 
            btnRemoveST.Location = new Point(215, 505);
            btnRemoveST.Margin = new Padding(6, 5, 6, 5);
            btnRemoveST.Name = "btnRemoveST";
            btnRemoveST.Size = new Size(188, 97);
            btnRemoveST.TabIndex = 6;
            btnRemoveST.Text = "Remove first";
            btnRemoveST.UseVisualStyleBackColor = true;
            btnRemoveST.Click += btnRemoveST_Click;
            // 
            // btnRLast
            // 
            btnRLast.Location = new Point(415, 506);
            btnRLast.Margin = new Padding(6, 5, 6, 5);
            btnRLast.Name = "btnRLast";
            btnRLast.Size = new Size(188, 96);
            btnRLast.TabIndex = 7;
            btnRLast.Text = "Remove last";
            btnRLast.UseVisualStyleBackColor = true;
            btnRLast.Click += btnRLast_Click;
            // 
            // btnInstances
            // 
            btnInstances.Location = new Point(625, 286);
            btnInstances.Margin = new Padding(6, 5, 6, 5);
            btnInstances.Name = "btnInstances";
            btnInstances.Size = new Size(173, 139);
            btnInstances.TabIndex = 8;
            btnInstances.Text = "Remove instances";
            btnInstances.UseVisualStyleBackColor = true;
            btnInstances.Click += btnInstances_Click;
            // 
            // btnAddMiddle
            // 
            btnAddMiddle.Location = new Point(625, 447);
            btnAddMiddle.Margin = new Padding(6, 5, 6, 5);
            btnAddMiddle.Name = "btnAddMiddle";
            btnAddMiddle.Size = new Size(173, 139);
            btnAddMiddle.TabIndex = 9;
            btnAddMiddle.Text = "Add in the middle";
            btnAddMiddle.UseVisualStyleBackColor = true;
            btnAddMiddle.Click += btnAddMiddle_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 42);
            textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 611);
            Controls.Add(textBox1);
            Controls.Add(btnAddMiddle);
            Controls.Add(btnInstances);
            Controls.Add(btnRLast);
            Controls.Add(btnRemoveST);
            Controls.Add(btnInsert);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(cmbBox);
            Controls.Add(listBox);
            Controls.Add(lbl);
            Font = new Font("Calisto MT", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "ComboBox & ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private System.Windows.Forms.ListBox listBox;
        private ComboBox cmbBox;
        private Button btnAdd;
        private Button btnClear;
        private Button btnInsert;
        private Button btnRemoveST;
        private Button btnRLast;
        private Button btnInstances;
        private Button btnAddMiddle;
        private TextBox textBox1;
    }
}

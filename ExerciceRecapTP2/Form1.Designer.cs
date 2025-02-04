namespace ExerciceRecapTP2
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
            table = new TableLayoutPanel();
            buttonEgal = new Button();
            buttonPoint = new Button();
            buttonN0 = new Button();
            buttonPlusMinus = new Button();
            buttonMClear = new Button();
            buttonAddition = new Button();
            buttonN3 = new Button();
            buttonN2 = new Button();
            buttonN1 = new Button();
            buttonMRappel = new Button();
            buttonSoustraction = new Button();
            buttonN6 = new Button();
            buttonN5 = new Button();
            buttonN4 = new Button();
            buttonMMoins = new Button();
            buttonMultiplication = new Button();
            buttonN9 = new Button();
            buttonN8 = new Button();
            buttonN7 = new Button();
            buttonMPlus = new Button();
            buttonDivision = new Button();
            buttonBackspace = new Button();
            buttonClear = new Button();
            txtAffichage = new TextBox();
            buttonPercent = new Button();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 5;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.Controls.Add(buttonEgal, 3, 5);
            table.Controls.Add(buttonPoint, 2, 5);
            table.Controls.Add(buttonN0, 1, 5);
            table.Controls.Add(buttonPlusMinus, 0, 5);
            table.Controls.Add(buttonMClear, 4, 4);
            table.Controls.Add(buttonAddition, 3, 4);
            table.Controls.Add(buttonN3, 2, 4);
            table.Controls.Add(buttonN2, 1, 4);
            table.Controls.Add(buttonN1, 0, 4);
            table.Controls.Add(buttonMRappel, 4, 3);
            table.Controls.Add(buttonSoustraction, 3, 3);
            table.Controls.Add(buttonN6, 2, 3);
            table.Controls.Add(buttonN5, 1, 3);
            table.Controls.Add(buttonN4, 0, 3);
            table.Controls.Add(buttonMMoins, 4, 2);
            table.Controls.Add(buttonMultiplication, 3, 2);
            table.Controls.Add(buttonN9, 2, 2);
            table.Controls.Add(buttonN8, 1, 2);
            table.Controls.Add(buttonN7, 0, 2);
            table.Controls.Add(buttonMPlus, 4, 1);
            table.Controls.Add(buttonDivision, 3, 1);
            table.Controls.Add(buttonBackspace, 2, 1);
            table.Controls.Add(buttonClear, 1, 1);
            table.Controls.Add(txtAffichage, 0, 0);
            table.Controls.Add(buttonPercent, 0, 1);
            table.Dock = DockStyle.Fill;
            table.Location = new Point(0, 0);
            table.Name = "table";
            table.RowCount = 6;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            table.Size = new Size(344, 451);
            table.TabIndex = 0;
            // 
            // buttonEgal
            // 
            buttonEgal.BackColor = Color.YellowGreen;
            table.SetColumnSpan(buttonEgal, 2);
            buttonEgal.Dock = DockStyle.Fill;
            buttonEgal.Font = new Font("Segoe UI", 20F);
            buttonEgal.Location = new Point(207, 381);
            buttonEgal.Name = "buttonEgal";
            buttonEgal.Size = new Size(134, 67);
            buttonEgal.TabIndex = 24;
            buttonEgal.Text = "=";
            buttonEgal.UseVisualStyleBackColor = false;
            buttonEgal.Click += buttonEgal_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Dock = DockStyle.Fill;
            buttonPoint.Font = new Font("Segoe UI", 20F);
            buttonPoint.Location = new Point(139, 381);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(62, 67);
            buttonPoint.TabIndex = 23;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // buttonN0
            // 
            buttonN0.BackColor = Color.CornflowerBlue;
            buttonN0.Dock = DockStyle.Fill;
            buttonN0.Font = new Font("Segoe UI", 20F);
            buttonN0.ForeColor = SystemColors.Control;
            buttonN0.Location = new Point(71, 381);
            buttonN0.Name = "buttonN0";
            buttonN0.Size = new Size(62, 67);
            buttonN0.TabIndex = 22;
            buttonN0.Text = "&0";
            buttonN0.UseVisualStyleBackColor = false;
            buttonN0.Click += buttonN_Click;
            // 
            // buttonPlusMinus
            // 
            buttonPlusMinus.Dock = DockStyle.Fill;
            buttonPlusMinus.Font = new Font("Segoe UI", 20F);
            buttonPlusMinus.Location = new Point(3, 381);
            buttonPlusMinus.Name = "buttonPlusMinus";
            buttonPlusMinus.Size = new Size(62, 67);
            buttonPlusMinus.TabIndex = 21;
            buttonPlusMinus.Text = "±";
            buttonPlusMinus.UseVisualStyleBackColor = true;
            buttonPlusMinus.Click += buttonPlusMinus_Click;
            // 
            // buttonMClear
            // 
            buttonMClear.BackColor = Color.LightSalmon;
            buttonMClear.Dock = DockStyle.Fill;
            buttonMClear.Font = new Font("Segoe UI", 15F);
            buttonMClear.Location = new Point(275, 309);
            buttonMClear.Name = "buttonMClear";
            buttonMClear.Size = new Size(66, 66);
            buttonMClear.TabIndex = 20;
            buttonMClear.Text = "MC";
            buttonMClear.UseVisualStyleBackColor = false;
            buttonMClear.Click += buttonMClear_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.Dock = DockStyle.Fill;
            buttonAddition.Font = new Font("Segoe UI", 20F);
            buttonAddition.Location = new Point(207, 309);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(62, 66);
            buttonAddition.TabIndex = 19;
            buttonAddition.Text = "&+";
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += buttonAddition_Click;
            // 
            // buttonN3
            // 
            buttonN3.BackColor = Color.CornflowerBlue;
            buttonN3.Dock = DockStyle.Fill;
            buttonN3.Font = new Font("Segoe UI", 20F);
            buttonN3.ForeColor = SystemColors.Control;
            buttonN3.Location = new Point(139, 309);
            buttonN3.Name = "buttonN3";
            buttonN3.Size = new Size(62, 66);
            buttonN3.TabIndex = 18;
            buttonN3.Text = "&3";
            buttonN3.UseVisualStyleBackColor = false;
            buttonN3.Click += buttonN_Click;
            // 
            // buttonN2
            // 
            buttonN2.BackColor = Color.CornflowerBlue;
            buttonN2.Dock = DockStyle.Fill;
            buttonN2.Font = new Font("Segoe UI", 20F);
            buttonN2.ForeColor = SystemColors.Control;
            buttonN2.Location = new Point(71, 309);
            buttonN2.Name = "buttonN2";
            buttonN2.Size = new Size(62, 66);
            buttonN2.TabIndex = 17;
            buttonN2.Text = "&2";
            buttonN2.UseVisualStyleBackColor = false;
            buttonN2.Click += buttonN_Click;
            // 
            // buttonN1
            // 
            buttonN1.BackColor = Color.CornflowerBlue;
            buttonN1.Dock = DockStyle.Fill;
            buttonN1.Font = new Font("Segoe UI", 20F);
            buttonN1.ForeColor = SystemColors.Control;
            buttonN1.Location = new Point(3, 309);
            buttonN1.Name = "buttonN1";
            buttonN1.Size = new Size(62, 66);
            buttonN1.TabIndex = 16;
            buttonN1.Text = "&1";
            buttonN1.UseVisualStyleBackColor = false;
            buttonN1.Click += buttonN_Click;
            // 
            // buttonMRappel
            // 
            buttonMRappel.BackColor = Color.LightSalmon;
            buttonMRappel.Dock = DockStyle.Fill;
            buttonMRappel.Font = new Font("Segoe UI", 15F);
            buttonMRappel.Location = new Point(275, 237);
            buttonMRappel.Name = "buttonMRappel";
            buttonMRappel.Size = new Size(66, 66);
            buttonMRappel.TabIndex = 15;
            buttonMRappel.Text = "MR";
            buttonMRappel.UseVisualStyleBackColor = false;
            buttonMRappel.Click += buttonMRecall_Click;
            // 
            // buttonSoustraction
            // 
            buttonSoustraction.Dock = DockStyle.Fill;
            buttonSoustraction.Font = new Font("Segoe UI", 20F);
            buttonSoustraction.Location = new Point(207, 237);
            buttonSoustraction.Name = "buttonSoustraction";
            buttonSoustraction.Size = new Size(62, 66);
            buttonSoustraction.TabIndex = 14;
            buttonSoustraction.Text = "&-";
            buttonSoustraction.UseVisualStyleBackColor = true;
            buttonSoustraction.Click += buttonSoustraction_Click;
            // 
            // buttonN6
            // 
            buttonN6.BackColor = Color.CornflowerBlue;
            buttonN6.Dock = DockStyle.Fill;
            buttonN6.Font = new Font("Segoe UI", 20F);
            buttonN6.ForeColor = SystemColors.Control;
            buttonN6.Location = new Point(139, 237);
            buttonN6.Name = "buttonN6";
            buttonN6.Size = new Size(62, 66);
            buttonN6.TabIndex = 13;
            buttonN6.Text = "&6";
            buttonN6.UseVisualStyleBackColor = false;
            buttonN6.Click += buttonN_Click;
            // 
            // buttonN5
            // 
            buttonN5.BackColor = Color.CornflowerBlue;
            buttonN5.Dock = DockStyle.Fill;
            buttonN5.Font = new Font("Segoe UI", 20F);
            buttonN5.ForeColor = SystemColors.Control;
            buttonN5.Location = new Point(71, 237);
            buttonN5.Name = "buttonN5";
            buttonN5.Size = new Size(62, 66);
            buttonN5.TabIndex = 12;
            buttonN5.Text = "&5";
            buttonN5.UseVisualStyleBackColor = false;
            buttonN5.Click += buttonN_Click;
            // 
            // buttonN4
            // 
            buttonN4.BackColor = Color.CornflowerBlue;
            buttonN4.Dock = DockStyle.Fill;
            buttonN4.Font = new Font("Segoe UI", 20F);
            buttonN4.ForeColor = SystemColors.Control;
            buttonN4.Location = new Point(3, 237);
            buttonN4.Name = "buttonN4";
            buttonN4.Size = new Size(62, 66);
            buttonN4.TabIndex = 11;
            buttonN4.Text = "&4";
            buttonN4.UseVisualStyleBackColor = false;
            buttonN4.Click += buttonN_Click;
            // 
            // buttonMMoins
            // 
            buttonMMoins.BackColor = Color.LightSalmon;
            buttonMMoins.Dock = DockStyle.Fill;
            buttonMMoins.Font = new Font("Segoe UI", 15F);
            buttonMMoins.Location = new Point(275, 165);
            buttonMMoins.Name = "buttonMMoins";
            buttonMMoins.Size = new Size(66, 66);
            buttonMMoins.TabIndex = 10;
            buttonMMoins.Text = "M-";
            buttonMMoins.UseVisualStyleBackColor = false;
            buttonMMoins.Click += buttonMMoins_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.Dock = DockStyle.Fill;
            buttonMultiplication.Font = new Font("Segoe UI", 20F);
            buttonMultiplication.Location = new Point(207, 165);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(62, 66);
            buttonMultiplication.TabIndex = 9;
            buttonMultiplication.Text = "&*";
            buttonMultiplication.UseVisualStyleBackColor = true;
            buttonMultiplication.Click += buttonMultiplication_Click;
            // 
            // buttonN9
            // 
            buttonN9.BackColor = Color.CornflowerBlue;
            buttonN9.Dock = DockStyle.Fill;
            buttonN9.Font = new Font("Segoe UI", 20F);
            buttonN9.ForeColor = SystemColors.Control;
            buttonN9.Location = new Point(139, 165);
            buttonN9.Name = "buttonN9";
            buttonN9.Size = new Size(62, 66);
            buttonN9.TabIndex = 8;
            buttonN9.Text = "&9";
            buttonN9.UseVisualStyleBackColor = false;
            buttonN9.Click += buttonN_Click;
            // 
            // buttonN8
            // 
            buttonN8.BackColor = Color.CornflowerBlue;
            buttonN8.Dock = DockStyle.Fill;
            buttonN8.Font = new Font("Segoe UI", 20F);
            buttonN8.ForeColor = SystemColors.Control;
            buttonN8.Location = new Point(71, 165);
            buttonN8.Name = "buttonN8";
            buttonN8.Size = new Size(62, 66);
            buttonN8.TabIndex = 7;
            buttonN8.Text = "&8";
            buttonN8.UseVisualStyleBackColor = false;
            buttonN8.Click += buttonN_Click;
            // 
            // buttonN7
            // 
            buttonN7.BackColor = Color.CornflowerBlue;
            buttonN7.Dock = DockStyle.Fill;
            buttonN7.Font = new Font("Segoe UI", 20F);
            buttonN7.ForeColor = SystemColors.Control;
            buttonN7.Location = new Point(3, 165);
            buttonN7.Name = "buttonN7";
            buttonN7.Size = new Size(62, 66);
            buttonN7.TabIndex = 6;
            buttonN7.Text = "&7";
            buttonN7.UseVisualStyleBackColor = false;
            buttonN7.Click += buttonN_Click;
            // 
            // buttonMPlus
            // 
            buttonMPlus.BackColor = Color.LightSalmon;
            buttonMPlus.Dock = DockStyle.Fill;
            buttonMPlus.Font = new Font("Segoe UI", 15F);
            buttonMPlus.Location = new Point(275, 93);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.Size = new Size(66, 66);
            buttonMPlus.TabIndex = 5;
            buttonMPlus.Text = "M+";
            buttonMPlus.UseVisualStyleBackColor = false;
            buttonMPlus.Click += buttonMPlus_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Dock = DockStyle.Fill;
            buttonDivision.Font = new Font("Segoe UI", 20F);
            buttonDivision.Location = new Point(207, 93);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(62, 66);
            buttonDivision.TabIndex = 4;
            buttonDivision.Text = "&/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.BackColor = Color.White;
            buttonBackspace.Dock = DockStyle.Fill;
            buttonBackspace.Font = new Font("Segoe UI", 20F);
            buttonBackspace.ForeColor = Color.Brown;
            buttonBackspace.Location = new Point(139, 93);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(62, 66);
            buttonBackspace.TabIndex = 3;
            buttonBackspace.Text = "⌫";
            buttonBackspace.UseVisualStyleBackColor = false;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonClear
            // 
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Font = new Font("Segoe UI", 20F);
            buttonClear.ForeColor = Color.Brown;
            buttonClear.Location = new Point(71, 93);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(62, 66);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // txtAffichage
            // 
            txtAffichage.AcceptsReturn = true;
            txtAffichage.AcceptsTab = true;
            txtAffichage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table.SetColumnSpan(txtAffichage, 5);
            txtAffichage.Enabled = false;
            txtAffichage.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAffichage.Location = new Point(3, 3);
            txtAffichage.Multiline = true;
            txtAffichage.Name = "txtAffichage";
            txtAffichage.ReadOnly = true;
            txtAffichage.Size = new Size(338, 84);
            txtAffichage.TabIndex = 0;
            txtAffichage.KeyDown += txtAffichage_KeyDown;
            // 
            // buttonPercent
            // 
            buttonPercent.Dock = DockStyle.Fill;
            buttonPercent.Font = new Font("Segoe UI", 20F);
            buttonPercent.Location = new Point(3, 93);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(62, 66);
            buttonPercent.TabIndex = 1;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(344, 451);
            Controls.Add(table);
            MinimumSize = new Size(340, 390);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            table.ResumeLayout(false);
            table.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel table;
        private Button buttonEgal;
        private Button buttonPoint;
        private Button buttonN0;
        private Button buttonPlusMinus;
        private Button buttonMClear;
        private Button buttonAddition;
        private Button buttonN3;
        private Button buttonN2;
        private Button buttonN1;
        private Button buttonMRappel;
        private Button buttonSoustraction;
        private Button buttonN6;
        private Button buttonN5;
        private Button buttonN4;
        private Button buttonMMoins;
        private Button buttonMultiplication;
        private Button buttonN9;
        private Button buttonN8;
        private Button buttonN7;
        private Button buttonMPlus;
        private Button buttonDivision;
        private Button buttonBackspace;
        private Button buttonClear;
        private TextBox txtAffichage;
        private Button buttonPercent;
        private Button btn8;
    }
}

namespace Spv.WinForms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            bindingSource3 = new BindingSource(components);
            bindingSource4 = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            panel6 = new Panel();
            dataGridView4 = new DataGridView();
            panel5 = new Panel();
            tbOrderNb = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            splitter1 = new Splitter();
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView3 = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            label1 = new Label();
            tbTextFilter = new TextBox();
            tabPage2 = new TabPage();
            panel7 = new Panel();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(916, 500);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(splitter1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(908, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Новый заказ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(211, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(694, 466);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridView4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 120);
            panel6.Name = "panel6";
            panel6.Size = new Size(694, 346);
            panel6.TabIndex = 1;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(694, 346);
            dataGridView4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbOrderNb);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(btnClear);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(694, 120);
            panel5.TabIndex = 0;
            // 
            // tbOrderNb
            // 
            tbOrderNb.Location = new Point(104, 8);
            tbOrderNb.Name = "tbOrderNb";
            tbOrderNb.Size = new Size(114, 23);
            tbOrderNb.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 11);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 12;
            label2.Text = "номер заказа";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(247, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "сохранить в базу";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(449, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "очистить";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(208, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 466);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 466);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 424);
            panel3.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(205, 424);
            dataGridView3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbTextFilter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 42);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(133, 7);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 10;
            button2.Text = "добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Поиск";
            // 
            // tbTextFilter
            // 
            tbTextFilter.Location = new Point(51, 8);
            tbTextFilter.Name = "tbTextFilter";
            tbTextFilter.Size = new Size(76, 23);
            tbTextFilter.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(908, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(dataGridView2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(902, 466);
            panel7.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(902, 466);
            dataGridView2.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 500);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Spv";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private BindingSource bindingSource3;
        private BindingSource bindingSource4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TabPage tabPage2;
        private Panel panel4;
        private Panel panel6;
        private DataGridView dataGridView4;
        private Panel panel5;
        private Button btnSave;
        private Button btnClear;
        private Splitter splitter1;
        private DataGridView dataGridView3;
        private Button button2;
        private Label label1;
        private TextBox tbTextFilter;
        private Panel panel7;
        private DataGridView dataGridView2;
        private TextBox tbOrderNb;
        private Label label2;
    }
}

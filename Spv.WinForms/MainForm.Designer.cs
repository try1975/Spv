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
            button1 = new Button();
            bindingSource2 = new BindingSource(components);
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            bindingSource3 = new BindingSource(components);
            button2 = new Button();
            dataGridView4 = new DataGridView();
            bindingSource4 = new BindingSource(components);
            tbTextFilter = new TextBox();
            label1 = new Label();
            button3 = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(798, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(798, 38);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(298, 76);
            dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(36, 99);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(186, 356);
            dataGridView3.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(228, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(323, 120);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(869, 335);
            dataGridView4.TabIndex = 5;
            // 
            // tbTextFilter
            // 
            tbTextFilter.Location = new Point(92, 70);
            tbTextFilter.Name = "tbTextFilter";
            tbTextFilter.Size = new Size(130, 23);
            tbTextFilter.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 73);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Поиск";
            // 
            // button3
            // 
            button3.Location = new Point(323, 38);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 8;
            button3.Text = "новый заквз";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(448, 38);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "сохранить в базу";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 522);
            Controls.Add(btnSave);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(tbTextFilter);
            Controls.Add(dataGridView4);
            Controls.Add(button2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Spv";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button button1;
        private BindingSource bindingSource2;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private BindingSource bindingSource3;
        private Button button2;
        private DataGridView dataGridView4;
        private BindingSource bindingSource4;
        private TextBox tbTextFilter;
        private Label label1;
        private Button button3;
        private Button btnSave;
    }
}

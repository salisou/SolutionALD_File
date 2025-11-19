namespace WinFormsApp1.Views
{
    partial class DemoListBox
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
            listView1 = new ListView();
            txtTask = new TextBox();
            button1 = new Button();
            label1 = new Label();
            txtClear = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(257, 243);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(12, 52);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(257, 23);
            txtTask.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "ToDo List";
            // 
            // txtClear
            // 
            txtClear.Location = new Point(194, 330);
            txtClear.Name = "txtClear";
            txtClear.Size = new Size(75, 23);
            txtClear.TabIndex = 4;
            txtClear.Text = "Clear";
            txtClear.UseVisualStyleBackColor = true;
            txtClear.Click += txtClear_Click;
            // 
            // DemoListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 363);
            Controls.Add(txtClear);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtTask);
            Controls.Add(listView1);
            Name = "DemoListBox";
            Text = "DemoListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtTask;
        private Button button1;
        private Label label1;
        private Button txtClear;
    }
}
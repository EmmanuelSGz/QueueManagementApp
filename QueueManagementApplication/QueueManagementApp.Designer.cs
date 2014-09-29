namespace QueueManagementApplication
{
    partial class QueueManagementApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enqueueComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queueListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.enqueueComplainTextBox);
            this.groupBox1.Controls.Add(this.enqueueNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(97, 104);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 2;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // enqueueComplainTextBox
            // 
            this.enqueueComplainTextBox.Location = new System.Drawing.Point(98, 63);
            this.enqueueComplainTextBox.Name = "enqueueComplainTextBox";
            this.enqueueComplainTextBox.Size = new System.Drawing.Size(100, 20);
            this.enqueueComplainTextBox.TabIndex = 0;
            // 
            // enqueueNameTextBox
            // 
            this.enqueueNameTextBox.Location = new System.Drawing.Point(98, 25);
            this.enqueueNameTextBox.Name = "enqueueNameTextBox";
            this.enqueueNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.enqueueNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dequeueComplainTextBox);
            this.groupBox2.Controls.Add(this.dequeueNameTextBox);
            this.groupBox2.Controls.Add(this.serialNoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(422, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(259, 21);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 2;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial No";
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(114, 78);
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(100, 20);
            this.dequeueComplainTextBox.TabIndex = 0;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.Location = new System.Drawing.Point(114, 49);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.dequeueNameTextBox.TabIndex = 0;
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(114, 19);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialNoTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queueListView);
            this.groupBox3.Location = new System.Drawing.Point(190, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 153);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // queueListView
            // 
            this.queueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.queueListView.FullRowSelect = true;
            this.queueListView.GridLines = true;
            this.queueListView.Location = new System.Drawing.Point(6, 34);
            this.queueListView.MultiSelect = false;
            this.queueListView.Name = "queueListView";
            this.queueListView.Size = new System.Drawing.Size(312, 113);
            this.queueListView.TabIndex = 0;
            this.queueListView.UseCompatibleStateImageBehavior = false;
            this.queueListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 81;
            // 
            // QueueManagementApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 338);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QueueManagementApp";
            this.Text = "Customer Queue Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enqueueComplainTextBox;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView queueListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}


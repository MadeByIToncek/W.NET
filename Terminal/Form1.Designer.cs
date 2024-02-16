namespace Terminal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            listBox1 = new ListBox();
            empty1 = new Button();
            note = new Button();
            refresh = new Button();
            submit = new Button();
            remove = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(877, 649);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(895, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(366, 524);
            listBox1.TabIndex = 1;
            // 
            // empty1
            // 
            empty1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            empty1.Location = new Point(895, 542);
            empty1.Name = "empty1";
            empty1.Size = new Size(118, 42);
            empty1.TabIndex = 2;
            empty1.Text = "<empty>";
            empty1.UseVisualStyleBackColor = true;
            // 
            // note
            // 
            note.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            note.Location = new Point(1143, 542);
            note.Name = "note";
            note.Size = new Size(118, 42);
            note.TabIndex = 4;
            note.Text = "Poznámka";
            note.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            refresh.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            refresh.Location = new Point(895, 590);
            refresh.Name = "refresh";
            refresh.Size = new Size(73, 71);
            refresh.TabIndex = 5;
            refresh.Text = "🔁";
            refresh.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            submit.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            submit.Location = new Point(974, 590);
            submit.Name = "submit";
            submit.Size = new Size(287, 71);
            submit.TabIndex = 6;
            submit.Text = "Objednat";
            submit.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            remove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            remove.Location = new Point(1019, 542);
            remove.Name = "remove";
            remove.Size = new Size(118, 42);
            remove.TabIndex = 9;
            remove.Text = "Odebrat";
            remove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 673);
            Controls.Add(remove);
            Controls.Add(submit);
            Controls.Add(refresh);
            Controls.Add(note);
            Controls.Add(empty1);
            Controls.Add(listBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBox1;
        private Button empty1;
        private Button note;
        private Button refresh;
        private Button submit;
        private Button remove;
    }
}

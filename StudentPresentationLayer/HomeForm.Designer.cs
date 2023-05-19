namespace StudentPresentationLayer
{
    partial class HomeForm
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
            dgv_student = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_id = new TextBox();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_address = new TextBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(12, 11);
            dgv_student.Name = "dgv_student";
            dgv_student.RowTemplate.Height = 25;
            dgv_student.Size = new Size(446, 513);
            dgv_student.TabIndex = 0;
            dgv_student.RowHeaderMouseDoubleClick += dgv_student_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 76);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 114);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 153);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(530, 42);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(158, 23);
            txt_id.TabIndex = 5;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(530, 76);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(158, 23);
            txt_fname.TabIndex = 6;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(533, 111);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(158, 23);
            txt_lname.TabIndex = 7;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(533, 153);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(158, 23);
            txt_address.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(496, 212);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(136, 29);
            btn_add.TabIndex = 9;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(496, 272);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(136, 29);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(496, 332);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(136, 29);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 536);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txt_address);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(txt_id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_student);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeForm";
            Text = "Form1";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_id;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_address;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
    }
}
namespace DisconectMode
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
            txt_fname = new TextBox();
            txt_laname = new TextBox();
            txt_address = new TextBox();
            txt_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_delete = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            dgv_student = new DataGridView();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(888, 43);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(188, 27);
            txt_fname.TabIndex = 0;
            // 
            // txt_laname
            // 
            txt_laname.Location = new Point(888, 101);
            txt_laname.Name = "txt_laname";
            txt_laname.Size = new Size(188, 27);
            txt_laname.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(888, 239);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(188, 27);
            txt_address.TabIndex = 2;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(888, 172);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(188, 27);
            txt_id.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(761, 49);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "first name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(761, 117);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(810, 179);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(774, 239);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(664, 325);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 36);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(834, 325);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 36);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(1015, 325);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(77, 36);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(31, 12);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 51;
            dgv_student.RowTemplate.Height = 29;
            dgv_student.Size = new Size(603, 643);
            dgv_student.TabIndex = 11;
            dgv_student.RowHeaderMouseDoubleClick += dgv_student_RowHeaderMouseDoubleClick;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(834, 440);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(77, 36);
            btn_save.TabIndex = 12;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 671);
            Controls.Add(btn_save);
            Controls.Add(dgv_student);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Controls.Add(txt_address);
            Controls.Add(txt_laname);
            Controls.Add(txt_fname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_fname;
        private TextBox txt_laname;
        private TextBox txt_address;
        private TextBox txt_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_edit;
        private DataGridView dgv_student;
        private Button btn_save;
    }
}
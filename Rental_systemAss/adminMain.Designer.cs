namespace Rental_systemAss
{
    partial class adminMain
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
            this.Videos = new System.Windows.Forms.GroupBox();
            this.video_del = new System.Windows.Forms.Button();
            this.edit_video = new System.Windows.Forms.Button();
            this.txt_genre = new System.Windows.Forms.RichTextBox();
            this.add_video = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_video_year = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_video_ratting = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_video_name = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.GroupBox();
            this.delete_user = new System.Windows.Forms.Button();
            this.edit_user = new System.Windows.Forms.Button();
            this.user_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cont_user = new System.Windows.Forms.RichTextBox();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.txt_name = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBack = new System.Windows.Forms.Button();
            this.customer_sec = new System.Windows.Forms.Button();
            this.allvideosbtn = new System.Windows.Forms.Button();
            this.Videos.SuspendLayout();
            this.customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Videos
            // 
            this.Videos.Controls.Add(this.video_del);
            this.Videos.Controls.Add(this.edit_video);
            this.Videos.Controls.Add(this.txt_genre);
            this.Videos.Controls.Add(this.add_video);
            this.Videos.Controls.Add(this.label8);
            this.Videos.Controls.Add(this.txt_video_year);
            this.Videos.Controls.Add(this.label7);
            this.Videos.Controls.Add(this.txt_video_ratting);
            this.Videos.Controls.Add(this.label6);
            this.Videos.Controls.Add(this.txt_video_name);
            this.Videos.Controls.Add(this.label5);
            this.Videos.Controls.Add(this.customers);
            this.Videos.Location = new System.Drawing.Point(50, 80);
            this.Videos.Name = "Videos";
            this.Videos.Size = new System.Drawing.Size(996, 529);
            this.Videos.TabIndex = 0;
            this.Videos.TabStop = false;
            this.Videos.Text = "Videos";
            // 
            // video_del
            // 
            this.video_del.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.video_del.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.video_del.Location = new System.Drawing.Point(619, 481);
            this.video_del.Name = "video_del";
            this.video_del.Size = new System.Drawing.Size(190, 42);
            this.video_del.TabIndex = 11;
            this.video_del.Text = "DELETE VIDEO";
            this.video_del.UseVisualStyleBackColor = false;
            this.video_del.Click += new System.EventHandler(this.video_del_Click);
            // 
            // edit_video
            // 
            this.edit_video.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit_video.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_video.Location = new System.Drawing.Point(389, 479);
            this.edit_video.Name = "edit_video";
            this.edit_video.Size = new System.Drawing.Size(190, 42);
            this.edit_video.TabIndex = 9;
            this.edit_video.Text = "EDIT VIDEO";
            this.edit_video.UseVisualStyleBackColor = false;
            this.edit_video.Click += new System.EventHandler(this.edit_video_Click);
            // 
            // txt_genre
            // 
            this.txt_genre.Location = new System.Drawing.Point(803, 447);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(114, 28);
            this.txt_genre.TabIndex = 14;
            this.txt_genre.Text = "";
            // 
            // add_video
            // 
            this.add_video.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_video.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_video.Location = new System.Drawing.Point(157, 477);
            this.add_video.Name = "add_video";
            this.add_video.Size = new System.Drawing.Size(190, 46);
            this.add_video.TabIndex = 10;
            this.add_video.Text = "ADD VIDEO";
            this.add_video.UseVisualStyleBackColor = false;
            this.add_video.Click += new System.EventHandler(this.add_video_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(731, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Genre";
            // 
            // txt_video_year
            // 
            this.txt_video_year.Location = new System.Drawing.Point(595, 443);
            this.txt_video_year.Name = "txt_video_year";
            this.txt_video_year.Size = new System.Drawing.Size(114, 28);
            this.txt_video_year.TabIndex = 12;
            this.txt_video_year.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(535, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Year";
            // 
            // txt_video_ratting
            // 
            this.txt_video_ratting.Location = new System.Drawing.Point(403, 439);
            this.txt_video_ratting.Name = "txt_video_ratting";
            this.txt_video_ratting.Size = new System.Drawing.Size(114, 28);
            this.txt_video_ratting.TabIndex = 10;
            this.txt_video_ratting.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(301, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ratings";
            // 
            // txt_video_name
            // 
            this.txt_video_name.Location = new System.Drawing.Point(166, 435);
            this.txt_video_name.Name = "txt_video_name";
            this.txt_video_name.Size = new System.Drawing.Size(114, 28);
            this.txt_video_name.TabIndex = 9;
            this.txt_video_name.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Video Name";
            // 
            // customers
            // 
            this.customers.Controls.Add(this.delete_user);
            this.customers.Controls.Add(this.edit_user);
            this.customers.Controls.Add(this.user_add);
            this.customers.Controls.Add(this.label4);
            this.customers.Controls.Add(this.label3);
            this.customers.Controls.Add(this.label2);
            this.customers.Controls.Add(this.txt_cont_user);
            this.customers.Controls.Add(this.txt_address);
            this.customers.Controls.Add(this.txt_name);
            this.customers.Controls.Add(this.dataGridView1);
            this.customers.Location = new System.Drawing.Point(17, 34);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(938, 388);
            this.customers.TabIndex = 0;
            this.customers.TabStop = false;
            this.customers.Text = "Customers";
            // 
            // delete_user
            // 
            this.delete_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_user.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_user.Location = new System.Drawing.Point(557, 340);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(190, 42);
            this.delete_user.TabIndex = 8;
            this.delete_user.Text = "DELETE USER";
            this.delete_user.UseVisualStyleBackColor = false;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // edit_user
            // 
            this.edit_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit_user.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_user.Location = new System.Drawing.Point(327, 338);
            this.edit_user.Name = "edit_user";
            this.edit_user.Size = new System.Drawing.Size(190, 42);
            this.edit_user.TabIndex = 5;
            this.edit_user.Text = "EDIT USER";
            this.edit_user.UseVisualStyleBackColor = false;
            this.edit_user.Click += new System.EventHandler(this.edit_user_Click);
            // 
            // user_add
            // 
            this.user_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_add.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_add.Location = new System.Drawing.Point(95, 336);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(190, 46);
            this.user_add.TabIndex = 6;
            this.user_add.Text = "Add User";
            this.user_add.UseVisualStyleBackColor = false;
            this.user_add.Click += new System.EventHandler(this.user_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(563, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(322, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Name";
            // 
            // txt_cont_user
            // 
            this.txt_cont_user.Location = new System.Drawing.Point(655, 302);
            this.txt_cont_user.Name = "txt_cont_user";
            this.txt_cont_user.Size = new System.Drawing.Size(151, 31);
            this.txt_cont_user.TabIndex = 3;
            this.txt_cont_user.Text = "";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(408, 299);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(135, 31);
            this.txt_address.TabIndex = 2;
            this.txt_address.Text = "";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(171, 299);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(114, 28);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "";
            this.txt_name.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(370, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Video Rental System";
            // 
            // returnBack
            // 
            this.returnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnBack.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnBack.Location = new System.Drawing.Point(856, 18);
            this.returnBack.Name = "returnBack";
            this.returnBack.Size = new System.Drawing.Size(190, 52);
            this.returnBack.TabIndex = 2;
            this.returnBack.Text = "Return Back";
            this.returnBack.UseVisualStyleBackColor = false;
            this.returnBack.Click += new System.EventHandler(this.returnBack_Click);
            // 
            // customer_sec
            // 
            this.customer_sec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customer_sec.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_sec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_sec.Location = new System.Drawing.Point(140, 18);
            this.customer_sec.Name = "customer_sec";
            this.customer_sec.Size = new System.Drawing.Size(168, 62);
            this.customer_sec.TabIndex = 3;
            this.customer_sec.Text = "Customer Section";
            this.customer_sec.UseVisualStyleBackColor = false;
            this.customer_sec.Click += new System.EventHandler(this.customer_sec_Click);
            // 
            // allvideosbtn
            // 
            this.allvideosbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allvideosbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allvideosbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allvideosbtn.Location = new System.Drawing.Point(12, 18);
            this.allvideosbtn.Name = "allvideosbtn";
            this.allvideosbtn.Size = new System.Drawing.Size(122, 62);
            this.allvideosbtn.TabIndex = 4;
            this.allvideosbtn.Text = "Video Section";
            this.allvideosbtn.UseVisualStyleBackColor = false;
            this.allvideosbtn.Click += new System.EventHandler(this.allvideosbtn_Click);
            // 
            // adminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1079, 621);
            this.Controls.Add(this.allvideosbtn);
            this.Controls.Add(this.customer_sec);
            this.Controls.Add(this.returnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Videos);
            this.Name = "adminMain";
            this.Text = "adminMain";
            this.Videos.ResumeLayout(false);
            this.Videos.PerformLayout();
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Videos;
        private System.Windows.Forms.GroupBox customers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_cont_user;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.RichTextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBack;
        private System.Windows.Forms.Button customer_sec;
        private System.Windows.Forms.Button allvideosbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_video_ratting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_video_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button video_del;
        private System.Windows.Forms.Button edit_video;
        private System.Windows.Forms.RichTextBox txt_genre;
        private System.Windows.Forms.Button add_video;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_video_year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Button edit_user;
        private System.Windows.Forms.Button user_add;
    }
}
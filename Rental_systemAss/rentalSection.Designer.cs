namespace Rental_systemAss
{
    partial class rentalSection
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allvideosbtn = new System.Windows.Forms.Button();
            this.customer_sec = new System.Windows.Forms.Button();
            this.RETURN = new System.Windows.Forms.Button();
            this.user_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mov_id = new System.Windows.Forms.RichTextBox();
            this.cus_id = new System.Windows.Forms.RichTextBox();
            this.show_rent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue / Return Movie Here";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 274);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // allvideosbtn
            // 
            this.allvideosbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allvideosbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allvideosbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allvideosbtn.Location = new System.Drawing.Point(12, 43);
            this.allvideosbtn.Name = "allvideosbtn";
            this.allvideosbtn.Size = new System.Drawing.Size(122, 62);
            this.allvideosbtn.TabIndex = 6;
            this.allvideosbtn.Text = "Video Section";
            this.allvideosbtn.UseVisualStyleBackColor = false;
            this.allvideosbtn.Click += new System.EventHandler(this.allvideosbtn_Click);
            // 
            // customer_sec
            // 
            this.customer_sec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customer_sec.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_sec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_sec.Location = new System.Drawing.Point(140, 43);
            this.customer_sec.Name = "customer_sec";
            this.customer_sec.Size = new System.Drawing.Size(168, 62);
            this.customer_sec.TabIndex = 5;
            this.customer_sec.Text = "Customer Section";
            this.customer_sec.UseVisualStyleBackColor = false;
            this.customer_sec.Click += new System.EventHandler(this.customer_sec_Click);
            // 
            // RETURN
            // 
            this.RETURN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RETURN.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RETURN.Location = new System.Drawing.Point(806, 119);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(190, 42);
            this.RETURN.TabIndex = 9;
            this.RETURN.Text = "RETURN";
            this.RETURN.UseVisualStyleBackColor = false;
            this.RETURN.Click += new System.EventHandler(this.RETURN_Click);
            // 
            // user_add
            // 
            this.user_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_add.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_add.Location = new System.Drawing.Point(574, 117);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(190, 46);
            this.user_add.TabIndex = 11;
            this.user_add.Text = "ISSUE";
            this.user_add.UseVisualStyleBackColor = false;
            this.user_add.Click += new System.EventHandler(this.user_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(775, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Movie ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(485, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer ID";
            // 
            // mov_id
            // 
            this.mov_id.Location = new System.Drawing.Point(887, 80);
            this.mov_id.Name = "mov_id";
            this.mov_id.Size = new System.Drawing.Size(135, 31);
            this.mov_id.TabIndex = 8;
            this.mov_id.Text = "";
            // 
            // cus_id
            // 
            this.cus_id.Location = new System.Drawing.Point(650, 80);
            this.cus_id.Name = "cus_id";
            this.cus_id.Size = new System.Drawing.Size(114, 28);
            this.cus_id.TabIndex = 7;
            this.cus_id.Text = "";
            // 
            // show_rent
            // 
            this.show_rent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_rent.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_rent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_rent.Location = new System.Drawing.Point(314, 99);
            this.show_rent.Name = "show_rent";
            this.show_rent.Size = new System.Drawing.Size(168, 62);
            this.show_rent.TabIndex = 13;
            this.show_rent.Text = "Show Rentals";
            this.show_rent.UseVisualStyleBackColor = false;
            this.show_rent.Click += new System.EventHandler(this.show_rent_Click);
            // 
            // rentalSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1033, 464);
            this.Controls.Add(this.show_rent);
            this.Controls.Add(this.RETURN);
            this.Controls.Add(this.user_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mov_id);
            this.Controls.Add(this.cus_id);
            this.Controls.Add(this.allvideosbtn);
            this.Controls.Add(this.customer_sec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "rentalSection";
            this.Text = "rentalSection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button allvideosbtn;
        private System.Windows.Forms.Button customer_sec;
        private System.Windows.Forms.Button RETURN;
        private System.Windows.Forms.Button user_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button show_rent;
        public System.Windows.Forms.RichTextBox cus_id;
        public System.Windows.Forms.RichTextBox mov_id;
    }
}
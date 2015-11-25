namespace DatuBaze
{
    partial class Form1
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
            this.DatuBazesParvaldiba = new System.Windows.Forms.Label();
            this.IzveletiesFailu = new System.Windows.Forms.Button();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Saglabat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pub_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pub_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.au_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.au_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.au_lanme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.title_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pub_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.authors = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // DatuBazesParvaldiba
            // 
            this.DatuBazesParvaldiba.AutoSize = true;
            this.DatuBazesParvaldiba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatuBazesParvaldiba.Location = new System.Drawing.Point(12, 25);
            this.DatuBazesParvaldiba.Name = "DatuBazesParvaldiba";
            this.DatuBazesParvaldiba.Size = new System.Drawing.Size(174, 18);
            this.DatuBazesParvaldiba.TabIndex = 0;
            this.DatuBazesParvaldiba.Text = "Datu bāzes pārvaldība";
            this.DatuBazesParvaldiba.Click += new System.EventHandler(this.DatuBazesParvaldiba_Click);
            // 
            // IzveletiesFailu
            // 
            this.IzveletiesFailu.Location = new System.Drawing.Point(15, 61);
            this.IzveletiesFailu.Name = "IzveletiesFailu";
            this.IzveletiesFailu.Size = new System.Drawing.Size(97, 23);
            this.IzveletiesFailu.TabIndex = 1;
            this.IzveletiesFailu.Text = "Izvēlēties failu";
            this.IzveletiesFailu.UseVisualStyleBackColor = true;
            this.IzveletiesFailu.Click += new System.EventHandler(this.IzveletiesFailu_Click);
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(138, 61);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(121, 21);
            this.TableComboBox.TabIndex = 2;
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title_id,
            this.title,
            this.pubdate,
            this.pub_name,
            this.authors});
            this.dataGridView1.Location = new System.Drawing.Point(15, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 212);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Saglabat
            // 
            this.Saglabat.Location = new System.Drawing.Point(15, 308);
            this.Saglabat.Name = "Saglabat";
            this.Saglabat.Size = new System.Drawing.Size(97, 23);
            this.Saglabat.TabIndex = 4;
            this.Saglabat.Text = "Saglabāt";
            this.Saglabat.UseVisualStyleBackColor = true;
            this.Saglabat.Visible = false;
            this.Saglabat.Click += new System.EventHandler(this.Saglabat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.au_id,
            this.au_fname,
            this.au_lanme,
            this.address,
            this.books});
            this.dataGridView2.Location = new System.Drawing.Point(15, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(446, 212);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pub_id,
            this.pub_name1,
            this.city,
            this.country});
            this.dataGridView3.Location = new System.Drawing.Point(15, 90);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(463, 212);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.Visible = false;
            // 
            // pub_id
            // 
            this.pub_id.DataPropertyName = "pub_id";
            this.pub_id.HeaderText = "ID";
            this.pub_id.Name = "pub_id";
            // 
            // pub_name1
            // 
            this.pub_name1.DataPropertyName = "pub_name";
            this.pub_name1.HeaderText = "Nosaukums";
            this.pub_name1.Name = "pub_name1";
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "Pilsēta";
            this.city.Name = "city";
            // 
            // country
            // 
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "Valsts";
            this.country.Name = "country";
            // 
            // au_id
            // 
            this.au_id.DataPropertyName = "au_id";
            this.au_id.HeaderText = "ID";
            this.au_id.Name = "au_id";
            // 
            // au_fname
            // 
            this.au_fname.DataPropertyName = "au_fname";
            this.au_fname.HeaderText = "Autora v.";
            this.au_fname.Name = "au_fname";
            // 
            // au_lanme
            // 
            this.au_lanme.DataPropertyName = "au_lname";
            this.au_lanme.HeaderText = "Autora uzv.";
            this.au_lanme.Name = "au_lanme";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Adrese";
            this.address.Name = "address";
            // 
            // books
            // 
            this.books.DataPropertyName = "title_id";
            this.books.HeaderText = "Grāmatas";
            this.books.Name = "books";
            this.books.Visible = false;
            // 
            // title_id
            // 
            this.title_id.DataPropertyName = "title_id";
            this.title_id.HeaderText = "ID";
            this.title_id.Name = "title_id";
            this.title_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Nosaukums";
            this.title.Name = "title";
            this.title.Width = 150;
            // 
            // pubdate
            // 
            this.pubdate.DataPropertyName = "pubdate";
            this.pubdate.HeaderText = "Izdošanas_datums";
            this.pubdate.Name = "pubdate";
            // 
            // pub_name
            // 
            this.pub_name.DataPropertyName = "pub_id";
            this.pub_name.HeaderText = "Izdevējs";
            this.pub_name.Name = "pub_name";
            this.pub_name.Width = 150;
            // 
            // authors
            // 
            this.authors.DataPropertyName = "au_id";
            this.authors.HeaderText = "Autori";
            this.authors.Name = "authors";
            this.authors.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authors.Visible = false;
            this.authors.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 356);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.Saglabat);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.IzveletiesFailu);
            this.Controls.Add(this.DatuBazesParvaldiba);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatuBazesParvaldiba;
        private System.Windows.Forms.Button IzveletiesFailu;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Saglabat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pub_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pub_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubdate;
        private System.Windows.Forms.DataGridViewComboBoxColumn pub_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn au_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn au_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn au_lanme;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewComboBoxColumn books;
    }
}


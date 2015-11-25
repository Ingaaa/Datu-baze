using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DatuBaze
{
    public partial class Form1 : Form
    {
        string failasaturs;
        DataTable PublishersFK;
        DataTable AuthorsFK;
        DataTable TitlesFK;
        DataSet ds;
        SqlDataAdapter daTitles;
        SqlDataAdapter daPublishers;
        SqlDataAdapter daAuthors;
        SqlDataAdapter daTitleauthor;
        SqlDataAdapter daAuthorsFK;
        SqlDataAdapter daTitlesFK;
        SqlDataAdapter daPublishersFK;
        SqlConnection myConnection;
        SqlCommandBuilder sqlcb1;
        SqlCommandBuilder sqlcb2;
        SqlCommandBuilder sqlcb3;
        public Form1()
        {
            InitializeComponent();
            TableComboBox.Items.Add("Grāmata");
            TableComboBox.Items.Add("Izdevējs");
            TableComboBox.Items.Add("Autors");
        }

        private void DatuBazesParvaldiba_Click(object sender, EventArgs e)
        {

        }

        private void IzveletiesFailu_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = openFileDialog1.ShowDialog(); // Atver dialogu, kur var izvēlēties failu
                if (result == DialogResult.OK) //Lai nospiežot cancel programma nenosprāgtu
                {
                    string file = openFileDialog1.FileName;     //Saglabā faila atrašanās vietu
                    failasaturs = File.ReadAllText(file);   // Simbolu virknē failasaturs saglabā visu faila tekstu
                }

                myConnection = new SqlConnection();
                myConnection.ConnectionString = failasaturs; //Data Source=USER;initial catalog=md2;Integrated Security = True
                myConnection.Open();

                ds = new DataSet("Data");

                string sql1 = "select title_id, title, pubdate, titles.pub_id FROM titles";
                daTitles = new SqlDataAdapter(sql1, myConnection); //Inicializēju datu adapteri
                daTitles.FillSchema(ds, SchemaType.Source, "Titles"); //DatuSetam pievienoju tabulas Titles shēmu (relācijas, utt)
                daTitles.Fill(ds, "Titles");  //No datu adaptera DataSetā pievienoju tabulu Titles
                dataGridView1.DataSource = ds.Tables["Titles"];    //Datu režģim avotu norādu tabulu Titles 

                string sql2 = "select au_id, au_fname, au_lname, address from Authors";
                daAuthors = new SqlDataAdapter(sql2, myConnection);
                daAuthors.FillSchema(ds, SchemaType.Source, "Authors");
                daAuthors.Fill(ds, "Authors");
                dataGridView2.DataSource = ds.Tables["Authors"];

                string sql3 = "select pub_id, pub_name, city, country from Publishers";
                daPublishers = new SqlDataAdapter(sql3, myConnection);
                daPublishers.FillSchema(ds, SchemaType.Source, "Publishers");
                daPublishers.Fill(ds, "Publishers");
                dataGridView3.DataSource = ds.Tables["Publishers"];

                string sql4 = "select * from Titleauthor";
                daTitleauthor = new SqlDataAdapter(sql4, myConnection);
                daTitleauthor.FillSchema(ds, SchemaType.Source, "Titleauthor");
                daTitleauthor.Fill(ds, "Titleauthor");

                //Veidoju jaunas tabulas, kuras tiek izmantotas par datu avotu kolonām kuras ir FK.
                PublishersFK = new DataTable();
                string sql5 = "select * from Publishers";
                daPublishersFK = new SqlDataAdapter(sql5, myConnection);
                daPublishersFK.Fill(PublishersFK);
                daPublishersFK.FillSchema(ds, SchemaType.Source, "PublishersFK");
                daPublishersFK.Fill(ds, "PublishersFK");
                DataGridViewComboBoxColumn col1 = (DataGridViewComboBoxColumn)dataGridView1.Columns["pub_name"];
                col1.DataSource = PublishersFK;
                col1.ValueMember = "pub_id";
                col1.DisplayMember = "pub_name";

                AuthorsFK = new DataTable();
                string sql6 = "select authors.au_id, Authors.au_fname+' '+ Authors.au_lname as authors from authors";
                daAuthorsFK = new SqlDataAdapter(sql6, myConnection);
                daAuthorsFK.Fill(AuthorsFK);
                daAuthorsFK.FillSchema(ds, SchemaType.Source, "AuthorsFK");
                daAuthorsFK.Fill(ds, "AuthorsFK");
                DataGridViewComboBoxColumn col2 = (DataGridViewComboBoxColumn)dataGridView1.Columns["authors"];
                col2.DataSource = AuthorsFK;
                col2.ValueMember = "au_id";
                col2.DisplayMember = "authors";

                TitlesFK = new DataTable();
                string sql7 = "select title_id, title from titles";
                daTitlesFK = new SqlDataAdapter(sql7, myConnection);
                daTitlesFK.Fill(TitlesFK);
                daTitlesFK.FillSchema(ds, SchemaType.Source, "TitlesFK");
                daTitlesFK.Fill(ds, "TitlesFK");
                DataGridViewComboBoxColumn col3 = (DataGridViewComboBoxColumn)dataGridView2.Columns["books"];
                col3.DataSource = TitlesFK;
                col3.ValueMember = "title_id";
                col3.DisplayMember = "title";

                myConnection.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Cannot open a connection without specifying a data source or server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (SqlException ex)
            {
                if (ex.Number == 53)
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\nAn error has occurred while establishing a connection to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == -2)
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\nTimeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 17)
                {
                    MessageBox.Show("Error:" + ex.Number.ToString() + "\nInvalid server name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 4060)
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\nInvalid database name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 18456)
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\nInvalid user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 547)
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Saglabat_Click(object sender, EventArgs e)
        {
            try
            {

                if (TableComboBox.SelectedIndex == 0)
                {
                    sqlcb1 = new SqlCommandBuilder(daTitles);
                    daTitles.Update(ds, "Titles");
                    MessageBox.Show("Information updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (TableComboBox.SelectedIndex == 1)
                {
                    sqlcb2 = new SqlCommandBuilder(daPublishers);
                    daPublishers.Update(ds, "Publishers");
                    MessageBox.Show("Information updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (TableComboBox.SelectedIndex == 2)
                {
                    sqlcb3 = new SqlCommandBuilder(daAuthors);
                    daAuthors.Update(ds, "Authors");
                    MessageBox.Show("Information updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format of a value is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An attempt to execute an INSERT, UPDATE, or DELETE statement resulted in zero records affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Number.ToString() + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Saglabat.Show();
            if (TableComboBox.SelectedIndex == 0)
            {
                dataGridView1.Show();
                dataGridView2.Hide();
                dataGridView3.Hide();
            }
            if (TableComboBox.SelectedIndex == 1)
            {
                dataGridView1.Hide();
                dataGridView2.Hide();
                dataGridView3.Show();
            }
            if (TableComboBox.SelectedIndex == 2)
            {
                dataGridView3.Hide();
                dataGridView1.Hide();
                dataGridView2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

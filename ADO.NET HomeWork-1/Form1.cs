using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_HomeWork_1
{
    public partial class Form1 : Form
    {
        SqlConnection? sqlServer = null;
        SqlDataReader? reader = null;
        DataTable? table = null;

        public Form1()
        {
            InitializeComponent();
            var conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            sqlServer = new(connectionString: conStr);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                sqlServer?.Open();
                SqlCommand cmd = new SqlCommand("Select * From Authors", sqlServer);
                dataGridView1.DataSource = null;

                table = new DataTable();
                reader = cmd.ExecuteReader();
                int line = 0;
                while (reader.Read())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.Columns.Add(reader.GetName(i));
                        }
                        line++;
                    }

                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
            }
            finally
            {
                sqlServer?.Close();
                reader?.Close();
            }
            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlServer?.Open();
                var query = "Insert INTO Authors(Id,Firstname,Lastname) Values (@id,@firstname,@lastname)";
                var cmd = new SqlCommand(query, sqlServer);
                cmd.Parameters.AddWithValue("id", txtBoxId.Text);
                cmd.Parameters.AddWithValue("firstname", txtBoxName.Text);
                cmd.Parameters.AddWithValue("lastname", txtBoxSurname.Text);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlServer?.Close();
            }
            
        }
    }



}

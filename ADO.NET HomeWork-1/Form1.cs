using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_HomeWork_1
{
    public partial class Form1 : Form
    {
        SqlConnection? sqlConnection = null;
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
            SqlDataReader? reader = null;
            try
            {
                sqlServer?.Open();
                var query = "select * from Authors Where FirstName = @p1";
                var query2 = "select * from Authors Where FirstName = @p2";
                var query3 = "select * from Authors Where FirstName = @p3";
                var command = new SqlCommand(query, sqlServer);
                var command2 = new SqlCommand(query2, sqlServer);
                var command3 = new SqlCommand(query3, sqlServer);

                command.Parameters.AddWithValue("@p1", txtBoxId);
                command.Parameters.AddWithValue("@p2", txtBoxName);
                command.Parameters.AddWithValue("@p3", txtBoxSurname);

            }
            finally
            {
                sqlServer?.Close();
                reader?.Close();
            }
            dataGridView1.DataSource = table;

        }
    }



}

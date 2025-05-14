using System.Data;
using Npgsql;

namespace PR2
{
    public partial class DebtorsForm : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader reader;
        DataTable dataTable;

        public DebtorsForm()
        {
            InitializeComponent();
            conn = new NpgsqlConnection("Host=localhost;Port=5432;Database=YP_DB;Username=postgres;Password=1219;");
            conn.Open();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            LoadDebtors();
        }

        void LoadDebtors()
        {
            string query;
            cmd = new NpgsqlCommand("select \"полное_имя\", \"телефон\",\"автор\", \"название\", \"количество\", \"дата_выдачи\", date_part('day', current_timestamp - \"дата_выдачи\"::timestamp) дней_задолженности from выдачи  join читатели on читатели.\"ин\" = \"ин_читателя\"  join книги on \"ин_книги\" = книги.\"ин\"  where дата_возврата is null;", conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Panel debtorPanel = new Panel();
                {
                    debtorPanel.Location = new Point(0, 0);
                    debtorPanel.Name = "debtorPanel";
                    debtorPanel.Size = new Size(debtorsList.Width - 8, 80);
                    debtorPanel.TabIndex = 0;
                    debtorPanel.BackColor = Color.FromArgb(138, 180, 251);
                }
                Label debtorsInfo = new Label();
                {
                    debtorsInfo.AutoSize = true;
                    debtorsInfo.Location = new Point(30, 12);
                    debtorsInfo.Name = "debtorsInfo";
                    debtorsInfo.Size = new Size(21, 19);
                    debtorsInfo.TabIndex = 0;
                    debtorsInfo.Text = reader["полное_имя"].ToString() + "/" + reader["телефон"].ToString();
                    debtorsInfo.ForeColor = Color.Black;

                }
                Label bookInfo = new Label();
                {
                    bookInfo.AutoSize = true;
                    bookInfo.Location = new Point(30, 52);
                    bookInfo.Name = "bookInfo";
                    bookInfo.Size = new Size(21, 19);
                    bookInfo.TabIndex = 1;
                    bookInfo.Text = reader["автор"].ToString() + "/" + reader["название"].ToString() + "/" + reader["количество"].ToString() + "/" + reader["дата_выдачи"].ToString() + "/" + reader["дней_задолженности"].ToString();
                    bookInfo.ForeColor = Color.Red;
                }
                debtorPanel.Controls.Add(debtorsInfo);
                debtorPanel.Controls.Add(bookInfo);
                debtorsList.Controls.Add(debtorPanel);
            }

        }
    }
}

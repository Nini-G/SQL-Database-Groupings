using System.Data;
using System.Data.SqlClient;

namespace SQLdatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        //Main
        public static void main(string[] args)
        {
            Application.Run(new Form1());
        }

        //Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            Display();
        }

        //Create Display class
        private void Display()
        {
            con = new SqlConnection("Data Source=NBPC1958\\SQLEXPRESS;Initial Catalog=employeeSalary;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select * from Employee_Salary_Table", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=NBPC1958\\SQLEXPRESS;Initial Catalog=employeeSalary;Integrated Security=True");
            con.Open();
            int a = Convert.ToInt32(textBox1.Text);
            string b = textBox2.Text;
            int c = Convert.ToInt32(textBox3.Text);
            cmd = new SqlCommand("Insert Into Employee_Salary_Table values ('" + a + "','" + b + "', '" + c + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One Record Added");
            Display();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
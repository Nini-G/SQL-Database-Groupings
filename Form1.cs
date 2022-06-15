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
    }
}
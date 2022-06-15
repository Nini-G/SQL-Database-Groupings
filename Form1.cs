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


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;
using System.Data;
namespace WPFFeedBackProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connstring = "SERVER=148.72.192.236;PORT=3306;DATABASE=sentosamail_db_v6.0;UID=sentosamailuser;PASSWORD=SrplSentosamail@777*;";

        // MySqlConnection con = null;

        public MainWindow()
        {
            InitializeComponent();
            DateTime d = new DateTime();
            d = DateTime.Now;
        labeldate.Content = d.ToString("dd/MM/yyyy");

        }
        private void insertfeedback()
        {
            //submitBtn.IsEnabled = false;
            //string mob = mobile.Text;
            ////  int cust_id = getCustId(mob);
            //if (cust_id == 0) { MessageBox.Show("Something went wrong, please try again"); }
            //else
            //{
            //    MessageBox.Show("Cust_id : " + cust_id + ", inserting record");
            //}
            //submitBtn.IsEnabled = true;
        }
        //private int insertNewfeedback()
        //{
        //    ////    MySqlConnection con = new MySqlConnection(connstring);
        //    //MySqlCommand MyCommand = new MySqlCommand("INSERT INTO customer_enquiries (first_name,mobile,dob,email,enq_desc,food,staff,response_time,cleanliness) Values (@first_name,@mobile,@dob,@enq_desc,@food,@staff,@response_time,@cleanliness)", con);
        //    //MyCommand.Parameters.AddWithValue("@fname", first_name.Text);
        //    //MyCommand.Parameters.AddWithValue("@mobile", mobile.Text);
        //    //MyCommand.Parameters.AddWithValue("@dob", dob.Text);
        //    //MyCommand.Parameters.AddWithValue("@email", email.Text);
        //    //MyCommand.Parameters.AddWithValue("@enq_desc", enq_desc.Text);
        //    //MyCommand.Parameters.AddWithValue("@food", email.Text);
        //    //MyCommand.Parameters.AddWithValue("@email", email.Text);

        //    //MessageBox.Show("Successfully addedd");

        //    //clear_Text();

        //    //fetchdata();
        //    //con.Open();
        //    //return MyCommand.ExecuteNonQuery();

        //}
        //private int getCustId(string mob)
        //{
        //    //string connstring = "SERVER=148.72.192.236;PORT=3306;DATABASE=sentosamail_db_v6.0;UID=sentosamailV60;PASSWORD=SrplSentosamail@777*;";
        //    //int response = 0;
        //    //try
        //    //{
        //    //    MySqlConnection con = new MySqlConnection(connstring);
        //    //    con.Open();
        //    //    string sql = "select cust_id from customer where mobile='" + mob + "'";
        //    //    MySqlDataAdapter ad = new MySqlDataAdapter(sql, con);
        //    //    DataTable dt = new DataTable();
        //    //    ad.Fill(dt);
        //    //    DataColumn[] keyColumns = new DataColumn[1];
        //    //    keyColumns[0] = dt.Columns["<id>"];
        //    //    dt.PrimaryKey = keyColumns;
        //    //    response = Convert.ToInt32(dt.Rows[0][0]);
        //    //}
        //    //catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show(ex.Message); }
        //    //return response;
        //}
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            insertfeedback();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

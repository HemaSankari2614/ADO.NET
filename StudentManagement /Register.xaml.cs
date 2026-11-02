using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
namespace Practiceforunstd2
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        string con = "Data Source=tcp:server-shop-min.database.windows.net,1433;Initial Catalog=demo_shopping;Persist Security Info=True;User ID=hsvtech;Password=jsquare@123;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;Command Timeout=0";
        public Register()
        {
            InitializeComponent();
            //string query = "Create Table Students (StudentId Numeric(10), Name varchar(20), Email Varchar(20), Department Varchar(20), Age Numeric(20), Phone Numeric (20))";
            //SqlConnection sql = new SqlConnection(con);
            //SqlCommand cmd = new SqlCommand(query, sql);
            //sql.Open();
            //cmd.ExecuteNonQuery();
            //sql.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string query = "Insert into Students Values (@StudentId, @Name, @Email, @Department, @Age, @Phone)";
            SqlConnection sql = new SqlConnection(con);
            SqlCommand cmds = new SqlCommand(query, sql);
            cmds.Parameters.AddWithValue("@StudentId", txtstudnetid.Text);
            cmds.Parameters.AddWithValue("@Name", txtName.Text);
            cmds.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmds.Parameters.AddWithValue("@Department", txtDepartment.Text);
            cmds.Parameters.AddWithValue("@Age", txtAge.Text);
            cmds.Parameters.AddWithValue("@Phone", txtPhone.Text);
            sql.Open();
            cmds.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Student Added");


        }

        private void btnviewstudent_Click(object sender, RoutedEventArgs e)
        {
            string query = "Select Name, Email, Phone from students where StudentId = @StudentId";
            SqlConnection sql = new SqlConnection(con);
            SqlCommand cmds = new SqlCommand(query, sql);
            cmds.Parameters.AddWithValue("@StudentId", txtstudnetid.Text);

            sql.Open();
            SqlDataReader reader = cmds.ExecuteReader();
            if(reader.Read())
            {
                string name = reader["Name"].ToString();
                string email = reader["Email"].ToString();
                string phone = reader["Phone"].ToString();
                MessageBox.Show(@$"Name : {name} Email : {email} Phone : {phone}");
            }
            else
            {
                MessageBox.Show("Student Not Found");
            }

            sql.Close();
     

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string query = "Update Students Set Name = @Name, Email = @Email, Department = @Department, Age = @Age, Phone = @Phone from students where StudentId = @StudentId";
            SqlConnection sql = new SqlConnection(con);
            SqlCommand cmds = new SqlCommand(query, sql);
            cmds.Parameters.AddWithValue("@StudentId", txtstudnetid.Text);
            cmds.Parameters.AddWithValue("@Name", txtName.Text);
            cmds.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmds.Parameters.AddWithValue("@Department", txtDepartment.Text);
            cmds.Parameters.AddWithValue("@Age", txtAge.Text);
            cmds.Parameters.AddWithValue("@Phone", txtPhone.Text);
            sql.Open();
            cmds.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Student Updated");


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string query = "Delete from students where StudentId = @StudentId";
            SqlConnection sql = new SqlConnection(con);
            SqlCommand cmds = new SqlCommand(query, sql);
            cmds.Parameters.AddWithValue("@StudentId", txtstudnetid.Text);
            sql.Open();
            cmds.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Student Deleted");

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
         
            txtName.Text = "";
            txtDepartment.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
    }
}

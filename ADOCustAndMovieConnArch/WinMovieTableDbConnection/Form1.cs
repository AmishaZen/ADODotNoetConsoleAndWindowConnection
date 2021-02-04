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
using System.Configuration;

namespace WinMovieTableDbConnection
{
    public partial class Form1 : Form
    {
        SqlConnection cn =  new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
         SqlCommand cmd = null;
       SqlDataReader dr = null;
       DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            actorName.Visible = false;
            movieName.Visible = false;
            ticketSold.Visible = false;
            dgvForShowdetails.Visible = false;
            lblMovieId.Visible = false;
            lblMovieName.Visible = false;
            lblActor.Visible = false;
            lblTicket.Visible = false;
            txtMovieId.Visible = false;
            btnShow.Visible = false;

            txtMName.Visible = false;
            txtMovId.Visible = false;
            txtTicket.Visible = false;
            txtActor.Visible = false;
            btnUpdate.Visible = false;

            btnMovieName.Visible = false;
            ShowData();
        }

        private void dgvForShowdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowmovie_Click(object sender, EventArgs e)
        {
            dgvForShowdetails.Visible = true;
            lblMovieId.Visible = false;
            lblMovieName.Visible = false;
            lblActor.Visible = false;
            lblTicket.Visible = false;
            txtMovieId.Visible = false;
            btnShow.Visible = false;

            txtMName.Visible = false;
            txtMovId.Visible = false;
            txtTicket.Visible = false;
            txtActor.Visible = false;
            btnUpdate.Visible = false;
            actorName.Visible = false;
            movieName.Visible = false;
            ticketSold.Visible = false;
            btnMovieName.Visible = false;
            dgvForShowdetails.Visible = true;
            ShowData();
        }

        private void btnMovieDetail_Click(object sender, EventArgs e)
        {
            lblMovieId.Visible = false;
            lblMovieName.Visible = false;
            lblActor.Visible = false;
            lblTicket.Visible = false;
            txtMovieId.Visible = false;
            lblMovieId.Visible = true;
            lblMovieName.Visible = true;
            lblActor.Visible = true;
            lblTicket.Visible = true;
            btnShow.Visible = true;
            txtMovieId.Visible = true;

            txtMName.Visible = false;
            txtMovId.Visible = false;
            txtTicket.Visible = false;
            txtActor.Visible = false;
            btnUpdate.Visible = false;
            dgvForShowdetails.Visible = false;
            btnMovieName.Visible = true;
        

        
        }
        public void ShowData()
        {
            try
            {
                using (cmd = new SqlCommand("select * from MovieTable", cn))
                {
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgvForShowdetails.DataSource = dt;
                    //dgvEmployeeData.DataSource = dt;
                    cn.Close();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        
            
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            actorName.Visible = true;
            movieName.Visible = true;
            ticketSold.Visible = true;
            
            try
            {
                using (cmd = new SqlCommand("sp_ShowMovieDetails", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@movieId", SqlDbType.Int).Value = txtMovieId.Text;
                    cn.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        movieName.Text = dr["MovieName"].ToString();
                        actorName.Text = dr["Actor"].ToString();
                        ticketSold.Text = dr["Tickets"].ToString();
                           
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            lblMovieId.Visible = true;
            lblMovieName.Visible = true;
            lblActor.Visible = true;
            lblTicket.Visible = true;
            txtMovieId.Visible = false;
            btnShow.Visible = false;
            txtMovId.Visible = true;
            txtMName.Visible = true;
            txtTicket.Visible = true;
            txtActor.Visible = true;
            btnUpdate.Visible = true;
            dgvForShowdetails.Visible = false;

            btnMovieName.Visible = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(cmd= new SqlCommand("sp_UpdateMovieTable",cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("movieId", SqlDbType.Int).Value = txtMovId.Text;
                cmd.Parameters.Add("movieName", SqlDbType.VarChar).Value = txtMName.Text;
                cmd.Parameters.Add("movieActor", SqlDbType.VarChar).Value = txtActor.Text;
                cmd.Parameters.Add("ticketSold", SqlDbType.Int).Value = txtTicket.Text;
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");
                cn.Close();

                txtMovId.Text = " ";
                txtMName.Text = " ";
                txtTicket.Text = " ";
                txtActor.Text = " ";

            }
        }

        private void btnMovieName_Click(object sender, EventArgs e)
        {
            movieName.Visible = true;
            actorName.Visible = false;
            ticketSold.Visible = false;
            using(cmd= new SqlCommand("sp_ShowMovieDetails",cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@movieId", SqlDbType.Int).Value = txtMovieId.Text;
                
                cn.Open();
                object res = cmd.ExecuteScalar();
                movieName.Text = res.ToString();
                cn.Close();
            }
        }
    }
}

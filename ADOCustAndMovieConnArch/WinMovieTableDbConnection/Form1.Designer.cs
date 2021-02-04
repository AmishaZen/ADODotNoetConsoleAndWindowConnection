
namespace WinMovieTableDbConnection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMovieId = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.movieName = new System.Windows.Forms.Label();
            this.actorName = new System.Windows.Forms.Label();
            this.ticketSold = new System.Windows.Forms.Label();
            this.btnMovieDetail = new System.Windows.Forms.Button();
            this.btnShowmovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.dgvForShowdetails = new System.Windows.Forms.DataGridView();
            this.txtMovId = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnMovieName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForShowdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieId.Location = new System.Drawing.Point(40, 64);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(130, 16);
            this.lblMovieId.TabIndex = 0;
            this.lblMovieId.Text = "Enter Movie Id";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(40, 102);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(113, 16);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Movie Name";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActor.Location = new System.Drawing.Point(40, 142);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(54, 16);
            this.lblActor.TabIndex = 2;
            this.lblActor.Text = "Actor";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(40, 182);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(111, 16);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Text = "Tickets Sold";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnShow.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(45, 226);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 34);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "ShowDetails";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(195, 62);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(100, 20);
            this.txtMovieId.TabIndex = 5;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.Location = new System.Drawing.Point(193, 102);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(97, 17);
            this.movieName.TabIndex = 6;
            this.movieName.Text = "NameOfMovie";
            // 
            // actorName
            // 
            this.actorName.AutoSize = true;
            this.actorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorName.Location = new System.Drawing.Point(192, 141);
            this.actorName.Name = "actorName";
            this.actorName.Size = new System.Drawing.Size(93, 17);
            this.actorName.TabIndex = 7;
            this.actorName.Text = "NameOfActor";
            // 
            // ticketSold
            // 
            this.ticketSold.AutoSize = true;
            this.ticketSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketSold.Location = new System.Drawing.Point(193, 182);
            this.ticketSold.Name = "ticketSold";
            this.ticketSold.Size = new System.Drawing.Size(86, 17);
            this.ticketSold.TabIndex = 8;
            this.ticketSold.Text = "NoOfTickets";
            // 
            // btnMovieDetail
            // 
            this.btnMovieDetail.Font = new System.Drawing.Font("Rockwell Extra Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieDetail.Location = new System.Drawing.Point(23, 3);
            this.btnMovieDetail.Name = "btnMovieDetail";
            this.btnMovieDetail.Size = new System.Drawing.Size(104, 36);
            this.btnMovieDetail.TabIndex = 9;
            this.btnMovieDetail.Text = "MovieDetails";
            this.btnMovieDetail.UseVisualStyleBackColor = true;
            this.btnMovieDetail.Click += new System.EventHandler(this.btnMovieDetail_Click);
            // 
            // btnShowmovie
            // 
            this.btnShowmovie.Font = new System.Drawing.Font("Rockwell Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowmovie.Location = new System.Drawing.Point(124, 3);
            this.btnShowmovie.Name = "btnShowmovie";
            this.btnShowmovie.Size = new System.Drawing.Size(111, 36);
            this.btnShowmovie.TabIndex = 10;
            this.btnShowmovie.Text = "ShowMovies";
            this.btnShowmovie.UseVisualStyleBackColor = true;
            this.btnShowmovie.Click += new System.EventHandler(this.btnShowmovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Font = new System.Drawing.Font("Rockwell Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(232, 3);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(107, 36);
            this.btnUpdateMovie.TabIndex = 11;
            this.btnUpdateMovie.Text = "UpdateMovie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // dgvForShowdetails
            // 
            this.dgvForShowdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForShowdetails.Location = new System.Drawing.Point(23, 62);
            this.dgvForShowdetails.Name = "dgvForShowdetails";
            this.dgvForShowdetails.Size = new System.Drawing.Size(344, 204);
            this.dgvForShowdetails.TabIndex = 12;
            this.dgvForShowdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForShowdetails_CellContentClick);
            // 
            // txtMovId
            // 
            this.txtMovId.Location = new System.Drawing.Point(195, 62);
            this.txtMovId.Name = "txtMovId";
            this.txtMovId.Size = new System.Drawing.Size(100, 20);
            this.txtMovId.TabIndex = 13;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(196, 100);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(100, 20);
            this.txtMName.TabIndex = 14;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(196, 138);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(100, 20);
            this.txtActor.TabIndex = 15;
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(196, 180);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(100, 20);
            this.txtTicket.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(124, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 34);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UpdateDetail";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnMovieName
            // 
            this.btnMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieName.Location = new System.Drawing.Point(232, 225);
            this.btnMovieName.Name = "btnMovieName";
            this.btnMovieName.Size = new System.Drawing.Size(107, 34);
            this.btnMovieName.TabIndex = 18;
            this.btnMovieName.Text = "MovieName";
            this.btnMovieName.UseVisualStyleBackColor = true;
            this.btnMovieName.Click += new System.EventHandler(this.btnMovieName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMovieName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtMovId);
            this.Controls.Add(this.dgvForShowdetails);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnShowmovie);
            this.Controls.Add(this.btnMovieDetail);
            this.Controls.Add(this.ticketSold);
            this.Controls.Add(this.actorName);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblMovieId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForShowdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label actorName;
        private System.Windows.Forms.Label ticketSold;
        private System.Windows.Forms.Button btnMovieDetail;
        private System.Windows.Forms.Button btnShowmovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.DataGridView dgvForShowdetails;
        private System.Windows.Forms.TextBox txtMovId;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnMovieName;
    }
}


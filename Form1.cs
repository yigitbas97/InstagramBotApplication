using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using InstaSharper.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramBotApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string username;
        public string password;

        public UserSessionData user = new UserSessionData();
        public IInstaApi api;

        private void Form1_Load(object sender, EventArgs e)
        {
            applicationPanel.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetUsernameAndPassword()
        {
            username = userNameTbox.Text.Trim();
            password = passwordTbox.Text.Trim();

            user.UserName = username;
            user.Password = password;
        }

        public async void Login()
        {
            GetUsernameAndPassword();

            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .Build();

            var loginRequest = await api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                MessageBox.Show("Instagram hesabınıza giriş yapıldı !");
                descriptionPanel.Visible = false;
                applicationPanel.Visible = true;

                FillDataGridViews();

                await api.LogoutAsync();
            }

            else
            {
                MessageBox.Show("Beklenmedik bir sorun oluştu. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin !");
            }
        }

        public async Task<List<InstaUser>> GetFollowersList()
        {
            var tempFollowersList = await api.GetUserFollowersAsync(user.UserName, PaginationParameters.Empty);
            var followers = new List<InstaUser>();

            for (int i = 0; i < tempFollowersList.Value.Count; i++)
            {
                followers.Add(new InstaUser { Id = i + 1, Username = tempFollowersList.Value[i].UserName });
            }

            return followers;
        }

        public async Task<List<InstaUser>> GetFollowingList()
        {
            var tempFollowingList = await api.GetUserFollowingAsync(user.UserName, PaginationParameters.Empty);
            var following = new List<InstaUser>();

            for (int i = 0; i < tempFollowingList.Value.Count; i++)
            {
                following.Add(new InstaUser { Id = i + 1, Username = tempFollowingList.Value[i].UserName });
            }

            return following;
        }

        public async Task<List<InstaUser>> GetUnreturnedFollowingList()
        {
            var tempFollowers = await GetFollowersList();
            var tempFollowing = await GetFollowingList();

            var unreturnedFollowingList = new List<InstaUser>();

            foreach (var item in tempFollowing)
            {
                if (!tempFollowers.Any(u => u.Username == item.Username))
                {
                    unreturnedFollowingList.Add(item);
                }
            }

            return unreturnedFollowingList;
        }

        public async Task<List<InstaUser>> GetUnrequitedFollowersList()
        {
            var tempFollowers = await GetFollowersList();
            var tempFollowing = await GetFollowingList();

            var unrequitedFollowersList = new List<InstaUser>();

            foreach (var item in tempFollowers)
            {
                if (!tempFollowing.Any(u => u.Username == item.Username))
                {
                    unrequitedFollowersList.Add(item);
                }
            }

            return unrequitedFollowersList;
        }

        public async void FillDataGridViews()
        {
            dataGridView1.DataSource = await GetUnreturnedFollowingList();
            dataGridView2.DataSource = await GetUnrequitedFollowersList();
        }
    }
}



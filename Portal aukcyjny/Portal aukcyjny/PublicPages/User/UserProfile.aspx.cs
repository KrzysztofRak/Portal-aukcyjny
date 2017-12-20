﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model.Repositories;
using System.Diagnostics;
using Portal_aukcyjny.Presenters;
using Portal_aukcyjny.UserControls;
using Model;

namespace Portal_aukcyjny.PublicPages.User
{
    public partial class UserProfile : System.Web.UI.Page
    {
        private Guid userId;
        private PortalAukcyjnyEntities db;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                userId = Guid.Parse(Request.QueryString["id"]);
            }
            catch
            {
                Response.Redirect(Page.ResolveUrl("~/Default.aspx"));
            }

            db = new PortalAukcyjnyEntities();

            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            UsersRepository usersRepo = new UsersRepository(db);

            var user = usersRepo.GetUserProfile(userId);

           if(user.Username == null)
                Response.Redirect(Page.ResolveUrl("~/Default.aspx"));

            List<CommentControl> commentControls = new List<CommentControl>();


            ListView_Comments.DataSource = commentControls;
            ListView_Comments.DataBind();

            Username.Text = user.Username;
            Email.Text = user.Email;
            SoldItemsNum.Text = user.SoldItemsNum.ToString();
            RegistrationDate.Text = user.RegistrationDate.ToShortDateString();

            LoadAuctionsSection();
            LoadCommentsSection();
        }

        private void LoadAuctionsSection()
        {
            AuctionsRepository auctionsRepo = new AuctionsRepository(db);

            var auctions = auctionsRepo.GetByUserId(userId);

            MyPresenter controls = new MyPresenter();
            controls.LoadAuctionControls(auctions, ListView_UserAuctions);
        }

        private void LoadCommentsSection()
        {
            CommentsRepository commentsRepo = new CommentsRepository(db);

            var comments = commentsRepo.GetByUserId(userId);
            MyPresenter controls = new MyPresenter();
            controls.LoadCommentControls(comments, ListView_Comments);
        }
    }
}
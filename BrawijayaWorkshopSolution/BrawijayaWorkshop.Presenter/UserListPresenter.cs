﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UserListPresenter : BasePresenter<IUserListView, UserListModel>
    {
        public UserListPresenter(IUserListView view, UserListModel model) : base(view, model) { }

        public void LoadUser()
        {
            View.UserListData = Model.SearchUser(View.FilterName, View.FilterIsActive);
        }

        public void DeleteUser()
        {
            Model.DeleteUser(View.SelectedUser.Id);
        }
    }
}
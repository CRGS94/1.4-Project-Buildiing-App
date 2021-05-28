using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class MenuService
    {
        MenuDAO menudb;

        public MenuService()
        {
            menudb = new MenuDAO();
        }

        public List<Menu> GetOrders()
        {
            List<Menu> menuList = menudb.GetAll();
            return menuList;
        }

        public Menu GetByMenuId(int menu_id)
        {
            Menu menu = menudb.GetById(menu_id);
            return menu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reporting_web.Models;

namespace reporting_web.Security
{
    public class VerifiyToken
    {
        public Boolean TrueToken(string token)
        {
            DataLogin db = new DataLogin();
            
            var data = from c in db.tblUsers where c.Token == token select c;
            if (data.Count() > 0)
            {                
                return true;
            }
            else
                return false;
        }

        public List<Menu> getMenuParent()
        {
            DataMenu dbMenu = new DataMenu();
            

           var dataMenuParent = (from d in dbMenu.Menus where d.levelMenu == 1 && d.DisplayMenu == true select d).ToList();
           if (dataMenuParent != null)
           {

                return dataMenuParent;
           }
           else
                return null;                                  
        }

        public List<RoleMenu> getMenuParent(long idRole)
        {
            
           DataRoleMenu dbRoleMenu = new DataRoleMenu();

           var dataMenuParent = (from dr in dbRoleMenu.RoleMenus
                                 where (dr.RoleId == idRole && dr.levelMenu == 1 && dr.DisplayMenu == true)
                                 select dr).ToList();
           if (dataMenuParent != null)
           {
                return dataMenuParent;
           }
           else
           { 
                return null;
           }
        }

        public List<Menu> getSubMenu1()
        {
            DataMenu dbMenu = new DataMenu();
            var dataSubMenu = (from d in dbMenu.Menus where d.levelMenu == 2 && d.DisplayMenu==true select d).ToList();
            if (dataSubMenu != null)
            {

                return dataSubMenu;
            }
            else
                return null;
        }

        public List<RoleMenu> getSubMenu1(long idRole)
        {
            DataRoleMenu dbMenu = new DataRoleMenu();
            var dataSubMenu = (from d in dbMenu.RoleMenus where d.RoleId==idRole && d.levelMenu == 2 && d.DisplayMenu == true select d).ToList();
            if (dataSubMenu != null)
            {

                return dataSubMenu;
            }
            else
                return null;
        }

        public List<Menu> getSubMenu2()
        {
            DataMenu dbMenu = new DataMenu();
            var dataSubMenu = (from d in dbMenu.Menus where d.levelMenu == 3 && d.DisplayMenu == true select d).ToList();
            if (dataSubMenu != null)
            {

                return dataSubMenu;
            }
            else
                return null;
        }

        public List<RoleMenu> getSubMenu2(long idRole)
        {
            DataRoleMenu dbMenu = new DataRoleMenu();
            var dataSubMenu = (from d in dbMenu.RoleMenus where d.RoleId == idRole && d.levelMenu == 3 && d.DisplayMenu == true select d).ToList();
            if (dataSubMenu != null)
            {

                return dataSubMenu;
            }
            else
                return null;
        }

        public Boolean getAccessMenu(string code,long idRole)
        {
            DataRoleMenu dbRole = new DataRoleMenu();
            var dataMenu = (from d in dbRole.RoleMenus where d.RoleId == idRole && d.CodeMenu == code select d).ToList();
            if ((dataMenu != null && dataMenu.Count > 0)|| idRole == 1)
                return true;
            else
                return false;


        }
    }
}
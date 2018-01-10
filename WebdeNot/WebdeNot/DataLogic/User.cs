using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebdeNot.Models.Views;
using WebdeNot.Models;

namespace WebdeNot.DataLogic
{
    public class User
    {
        
        public  static userView Login(string nickName,string pass)
        {
            try
            {
                using (WebdeNotEntities db = new WebdeNotEntities())
                {
                    userView u = (from ku in db.TblUser where ku.Nickname == nickName && ku.Password == pass && ku.Existing == true
                                 || ku.Email == nickName && ku.Password == pass && ku.Existing == true select new userView {
                                     Surname=ku.Surname,
                                     Nickname=ku.Nickname,
                                     Name= ku.Name,
                                     Email=ku.Email,
                                     Photo=ku.Photo,
                                     ID=ku.ID
                                 }).SingleOrDefault();
                    if (u!=null)
                    {
                        return u;
                    }
                    else
                    {
                        return null;
                    }

                };
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string SignUp(userView newUser)
        {
            try
            {
                using (WebdeNotEntities db = new WebdeNotEntities())
                {
                    TblUser nUser = new TblUser {Name=newUser.Name,Email=newUser.Email,Nickname=newUser.Nickname,Photo=newUser.Photo,Password=newUser.Password,Surname=newUser.Surname,BirthDate=newUser.BirtDate  };
                    nUser.JoinDate = DateTime.Now;
                    nUser.Existing = true;
                    db.TblUser.Add(nUser);
                    db.SaveChanges();
                    return "+ okey";
                };
            }
            catch (Exception ex)
            {
                return "- "+ex.Message;
            }
        }
        public userView getUser(int UID)
        {
            try
            {
                using (WebdeNotEntities db = new WebdeNotEntities())
                {
                    TblUser getUser = db.TblUser.Find(UID);
                    return new userView
                    {
                        Surname = getUser.Surname,
                        Nickname = getUser.Nickname,
                        Name = getUser.Name,
                        Email = getUser.Email,
                        Photo = getUser.Photo,
                        ID = getUser.ID,
                        Age = Convert.ToDateTime(DateTime.Now - getUser.BirthDate).Year
                    };
                };
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
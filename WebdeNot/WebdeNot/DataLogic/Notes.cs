using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebdeNot.Models;
using WebdeNot.Models.Views;

namespace WebdeNot.DataLogic
{
    public class Notes
    {
        public static string NoteAdd(NoteViews newnote)
        {
            try
            {
                using (WebdeNotEntities db = new WebdeNotEntities())
                {
                    TblNote new_note = new TblNote
                    {
                        Title = newnote.Title,
                        Description = newnote.Description,
                        ReminderDate = newnote.ReminderDate,
                        İmportantyDegree = newnote.İmportantyDegree,
                    };
                    db.TblNote.Add(new_note);
                    db.SaveChanges();
                    return "+ Note eklendi";
                }
            }
            catch (Exception ex)
            {
                return "- "+ ex.Message;

            }
        }

        public static string NoteUpdate(NoteViews note)
        {
            try
            {
                using (WebdeNotEntities db=new WebdeNotEntities())
                {
                    TblNote upnote = db.TblNote.Find(note.ID);
                    if (upnote != null)
                    {
                        upnote.Title = note.Title;
                        upnote.Description = note.Description;
                        upnote.ReminderDate = note.ReminderDate;
                        upnote.İmportantyDegree = note.İmportantyDegree;
                        db.SaveChanges();
                        return "+ note guncellendi.";
                    }
                    else
                        return "- note bulunamadi.";

                }
            }
            catch (Exception ex)
            {
                return "- " + ex.Message;
                
            }
        }

        public static string DeleteNote(int noteID)
        {
            try
            {
                using (WebdeNotEntities db =new WebdeNotEntities())
                {
                    TblNote delnote =db.TblNote.Find(noteID);
                    if (delnote != null)
                    {
                        delnote.Existing = false;
                        return "+ Silindi.";
                    }
                    else
                        return "- not bulunamadı.";
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return "- " + ex.Message;
            }
        }
        public static List<NoteViews> listNote(int ID)
        {
            try
            {
                using (WebdeNotEntities db =new WebdeNotEntities())
                {
                    List<NoteViews> listnote=new List<NoteViews>();
                    var n = (from note in db.TblNote where note.UserID==ID orderby note.WritingDate select note).ToList();
                    foreach (var item in n)
                    {
                        listnote.Add(new NoteViews {ID=item.ID , Title=item.Title, Description= item.Description, ReminderDate=(DateTime)item.ReminderDate,
                                                    WritingDate=(DateTime)item.WritingDate, İmportantyDegree=(int)item.İmportantyDegree});
                    }
                    return listnote;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
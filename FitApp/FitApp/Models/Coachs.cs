using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Coachs
    {
        public int CoachID { get; set; }
        public int UserID { get; set; } //Trzeba zmienic nazwe 'Id' na 'UserID' i typ na 'int' w klasie uzytkownika

        public ICollection<Activity> Activity { get; set; }
    }
}
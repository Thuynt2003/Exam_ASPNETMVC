﻿namespace Exam_ASPNETMVC.Entity
{
    public class Contacts
    {
        public int Id { get; set; }

        public string Contact_Name { get; set; } 
        public int Contact_Number { get; set; }

        public string Group_Name { get; set; }
        public DateOnly Hire_Date  { get; set; }

        public string Birthday { get; set; }
    }
}

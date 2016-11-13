using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CL2016StudentTracker.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get { return FirstName + " " + LastName; } }

        [DisplayName("E-mail")]
        public string Email { get; set; }
        [DisplayName("Secondary E-mail")]
        public string SecondEmail { get; set; }

        //Secondary personal information
        //All other information is stored in the other database/webapp, the one CL has to use for legal purposes
        //but Veteran status is something they actually need often, so it goes in here
        [DisplayName("Veteran")]
        public bool Veteran { get; set; }

        [DisplayName("Welcome Message Sent")]
        public bool WelcomeMessageSent { get; set; }
        [DisplayName("Code of Conduct Signed")]
        public bool ConductSigned { get; set; }
        [DisplayName("Prework Status")]
        public Cohort.PreworkStatus PreworkStatus { get; set; }

        [DisplayName("Session")]
        public string Session { get; set; }
        [DisplayName("Track")]
        public Cohort.Track CurrentTrack { get; set; }
        [DisplayName("Meetup Day")]
        public Cohort.MeetupDay MeetupDay { get; set; }
        [DisplayName("Status")]
        public Cohort.CurrentStatus CurrentStatus { get; set; }

        [DisplayName("Treehouse Status")]
        public bool TreehouseStatus { get; set; }

        [DisplayName("Absences")]
        public int Absences { get; set; } = 0;

        [DisplayName("First Session")]
        public string FirstSession { get; set; }
        [DisplayName("Restart Session")]
        public string RestartSession { get; set; }

        //This is bad but I'm going based off the existing database fields :(
        //format is like this: 72015 = July 2015
        //Maybe change to its own class stucture that will keep track of details like session, meetup day, status, github project link, etc
        //Maybe for an update post-CL
        //Default values are also bad and will be more different,
        //This is just a stop-gap for now
        [DisplayName("Front End Grad Date")]
        public string FeGradDate { get; set; } = "N/A";//front end
        [DisplayName("FSJS Grad Date")]
        public string FsjsGradDate { get; set; } = "N/A";//full stack javascript
        [DisplayName("PHP Grad Date")]
        public string PhpGradDate { get; set; } = "N/A";//php
        [DisplayName("Android Grad Date")]
        public string AndroidGradDate { get; set; } = "N/A";//android development
        [DisplayName("iOS Grad Date")]
        public string IosGradDate { get; set; } = "N/A";//ios development
        [DisplayName("Ruby on Rails Grad Date")]
        public string RorGradDate { get; set; } = "N/A";//ruby on rails
        [DisplayName("C#.NET Grad Date")]
        public string CsharpGradDate { get; set; } = "N/A"; //C#.NET

        //Post grad workshops
        [DisplayName("Resume Rewrite")]
        public bool ResumeRewrite { get; set; }
        [DisplayName("Leveraging LinkedIn")]
        public bool LeveragingLinkedin { get; set; }
        [DisplayName("Impressive Interviewing")]
        public bool ImpressiveInterviewing { get; set; }
        [DisplayName("Noteworthy Networking")]
        public bool NoteworthyNetworking { get; set; }

        [DisplayName("LinkedIn Grad Directory")]
        public bool LinkedinGradDirectory { get; set; }
        [DisplayName("One on One")]
        public bool OneOnOne { get; set; }
        [DisplayName("Demo Video")]
        public bool DemoVideo { get; set; }
        [DisplayName("Post-Graduation Survey")]
        public bool PostGradSurveySent { get; set; }

        [DisplayName("Hired?")]
        public bool IsHired { get; set; }
        [DisplayName("Employer")]
        public string Employer { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }

        //Would be better if it actually stored usernames
        //Maybe presented full URLs but took in only usernames and/or parsed the usernames out from a full URL passed in
        //Really I just don't want to deal with full URLs stored in a database when a lot of it is going to be repeat data
        //This will be a for-later pretty-up actvity
        [DisplayName("LinkedIn")]
        public string LinkedinURL { get; set; }
        [DisplayName("Treehouse")]
        public string TreehouseURL { get; set; }
        [DisplayName("GitHub")]
        public string GithubURL { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Notes")]
        public string Notes { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
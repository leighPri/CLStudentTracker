using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace CL2016StudentTracker.Models
{
    //generalized cohort information
    public class Cohort
    {

        public enum Track
        {
            [Display(Name = "C#.NET")]
            cSharpDotNET,
            [Display(Name = "Full Stack Javascript")]
            fullStackJavaScript,
            [Display(Name = "PHP")]
            php,
            [Display(Name = "Android Mobile Development")]
            android,
            [Display(Name = "iOS Mobile Development")]
            ios,
            [Display(Name = "Front End Development")]
            frontEndDevelopment,
            [Display(Name = "Ruby on Rails")]
            ror
        }

        public string Session { get; set; }

        public enum MeetupDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday
        }

        public enum PreworkStatus
        {
            [Display(Name = "Incomplete")]
            incomplete,
            [Display(Name = "Complete")]
            complete,
            [Display(Name = "Extension Given")]
            extensionGiven,
            [Display(Name = "Extension Failed")]
            extensionFailed
        }

        public enum CurrentStatus
        {
            [Display(Name = "On Track")]
            onTrack,
            [Display(Name = "At Risk")]
            atRisk,
            [Display(Name = "Ready to Graduate")]
            readyToGrad,
            [Display(Name = "Restarting")]
            droppedRestart,
            [Display(Name = "Dropped")]
            dropped,
            [Display(Name = "Graduated")]
            graduated
        }

    }
    public static class EnumExtensions
    {
        public static string Description(this Enum enumValue)
        {
            var enumType = enumValue.GetType();
            var field = enumType.GetField(enumValue.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length == 0
                ? enumValue.ToString()
                : ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RSOFTWARESOLUTIONS.Models
{
    public class MailModel
    {
        [Required(ErrorMessage = "Name cannot be blank.")]
        public string Name { get; set; }
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string mail_address { get; set; }
        [Required(ErrorMessage = "Phone number cannot be blank.")]
        public long Phone { get; set; }
        [Required(ErrorMessage = "Message cannot be blank.")]
        public string Msg { get; set; }
    }
}
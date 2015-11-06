using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Knot_Tying.Models
{
    public class CompetitionEntryMetaData
    {
        [Required(ErrorMessage = "Please enter an email address")] //this will run if the text boxes are empty, the regular expression will run if it doesn't match the correct input
        [RegularExpression("^(([\\w-!#$%&'*+/=?^_`{}|~]+\\.)+[\\w-!#$%&'*+/=?^_`{}|~]+|([a-zA-Z]{1}|[\\w-!#$%&'*+/=?^_`{}|~]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z]+[\\w-]+\\.)+[a-zA-Z]{2,4})$", ErrorMessage = "Please enter the correct email address format e.g. example@example.com")]
        //source: http://www.codeproject.com/Articles/22777/Email-Address-Validation-Using-Regular-Expression
        public string Email;

        [Required(ErrorMessage = "Please enter a Classroom Name")] //empty text box validation
        [RegularExpression("[A-Z][A-Z][0-9][0-9]", ErrorMessage = "Please enter two capital letters followed by two digits e.g. AA11")] //if it doesn't match the right format
        public string CLASSROOM;
    }

    public class SchoolMetadata
    {
        [Required(ErrorMessage = "Please enter a School Name")]
        [RegularExpression("[A-Za-z- ]{1,50}", ErrorMessage = "Please enter a school name in the correct format e.g. Burwood high school")]
        [StringLength(50)] //max string length
        public string NAME;

        [Required(ErrorMessage = "Please enter a telephone number")]
        [RegularExpression("[0-9 +-extn]{9,25}", ErrorMessage = "Please enter a telephone number in the correct format e.g. 123 4567 or +643123 4567")]
        public string TELEPHONE;

        [Required(ErrorMessage = "Please enter a School Address")]
        [RegularExpression("[0-9/0-9 A-Za-z, ]{1,255}", ErrorMessage = "Please enter a school address in the correct format e.g. 123 Auckland street, nelson, nelson")]
        [StringLength(255)]
        public string ADDRESS;
    }
}
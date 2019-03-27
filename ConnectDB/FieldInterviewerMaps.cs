using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMapsConsoleApp.Models
{
    [Table("interviewers_details")]
    public class FieldInterviewerMaps
    {
        [Key]
        public int ID { get; set; }

        public string BMG_ID { get; set; }

        public string ProjectNumber { get; set; }

        public string ProjectName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string InterviewerID { get; set; }

        public string Lat { get; set; }

        public string Lng { get; set; }
    }
}

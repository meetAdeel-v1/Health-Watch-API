using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_Entity.Entities
{
    public class PatientDisease
    {
        [Key]
        public int Id { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("")]
        public int PatientId { get; set; }
        public Disease Disease { get; set; }
        [ForeignKey("")]
        public int DiseaseId { get; set; }
    }
}

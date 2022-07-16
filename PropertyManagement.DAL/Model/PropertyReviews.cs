using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.DAL.Model
{
    public class PropertyReviews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
        public string ReviewTittle { get; set; }
        public string ReviewComents { get; set; }
        public DateTime CreateAt { get; set; }
    }
}

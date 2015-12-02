using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practice2.Models
{
    public enum CarMake { Mazda, Toyota, Mercedes, BMW }
    public class Car
    {
        [Required(ErrorMessage ="Make: ")]
        [Display(Name = "Make:")]
        public CarMake make { get; set; }
        [Required]
        [Range(100, int.MaxValue, ErrorMessage = "Engine size cannot be less than 100")]
        [Display(Name = "Engine Size:")]
        public int engineSize { get; set; }

        [Required (ErrorMessage ="Owner name must be added.")]
        [Display(Name = "Owner Name:")]
        public String owner { get; set; }
        [Display(Name = "Cost:")]
        public double Cost
        {
            get
            {
                double cost = 0;
                if (make == CarMake.Mazda)
                {
                    cost += engineSize * 50;
                }
                else if (make == CarMake.Toyota)
                {
                    cost += engineSize * 40;
                }
                else
                {
                    cost += engineSize * 55;
                }
                return cost;
            }
        }

    }
}

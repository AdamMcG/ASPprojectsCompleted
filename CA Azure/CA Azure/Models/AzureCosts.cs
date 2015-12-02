using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Azure.Models
{
    public enum Redundancy { geoRedundant, LocalRedundant }
    public class AzureCosts
    {
        [Required]
        [Display(Name = "Redundancy:")]
        public Redundancy instanceRedundancy { get; set; }
        [Required]
        [Display(Name = "Storage(GB):")]
        [Range(1, int.MaxValue, ErrorMessage = "Storage must be greater than 1")]
        public int storageInGB { get; set; }

        public double Cost
        {
            get
            {
                double cost = 0;
                if (instanceRedundancy == Redundancy.geoRedundant)
                {

                    if (storageInGB >= 1000)
                    {
                        cost += 1000 * 0.125;
                        int limitAfterTB = storageInGB - 1000;
                        cost += limitAfterTB * 0.11;
                    }
                    else
                    {
                        cost += storageInGB * 0.125;
                    }
                }
                else
                {
                    if (storageInGB >= 1000)
                    {
                        cost += 1000 * 0.093;
                        int limitAfterTB = storageInGB - 1000;
                        cost += limitAfterTB * 0.083;
                    }
                    else
                    {
                        cost += storageInGB * 0.093;
                    }
                }


                return cost;
            }


        }
    }
}

using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Staffs
    {
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public DateTime DOB { get; set; }


        public Enums.EmploymentStatus Status { get; set; }

        public DateTime StartService { get; set; }

        public DateTime EndService { get; set; }

        public bool isActive { get; set; }




        //pending 
        public string StaffNo { get; set; }





        public string OperatingNo => $"{Branch.Acr}-{StaffNo}";



        public virtual Contact Contact { get; set; }


        public int LocationId { get; set; }

        public virtual Locations Location { get; set; }



        public int BranchId { get; set; }
        public virtual Branches Branch { get; set; }


        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }



        public Staffs()
        {
            isActive = true;
            Status = Enums.EmploymentStatus.Active;
        }

    }
}

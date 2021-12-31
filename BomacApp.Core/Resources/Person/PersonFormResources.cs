using BomacApp.Core.Resources.Common;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.Person
{
    public class PersonFormResources
    {
        public string Name { get; set; }

        public string PPhoneNo { get; set; }


        public string Email { set; get; }

        public string Web { get; set; }

        public string Address { get; set; }

        public int StateId { get; set; }

        public decimal Balance { get; set; }


        public int TypeId { get; set; }

        [Required]
        public Enums.PersonType Type => ((Enums.PersonType)TypeId);



        public PersonFormResources()
        {
            Balance = 0;
        }



    }



}
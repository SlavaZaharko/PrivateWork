using PrivateWork.API.Models.OutputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models
{
    public class OrderOutputModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; }
        public List<OrderInfoOutputModel> OrderInfos { get; set; }

    }
}

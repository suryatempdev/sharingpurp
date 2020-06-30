using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
	public class Employee
	{
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Employee name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Designation name")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Please enter Department name")]
        public string Department { get; set; }
        public string StmtType { get; set; }
        public string buttonText { get; set; }
        public string Message { get; set; }

        public List<Employees> lstEmployees { get; set; }

    }
}
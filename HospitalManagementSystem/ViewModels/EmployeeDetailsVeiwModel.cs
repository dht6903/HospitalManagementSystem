﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ViewModels
{
    public class EmployeeDetailsVeiwModel : BaseViewModel
    {
        /// <summary>
        /// Details View Properites
        /// </summary>
        public String EmployeeName { get; set; }
        public String EmployeeRole { get; set; }
        public String EmployeeAddress { get; set; }
        public String EmployeeBirthDate { get; set; }
        public String EmployeeDepartment { get; set; }
        public String EmployeeEmploymentDate { get; set; }
        public String EmployeeSalary { get; set; }
        public ObservableCollection<String> PatientsList { get; set; }
        public ObservableCollection<String> AppointmentsList { get; set; }
        public ObservableCollection<String> PatientsNumber { get; set; }
        public ObservableCollection<String> AppointmentsNumber { get; set; }
    }
}
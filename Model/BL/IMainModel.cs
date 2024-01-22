﻿using Model.DAL;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BL
{
    public class EmployeeEventArgs : EventArgs
    {
        public Employee Employee { get; set; }
        public EmployeeEventArgs(Employee employee)
        {
            Employee = employee;
        }
    }

    public interface IMainModel
    {
        event EventHandler<EmployeeEventArgs> EventAddEmployee;
        event EventHandler<EmployeeEventArgs> EventDelEmployee;

        //readonly IRepository<Employee> _repository;

        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        IList<Employee> GetEmployees();

    }
}

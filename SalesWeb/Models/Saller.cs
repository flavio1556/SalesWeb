using System;
using System.Collections.Generic;
using System.Linq;
namespace SalesWeb.Models
{
    public class Saller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Saller()
        {
        }

        public Saller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
            this.BaseSalary = baseSalary;
            this.Department = department;
        }
        public void AddSales(SalesRecord salesRecord)
        {
            this.Sales.Add(salesRecord);
        }
        public void RemoveSales(SalesRecord salesRecord)
        {
            if (salesRecord == null)
            {
                return;
            }
            this.Sales.Remove(salesRecord);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            double total = 0;
            total = this.Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
            return total;
        }
    }
}

using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWeb.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; }  = new List<Saller>();
        public Department()
        {
        }
        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void AddSaller(Saller saller)
        {
            this.Sallers.Add(saller);
        }
        public double TotalSales (DateTime initial, DateTime final)
        {
            return this.Sallers.Sum(x => x.TotalSales(initial, final));
        }
    }
}

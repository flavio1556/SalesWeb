using System;
using SalesWeb.Models.enums;
namespace SalesWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Saller Saller { get; set; }

        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Saller saller)
        {
            this.Id = id;
            this.Date = date;   
            this.Amount = amount;
            this.Status = status;
            this.Saller = saller;
        }
    }
}

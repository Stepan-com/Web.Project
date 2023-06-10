using System;

namespace Mondy.Domain.Entities
{
	public class Product
	{
		public int Id { get; set; }

        public string Category { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public float Acid { get; set; }
        public float pH { get; set; }
        public float Alcohol { get; set; }

        public string Notes { get; set; } 

        public float PricePerUnit { get; set; }
        public string Unit { get; set; }
    }
}
﻿namespace CSharpAssessmentWeek2
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }

        public Item()
        {
        }
    }
}
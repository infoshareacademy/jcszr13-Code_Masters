﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHero.HotelsDatabase
{
    internal class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public float Rating { get; set; }
        public int Cost {  get; set; } 

        public override string ToString()
        {
            return $"Hotel name: {Name} \nStar rating: {_numberOfStars(Stars)} \nAddress: {Address}, {City} \nDEscription: {Description} \nRating: {Rating} \nCost: {Cost} PLN ";
        }

        private string _numberOfStars(int number)
        {
            string stars = null;
            for (int i = 0; i < number; i++)
                stars += "*";
            return stars;
        }
    }
}

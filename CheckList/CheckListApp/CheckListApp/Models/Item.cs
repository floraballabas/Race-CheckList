using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheckListApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RaceCategory RaceCategory { get; set; }
        public bool IsPacked { get; set; } = false;
    }

    public enum RaceCategory
    {
        Swim,
        Bike,
        Run,
        General
    }
}

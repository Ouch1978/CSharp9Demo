﻿namespace LibCSharp9Demo.Models
{
    public class Mrt : IVehicle
    {
        public bool IsTransfer { get; set; }
        public string Brand { get; init; }
        public string TypeName { get; init; }
        public int Year { get; init; }
        public string Color { get; set; }
    }
}
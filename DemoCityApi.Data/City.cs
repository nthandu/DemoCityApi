﻿using System;

namespace DemoCityApi.Data
{
    public class City
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public DateTime EstablishedDate { get; set; }
        public int EstimatedPopulation { get; set; }
    }
}

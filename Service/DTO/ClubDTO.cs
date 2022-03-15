using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;

namespace Service.DTO
{
    public class ClubDTO
    {
        public ClubDTO(Club c)
        {
            Id = c.id;
            name = c.name;
            owner = c.owner;
            city = c.city;
            country = c.country;
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
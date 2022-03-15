using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;

namespace Service.DTO
{
    public class PlayerDTO
    {
        public PlayerDTO(Player p)
        {
            Id = p.id;
            firstName = p.firstName;
            lastName = p.lastName;
            signingDate = p.signingDate;
            rank = p.rank;
            totalGoals = p.totalGoals;
            clubId = p.clubId;
        }

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string signingDate { get; set; }
        public string rank { get; set; }
        public string totalGoals { get; set; }
        public int clubId { get; set; }

        public virtual ClubDTO club { get; set; }

    }
}
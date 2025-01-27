﻿using PubApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp.Repository
{
   public class FakeRepo
    {
        public List<Pub> GetAll()
        {
            return new List<Pub>
            {
                new Pub
                {
                     Name="NZS",
                      Price=1,
                       Volume=0.4,
                       ImagePath="../Images/nzs.jpg"
                },
                new Pub
                {
                     Name="Blance",
                      Price=6.50,
                       Volume=0.5,
                       ImagePath="../Images/bla.png"
                },
                new Pub
                {
                     Name="Erdinger",
                      Price=7.0,
                       Volume=0.5,
                       ImagePath="../Images/er.png"
                },
                new Pub
                {
                     Name="Salyan",
                      Price=1,
                       Volume=0.4,
                       ImagePath="../Images/Salyan.jpg"
                },
            };
        }
    }
}

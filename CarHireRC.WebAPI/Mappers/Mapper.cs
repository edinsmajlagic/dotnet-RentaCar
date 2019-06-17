﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireRC.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Automobil, Model.Models.Automobil>();
            CreateMap<Database.Automobil, Model.Requests.AutomobiliUPSERTtRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Models.Korisnici>();
            CreateMap<Database.KorisniciUloge, Model.Requests.KorisniciUpsertRequest>();
            CreateMap<Database.KorisniciUloge, Model.Models.KorisniciUloge>();
            CreateMap<Database.Klijent, Model.Requests.KlijentUpsertRequest>().ReverseMap();
            CreateMap<Database.Klijent, Model.Models.Klijent>().ReverseMap();
            CreateMap<Database.RegistracijaVozila, Model.Requests.RegistracijaVozilaUpsertRequest>().ReverseMap();
            CreateMap<Database.RezervacijaRentanja, Model.Requests.RezervacijaRentanjaUpsertRequest>().ReverseMap();
            CreateMap<Database.RezervacijaRentanja, Model.Models.RezervacijaRentanja>().ReverseMap();
            CreateMap<Database.Poruka, Model.Requests.PorukaUpsertRequest>().ReverseMap();
            CreateMap<Database.Poruka, Model.Models.Poruka>().ReverseMap();
            CreateMap<Database.Racun, Model.Requests.RacunUpsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, Model.Models.Ocjena>().ReverseMap();
            CreateMap<Database.Ocjena, Model.Requests.OcjenaUpsertRequest>().ReverseMap();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarHireRC.Model.Requests
{
    public class OcjenaSearchRequest
    {
        public int OcjenaId { get; set; }
        public int VoziloId { get; set; }
        public int RezervacijaRentanjaId { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Client
    {
        int NumClient { get; set; }
        string NomClient { get; set; }

        string AdresseClient { get; set; }

        string NumTel { get; set; }

        string Ville { get; set; }

        string CodePostal { get; set; }

        List<CentreInformatique> CentreInformatique { get; set; }
    }
}

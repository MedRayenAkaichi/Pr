﻿using Projet.Context;
using Projet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.DAL.Repos
{
    public class UtilisateurRepository : GenericRepository<Utilisateur>
    {
        public UtilisateurRepository(DataContext context) : base(context)
        {
        }
    }
}

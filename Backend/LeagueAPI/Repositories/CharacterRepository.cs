﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.Models;
using Microsoft.EntityFrameworkCore;
using LeagueAPI.Context;

namespace LeagueAPI.Repositories
{
    public class CharacterRepository : Repository<Character>, IRepository<Character>
    {
        private DbContext db;
        public CharacterRepository(LeagueContext context) : base(context)
        {
            this.db = context;
        }
        //public override Character GetById(int id)
        //{
        //    return db.Set<Character>().Where(i => i.Id == id).Include("Characters").FirstOrDefault();
        //}

    }
}

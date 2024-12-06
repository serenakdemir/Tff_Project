using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff_Project.Exceptions;
using Tff_Project.Models;

namespace Tff_Project.Repository;

public class TeamRepository : IRepository<Team, int>
{
    public Team Add(Team entity)
    {
        BaseRepository.Teams.Add(entity);
        return entity;
    }

    public Team? Delete(int id)
    {
        Team? team = GetById(id);
        if (team == null)
        {
            throw new Exception($"Aradığınız Id ye göre Takım Bulunamadı:{id}");
        }
        BaseRepository.Teams.Remove(team);
        return team;
    }

    public List<Team> GetAll()
    {
        return BaseRepository.Teams;
    }

    public Team? GetById(int id)
    {
        Team? team = BaseRepository.Teams.SingleOrDefault(p => p.Id == id);
        if (team == null)
        {
            throw new NotFoundException($"Aradığınız Id ye göre Takım Bulunamadı:{id}");
        }
        return team;
    }

    public Team? Update(int id, Team entity)
    {
        var updatedTeam = GetById(id);

        int index = BaseRepository.Teams.IndexOf(updatedTeam);

        BaseRepository.Teams.Remove(updatedTeam);
        BaseRepository.Teams.Insert(index, entity);

        return entity;

    }
}

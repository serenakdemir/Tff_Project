using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff_Project.Models.ReturnModels;
using Tff_Project.Models;

namespace Tff_Project.Service;

public interface ITeamService
{
    ReturnModel<Team> GetById(int id);
    ReturnModel<List<Team>> GetAll();

    ReturnModel<Team> Update(int id, Team team);
}

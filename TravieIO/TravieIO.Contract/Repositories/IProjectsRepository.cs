using System;
using System.Collections.Generic;
using System.Text;
using TravieIO.Contract.DataContracts;
using TravieIO.Contract.Repositories;

namespace TravieIO.Contract.Repositories
{
    public interface IProjectsRepository
    {
        List<ProjectDto> GetAll();
        ProjectDto GetByName(string projectName);
        void Add(ProjectDto project);
        void Delete(int id);
        ProjectDto GetById(int id);
        void Add(AddProjectDto project);
    }
}

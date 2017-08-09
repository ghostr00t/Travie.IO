using System;
using System.Collections.Generic;
using System.Text;
using TravieIO.Contract.DataContracts;
using TravieIO.Contract.Repositories;
using TravieIO.Contract.Common;

namespace TravieIO.Contract.Services
{
    public interface IProjectsService
    {
        List<ProjectDto> GetAll();
        CommonResult<ProjectDto> GetById(int id);
        CommonResult Add(AddProjectDto project);
        void Delete(int id);
    }
}

﻿using System.Collections.Generic;

using Suls.ViewModels.Problems;

namespace Suls.Services
{
    public interface IProblemsService
    {
        void Create(string name, ushort points);

        IEnumerable<HomePageProblemViewModel> GetAll();

        string GetNameById(string id);

        ProblemViewModel GetById(string id);
    }
}

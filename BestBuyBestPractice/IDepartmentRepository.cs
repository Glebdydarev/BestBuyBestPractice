using System;
using System.Collections.Generic;
using BestBuyBestPractice;

namespace IntroSQL
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); //Stubbed out method
    }
}

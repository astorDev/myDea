using System;
using System.Collections.Generic;
using System.Text;

namespace MyDea.Domain
{
    public interface IPlanRepository
    {
        /// <summary>
        /// Saves new plan and returns id of created db entry
        /// </summary>
        /// <returns></returns>
        int SaveNewPlan(IPlan plan);

        /// <summary>
        /// Counts records in repository
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// Gets Plan by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IPlan GetById(int id);
    }
}

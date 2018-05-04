using System;
using System.Collections.Generic;
using System.Text;
using MyDea.Domain;

namespace MyDea.Data.NetStandart
{
    public class LocalPlanRepository : IPlanRepository
    {
        /// <summary>
        /// Saves new plan and returns id of created db entry
        /// </summary>
        /// <returns></returns>
        public int SaveNewPlan(IPlan plan)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Counts records in repository
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets Plan by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IPlan GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

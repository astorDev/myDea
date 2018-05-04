using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDea.Domain;
using MyDea.Domain.Tests;

namespace MyDea.Data.NetStandart.Tests
{
    [TestClass]
    public class LocalPlanRepositoryTest : PlanRepositoryTestBase
    {
        public override void ClearRepository()
        {
            //TO DO : Implement Clean up
        }

        public override IPlanRepository GetRepo()
        {
            return new LocalPlanRepository();
        }
    }
}

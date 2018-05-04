using System;
using MyDea.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;

namespace MyDea.Domain.Tests
{
    [TestClass]
    public abstract class PlanRepositoryTestBase
    {
        public DateTime TestDate => new DateTime(2018, 4, 4);
        public const string TestPlanNameOne = "TestPlan1";

        /// <summary>
        /// Gets an repo under test
        /// </summary>
        /// <returns></returns>
        public abstract IPlanRepository GetRepo();

        /// <summary>
        /// Clears all data from repository
        /// </summary>
        [TestCleanup]
        public abstract void ClearRepository();

        #region SaveNewPlan

        [ExpectedException(typeof(InvalidFillmentException))]
        [TestMethod]
        public void CreatePlan_ForPlanWithNullName_ThrowsInvalidFillmentException()
        {
            //Arrange
            IPlan plan = A.Fake<IPlan>();
            IPlanRepository repo = this.GetRepo();

            A.CallTo(() => plan.Name).Returns(null);

            //Act
            repo.SaveNewPlan(plan);
        }

        [ExpectedException(typeof(InvalidFillmentException))]
        [TestMethod]
        public void SaveNewPlan_ForPlanWithEmptyName_ThrowsInvalidFillmentException()
        {
            //Arrange
            IPlan plan = A.Fake<IPlan>();
            IPlanRepository repo = this.GetRepo();

            A.CallTo(() => plan.Name).Returns(String.Empty);

            //Act
            repo.SaveNewPlan(plan);
        }

        [ExpectedException(typeof(InvalidFillmentException))]
        [TestMethod]
        public void SaveNewPlan_ForPlanWithDefaultDate_ThrowsInvalidFillmentException()
        {
            //Arrange
            IPlan plan = A.Fake<IPlan>();
            IPlanRepository repo = this.GetRepo();

            A.CallTo(() => plan.Name).Returns(TestPlanNameOne);
            A.CallTo(() => plan.Date).Returns(default);

            //Act
            repo.SaveNewPlan(plan);
        }

        [TestMethod]
        public void SaveNewPlan_ForPlanWithDateAndName_CreatesValidDbRecord()
        {
            //Arrange
            IPlan plan = A.Fake<IPlan>();
            IPlanRepository repo = this.GetRepo();

            A.CallTo(() => plan.Name).Returns(TestPlanNameOne);
            A.CallTo(() => plan.Date).Returns(this.TestDate);

            //Act
            int savedPlanId = repo.SaveNewPlan(plan);

            //Assert
            repo = this.GetRepo();
            Assert.AreEqual(1, repo.Count());

            IPlan savedPlan = repo.GetById(savedPlanId);

            Assert.AreEqual(TestPlanNameOne, savedPlan.Name);
            Assert.AreEqual(this.TestDate, savedPlan.Date);
        }

        #endregion



    }
}

using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoanApplicationStepDefinitions
    {
        [Given(@"John is an active ParaBank customer")]
        public void GivenJohnIsAnActiveParaBankCustomer()
        {

        }

        [When(@"they apply for a (\d+) dollar loan")]
        public void WhenTheyApplyForADollarLoan(int loanAmount)
        {

        }

        //[Then(@"the loan application is (approved | denied)")]
        //public void ThenTheLoanApplicationIsApproved()
        //{

        //}

        [When(@"their monthly income is (.*)")]
        public void WhenTheirMonthlyIncomeIs(int p0)
        {

        }

        [Then(@"the loan application is approved")]
        public void ThenTheLoanApplicationIsApproved()
        {
           // throw new PendingStepException();
        }

        [Then(@"the loan application is denied")]
        public void ThenTheLoanApplicationIsDenied()
        {
            Assert.Fail();
           // throw new PendingStepException();
        }

    }
}

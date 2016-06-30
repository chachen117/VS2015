using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFCSharp_Ch5
{
    public class DinnerParty
    {
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        private decimal costOfBeveragesPerPerson;
        private decimal costOfDecorations = 0;
        //private bool HealthyOption;
        private const int CostOfFoodPerPerson = 25;

        private bool fancyDecorations;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            this.SetHealthyOption(healthyOption);
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        { return NumberOfPeople; }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {costOfDecorations = (NumberOfPeople * 15.00M) + 50M; }
            else
            { costOfDecorations = (NumberOfPeople * 7.50M) + 30M; }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = costOfDecorations + (costOfBeveragesPerPerson + CostOfFoodPerPerson)
                * NumberOfPeople;

            if (healthyOption)
            { totalCost *= .95M; }

            return totalCost;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if(healthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HFCSharp_Lab1_DayAtTheRaces
{
    public class Guy
    {
        public Guy(string Name,int Cash, Label MyLabel, RadioButton MyRadioButton)
        {
            this.Name = Name;
            this.Cash = Cash;
            this.MyLabel = MyLabel;
            this.MyRadioButton = MyRadioButton;
            this.MyBet = null;

            UpdateLabels();
        }

        public string Name
        {
            get;
            set;
        }

        public Bet MyBet
        {
            get;
            set;
        }

        public int Cash
        {
            get;
            set;
        }

        public RadioButton MyRadioButton
        {
            get;
            set;
        }

        public Label MyLabel
        {
            get;
            set;
        }
        
        public void UpdateLabels()
        {            
            if (this.MyBet != null )
            { this.MyLabel.Text = this.MyBet.GetDescription(); }
            else
            { this.MyLabel.Text = this.Name + " hasn't placed a bet" ; }

            UpdateRadioButton();       
        }

        public void UpdateRadioButton()
        {
            this.MyRadioButton.Text = this.Name + " has " + this.Cash + " bucks";
        }

        public bool PlaceBet(int amount, int dog)
        {

            if (Cash >= amount)
            {
                MyBet = new Bet(amount, dog, this);

                UpdateLabels();

                return true;
            }
            else
            {
                MessageBox.Show(this.Name + " doesn't have " + amount, "餘額不足!", MessageBoxButtons.OK);
                UpdateLabels();
                return false;
            }
            
        }

        public void ClearBet()
        {
            MyBet = null;

            UpdateLabels();
        }
        
        public void Collect(int Winner)
        {

            if (this.MyBet != null)
            {
                this.Cash += MyBet.PayOut(Winner);

                UpdateRadioButton();

                ClearBet();
            }           
        }
    }
}
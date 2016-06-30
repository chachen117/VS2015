using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HFCSharp_Ch5
{
    public partial class PartyPlannerUI : Form
    {

        DinnerParty dinnerParty;

        public PartyPlannerUI()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)nud_NumberOfPeople.Value, chk_HealthyOption.Checked, 
                chk_FancyDecoration.Checked);
            dinnerParty.SetHealthyOption(chk_HealthyOption.Checked);
            
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(chk_HealthyOption.Checked);
            lbl_Cost.Text = Cost.ToString("c");
        }

        private void nud_NumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)nud_NumberOfPeople.Value, chk_FancyDecoration.Checked);
            DisplayDinnerPartyCost();
        }

        private void chk_FancyDecoration_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(chk_FancyDecoration.Checked);
            DisplayDinnerPartyCost();
        }

        private void chk_HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(chk_HealthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}

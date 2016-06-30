using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HFCSharp_Lab1_DayAtTheRaces
{
    public class Greyhound
    {
        private int MaxMoveingSpaces = 5;

        public Greyhound(int StartingLocation, int RacetrackLength, PictureBox MyPictureBox)
        {
            this.StartingLocation = StartingLocation;
            this.RacetrackLength = RacetrackLength;
            this.MyPictureBox = MyPictureBox;
            this.Randomizer = new Random();
        }

        private int StartingLocation
        {
            get;
            set;
        }

        private int RacetrackLength
        {
            get;
            set;
        }

        private PictureBox MyPictureBox
        {
            get;
            set;
        }

        private int Location
        {
            get;
            set;
        }

        private Random Randomizer
        {
            get;
            set;
        }

        public bool Run()
        {
            bool isWinner = false;

            //while (this.Location < this.RacetrackLength)
            //{ 
            int distance = Randomizer.Next(1, MaxMoveingSpaces);
            this.Location += distance;
            UpdateLocationPictureBox(distance);
            //}

            if (this.Location >= this.RacetrackLength-this.MyPictureBox.Width)
            { isWinner = true; }

            return isWinner;
        }

        private void UpdateLocationPictureBox(int distance)
        {
            Point p = this.MyPictureBox.Location;
            p.X += distance;
            this.MyPictureBox.Location = p;
        }


        public void TakeStartingPosition()
        {
            this.Location = this.StartingLocation;
            Point p = this.MyPictureBox.Location;
            p.X = this.Location;
            this.MyPictureBox.Location = p;
        }
    }
}
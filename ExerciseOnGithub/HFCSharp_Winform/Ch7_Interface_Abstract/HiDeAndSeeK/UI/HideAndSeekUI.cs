using HFCSharp_Winform.Ch7_Interface_Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HFCSharp_Winform
{
    public partial class HideAndSeekUI : Form
    {
        #region"Declaration"
        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        int Moves;
        Opponent opponent;

        #endregion


        public HideAndSeekUI()
        {
            InitializeComponent();

            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet",
                "inside the closet", "an oak door with a brass knob");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier",
                "in the tall armoire");
            kitchen = new RoomWithDoor(  "kitchen", "stainless steel appliances",
                "in the cabinet","a screen door");


            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog",
                "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet",
                "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed",
                "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed",
                "under the bed");


            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false,"inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom ,stairs};
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };


            frontYard.Exits = new Location[] { backYard, garden,driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm(); 
        }

        private void RedrawForm()
        {
            cbx_Exists.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
                cbx_Exists.Items.Add(currentLocation.Exits[i].Name);

            cbx_Exists.SelectedIndex = 0;

            txt_Description.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";

            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                btn_Check.Text = "Check " + hidingPlace.HidingPlaceName;
                btn_Check.Visible = true;
            }
            else
                btn_Check.Visible = false;


            if (currentLocation is IHasExteriorDoor)
                btn_GoThroughDoor.Visible = true;
            else
                btn_GoThroughDoor.Visible = false;

        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + "moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                txt_Description.Text = "You found your opponent in " + Moves
                    + "moves! He was hiding " + foundLocation.HidingPlaceName + ".";                    
            }

            Moves = 0;
            btn_Hide.Visible = true;
            btn_GoHere.Visible = false;
            btn_Check.Visible = false;
            btn_GoThroughDoor.Visible = false;
            cbx_Exists.Visible = false;
            
        }

        #region EventHandle

        private void btn_GoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cbx_Exists.SelectedIndex]);
        }

        private void btn_GoThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void btn_Check_Click(object sender, EventArgs e) 
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            btn_Hide.Visible = false;

            for (int i  = 1; i <= 10; i++)
            {
                opponent.Move();
                txt_Description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            txt_Description.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            btn_GoHere.Visible = true;
            cbx_Exists.Visible = true;
            MoveToANewLocation(livingRoom);

        }

        #endregion


    }
}

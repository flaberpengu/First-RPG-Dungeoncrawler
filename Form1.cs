﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGSchoolV1
{
    public partial class Form1 : Form
    {
        public World mainWorld;
        public MovementEngine me;
        public bool[] buttonsNeeded;
        public CombatEngine ce;
        //Constructor
        public Form1()
        {
            
            InitializeComponent();
            mainWorld = new World();
            mainWorld.InitialiseWorld();
            me = new MovementEngine();
            ce = new CombatEngine();
            tbGold.Text = mainWorld.player.gold.ToString();
            tbHealth.Text = mainWorld.player.healthPoints.ToString();
            SetLocationText();
            buttonsNeeded = me.GetButtonStates(mainWorld);
            SetButtons(buttonsNeeded);
            WriteInventoryItems();
            cbEnemy.Enabled = false;
            cbWeapon.Enabled = false;
        }
        

        //Private method to clear monsters feed when entering a different room
        private void ClearMonstersList()
        {
            rtbMonsters.Text = "";
        }

        //Private method to list all inventory items of player
        private void WriteInventoryItems()
        {
            foreach (InventoryItem item in mainWorld.player.inventory)
            {
                rtbInvItems.AppendText(item.details.name.ToString());
                rtbInvQuants.AppendText(item.quantity.ToString());
            }
        }

        //Private method to list all monsters in room when entered
        private void WriteMonsters()
        {
            foreach (Monster m in mainWorld.player.currentLocation.monsters)
            {
                rtbMonsters.AppendText($"{m.name}, {m.healthPoints}\n");
            }
        }

        //Private method to update feed when new room is entered
        private void SetMonsterAndLocationText()
        {
            rtbFeed.AppendText($"You have entered {mainWorld.player.currentLocation.name}\n");
            foreach (Monster m in mainWorld.player.currentLocation.monsters)
            {
                rtbFeed.AppendText($"There is a {m.name} here.\n");
            }
        }

        //Private method to set location text into location info box
        private void SetLocationText()
        {
            tbLocation.Text = mainWorld.player.currentLocation.name.ToString();
        }

        //Private method to update all info when new room is entered
        private void UpdateTextAndInfo()
        {
            SetLocationText();
            SetMonsterAndLocationText();
            WriteMonsters();
        }

        //Private method to update choices where appropriate
        private void UpdateComboBoxes()
        {
            foreach (Monster m in mainWorld.player.currentLocation.monsters)
            {
                cbEnemy.Items.Add(m.name);
            }
            foreach (InventoryItem i in mainWorld.player.inventory)
            {
                cbWeapon.Items.Add(i.details.name);
            }
        }

        //Private method to clear all combobox options
        private void ClearComboBoxes()
        {
            cbEnemy.Items.Clear();
            cbWeapon.Items.Clear();
        }

        //Private method to begin combat mechanics if enemies are in a room
        private void CheckEnemiesUpdateButtons()
        {
            if (mainWorld.player.currentLocation.monsters.Count() != 0)
            {
                btnNorth.Enabled = false;
                btnEast.Enabled = false;
                btnSouth.Enabled = false;
                btnWest.Enabled = false;
                cbEnemy.Enabled = true;
                cbWeapon.Enabled = true;
                btnAttack.Visible = true;
                rtbFeed.AppendText("What will you do this turn?\n");
                UpdateComboBoxes();
            }
        }

        //Public method to set buttons
        private void SetButtons(bool[] buttonsNeeded)
        {
            if (buttonsNeeded[0])
            {
                btnNorth.Enabled = true;
            }
            else
            {
                btnNorth.Enabled = false;
            }
            if (buttonsNeeded[1])
            {
                btnEast.Enabled = true;
            }
            else
            {
                btnEast.Enabled = false;
            }
            if (buttonsNeeded[2])
            {
                btnSouth.Enabled = true;
            }
            else
            {
                btnSouth.Enabled = false;
            }
            if (buttonsNeeded[3])
            {
                btnWest.Enabled = true;
            }
            else
            {
                btnWest.Enabled = false;
            }
        }

        //Private method to do general updates when changing rooms
        private void UpdateAll()
        {
            me.PutEnemiesInRoom(mainWorld);
            SetButtons(buttonsNeeded);
            UpdateTextAndInfo();
            CheckEnemiesUpdateButtons();
        }
        //Move player north
        private void btnNorth_Click(object sender, EventArgs e)
        {
            ClearMonstersList();
            buttonsNeeded = me.MoveNorth(mainWorld);
            UpdateAll();
        }

        //Move player east
        private void btnEast_Click(object sender, EventArgs e)
        {
            ClearMonstersList();
            buttonsNeeded = me.MoveEast(mainWorld);
            UpdateAll();
        }

        //Move player south
        private void btnSouth_Click(object sender, EventArgs e)
        {
            ClearMonstersList();
            buttonsNeeded = me.MoveSouth(mainWorld);
            UpdateAll();
        }

        //Move player west
        private void btnWest_Click(object sender, EventArgs e)
        {
            ClearMonstersList();
            buttonsNeeded = me.MoveWest(mainWorld);
            UpdateAll();
        }
    }
}
//TODO ADD ATTACKING MECHANIC - baseDam * random mult 0.75-1.25?
//TODO ADD MORE MONSTERS - GIVE EACH A TYPE
//TODO ROOMS CAN HAVE MULTIPLE - DIFF CHANCE EACH -----> CLASS FOR MONSTER CHANCE W TYPE AND %?
//TODO Weapons can vary mutiplier (stronger = higher)
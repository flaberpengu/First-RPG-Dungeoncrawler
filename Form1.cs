using System;
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
        public bool isFirstTime;
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
            isFirstTime = false;
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
            var monsters = new List<MonsterArrayCounterItem>();
            int index;
            foreach (Monster m in mainWorld.player.currentLocation.monsters)
            {
                index = -1;
                bool inArray = false;
                if (monsters.Count != 0)
                {
                    for (int i = 0; i < monsters.Count; i++)
                    {
                        if (monsters[i].monsterName == m.name)
                        {
                            index = i;
                            monsters[i].count++;
                            inArray = true;
                        }
                    }
                }
                if (!inArray)
                {
                    monsters.Add(new MonsterArrayCounterItem(m.name, 1));
                    index = (monsters.Count - 1);
                }
                if (isFirstTime)
                {
                    rtbMonsters.AppendText($"{m.name + " " + monsters[index].count.ToString()}, {m.healthPoints}\n");
                    m.cbMonsterName = ($"{m.name + " " + monsters[index].count.ToString()}");
                }
                else
                {
                    rtbMonsters.AppendText($"{m.cbMonsterName}, {m.healthPoints}\n");
                }
            }
        }

        //Private method to update feed when new room is entered
        private void SetMonsterAndLocationText()
        {
            rtbFeed.AppendText($"You have entered {mainWorld.player.currentLocation.name}\n");
            foreach (Monster m in mainWorld.player.currentLocation.monsters)
            {
                rtbFeed.AppendText($"There is a {m.name} here.\n");
                isFirstTime = true;
            }
        }

        //Private method to set location text into location info box
        private void SetLocationText()
        {
            tbLocation.Text = mainWorld.player.currentLocation.name.ToString();
        }

        //Private method to update player health displayed
        private void UpdatePlayerHealth()
        {
            tbHealth.Text = Convert.ToString(mainWorld.player.healthPoints);
        }

        //Private method to update all info when new room is entered
        private void UpdateTextAndInfo()
        {
            SetLocationText();
            SetMonsterAndLocationText();
            WriteMonsters(); //FIX
        }

        //Private method to update choices where appropriate
        private void UpdateComboBoxes()
        {
            var monsters = new List<MonsterArrayCounterItem>();
            int index;
            foreach (Monster m in mainWorld.player.currentLocation.monsters)
            {
                index = -1;
                bool inArray = false;
                if (monsters.Count != 0)
                {
                    for (int i = 0; i < monsters.Count; i++)
                    {
                        if (monsters[i].monsterName == m.name)
                        {
                            index = i;
                            monsters[i].count++;
                            inArray = true;
                        }
                    }
                }
                if (!inArray)
                {
                    monsters.Add(new MonsterArrayCounterItem(m.name, 1));
                    index = (monsters.Count - 1);
                }
                if (isFirstTime)
                {
                    cbEnemy.Items.Add((m.name + " " + monsters[index].count.ToString()));
                }
                else
                {
                    cbEnemy.Items.Add(m.cbMonsterName);
                }
                
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
            if (mainWorld.player.currentLocation.monsters.Count != 0)
            {
                btnNorth.Enabled = false;
                btnEast.Enabled = false;
                btnSouth.Enabled = false;
                btnWest.Enabled = false;
                cbEnemy.Enabled = true;
                cbWeapon.Enabled = true;
                btnAttack.Visible = true;
                rtbFeed.AppendText("What will you do this turn?\n");
                ClearComboBoxes();
                UpdateComboBoxes();
            }
            else
            {
                buttonsNeeded = me.GetButtonStates(mainWorld);
                SetButtons(buttonsNeeded);
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

        //Private method to clear monsters from the relevant textbox and then rewrite them (ie update monsters' health)
        private void ClearAndUpdateMonsters()
        {
            rtbMonsters.Clear();
            WriteMonsters(); //FIX
        }

        //Private method to be run when an attack is made
        private void AttackEnemy() //Attack order: player, monster
        {
            int monsterID = 0;
            int preAttackMHP = 0;
            int preAttackPHP = mainWorld.player.healthPoints;
            int monsterIndexNum = 0;
            string monsterName = "";
            for (int i = 0; i < mainWorld.player.currentLocation.monsters.Count; i++)
            {
                if (mainWorld.player.currentLocation.monsters[i].cbMonsterName == cbEnemy.Text)
                {
                    monsterID = mainWorld.player.currentLocation.monsters[i].localID;
                    preAttackMHP = mainWorld.player.currentLocation.monsters[i].healthPoints;
                    monsterIndexNum = i;
                    monsterName = mainWorld.player.currentLocation.monsters[i].cbMonsterName;
                }
            }
            string weaponName = cbWeapon.Text;
            mainWorld = ce.AttackEnemy(mainWorld, monsterID, weaponName);
            int monsterLostHealth = preAttackMHP - mainWorld.player.currentLocation.monsters[monsterIndexNum].healthPoints;
            int playerLostHealth = preAttackPHP - mainWorld.player.healthPoints;
            rtbFeed.AppendText($"Player attacked {monsterName} for {Convert.ToString(monsterLostHealth)} damage.\n");
            if (mainWorld.player.currentLocation.monsters[monsterIndexNum].healthPoints <= 0)
            {
                rtbFeed.AppendText($"{monsterName} is dead.\n");
                mainWorld.player.currentLocation.monsters.RemoveAt(monsterIndexNum);
            }
            else
            {
                rtbFeed.AppendText($"{monsterName} is now on {Convert.ToString(mainWorld.player.currentLocation.monsters[monsterIndexNum].healthPoints)} HP.\n");
                rtbFeed.AppendText($"{monsterName} attacked Player for {playerLostHealth} damage.\n");
                if (mainWorld.player.healthPoints <= 0)
                {
                    rtbFeed.AppendText("You have died. Exiting.\n");
                    System.Threading.Thread.Sleep(5000);
                }
                else
                {
                    rtbFeed.AppendText($"You now have {mainWorld.player.healthPoints} HP.\n");
                }
            }
            CheckEnemiesUpdateButtons();
            ClearAndUpdateMonsters();
            UpdatePlayerHealth();
            btnAttack.Enabled = false;
            if (mainWorld.player.currentLocation.monsters.Count == 0)
            {
                cbEnemy.Enabled = false;
                cbWeapon.Enabled = false;
                ClearComboBoxes();
            }
            isFirstTime = false;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            AttackEnemy();
        }

        private void cbEnemy_TextUpdate(object sender, EventArgs e)
        {
            if (cbEnemy.Text != "" && cbWeapon.Text != "")
            {
                btnAttack.Enabled = true;
            }
        }
    }
}
//TODO ADD MORE MONSTERS - GIVE EACH A TYPE
//TODO ROOMS CAN HAVE MULTIPLE - DIFF CHANCE EACH -----> CLASS FOR MONSTER CHANCE W TYPE AND %?
//TODO Weapons can vary mutiplier (stronger = higher)
//TODO Add crit hits
//TODO Add graphics - unity? 

    //Current: add more monster types, random each per room, do max per room, id each per room, increase multiplier? (lack of variation)
    //ADDED: MORE MONST TYPES, rng for which, added caps for monsters per room, added iterating to gen multiple enemies per room, cb and rtb show diff num enemies - IS DEAD DOES NOT WORK!!, fixed -ve damage
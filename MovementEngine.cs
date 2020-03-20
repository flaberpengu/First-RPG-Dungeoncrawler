using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class MovementEngine
    {
        private Random rnd;
        //Contructor
        public MovementEngine()
        {
            rnd = new Random();
        }
        //Public method to put enemies in a room upon entry
        public void PutEnemiesInRoom(World world)
        {
            int chance = world.player.currentLocation.chanceForEnemies;
            int maxEnemies = world.player.currentLocation.maxEnemies;
            for (int i = 0; i < maxEnemies; i++)
            {
                int randomNumber = rnd.Next(0, 100);
                if (randomNumber < chance)
                {
                    world.AddMonster(i);
                }
                else
                {
                    i = maxEnemies;
                }
            }
        }
        //Public method to get a bool array (NESW) of which buttons should be activated
        public bool[] GetButtonStates(World world)
        {
            bool[] buttonStatesNeeded = { true, true, true, true };
            if (world.player.currentLocation.locationToNorth.name.Equals("NONE"))
            {
                buttonStatesNeeded[0] = false;
            }
            if (world.player.currentLocation.locationToEast.name.Equals("NONE"))
            {
                buttonStatesNeeded[1] = false;
            }
            if (world.player.currentLocation.locationToSouth.name.Equals("NONE"))
            {
                buttonStatesNeeded[2] = false;
            }
            if (world.player.currentLocation.locationToWest.name.Equals("NONE"))
            {
                buttonStatesNeeded[3] = false;
            }
            return buttonStatesNeeded;
        }
        //Public method to 'move' the player north
        public bool[] MoveNorth(World world)
        {
            bool[] buttonStatesNeeded;
            world.player.currentLocation = world.player.currentLocation.locationToNorth;
            buttonStatesNeeded = GetButtonStates(world);
            return buttonStatesNeeded;
        }
        //Public method to 'move' the player east
        public bool[] MoveEast(World world)
        {
            bool[] buttonStatesNeeded;
            world.player.currentLocation = world.player.currentLocation.locationToEast;
            buttonStatesNeeded = GetButtonStates(world);
            return buttonStatesNeeded;
        }
        //Public method to 'move' the player south
        public bool[] MoveSouth(World world)
        {
            bool[] buttonStatesNeeded;
            world.player.currentLocation = world.player.currentLocation.locationToSouth;
            buttonStatesNeeded = GetButtonStates(world);
            return buttonStatesNeeded;
        }
        //Public method to 'move' the player west
        public bool[] MoveWest(World world)
        {
            bool[] buttonStatesNeeded;
            world.player.currentLocation = world.player.currentLocation.locationToWest;
            buttonStatesNeeded = GetButtonStates(world);
            return buttonStatesNeeded;
        }
    }
}

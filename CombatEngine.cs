﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class CombatEngine
    {
        public double GetDamageMultiplier() //Gets random damage multiplier in range 0.75 to 1.25
        {
            Random randomGen = new Random();
            double newNum = randomGen.NextDouble();
            newNum /= 2;
            newNum += 0.75;
            return newNum;
        }
        public World AttackEnemy(World mainWorld, int monsterID, string weaponName)
        {
            int weaponIndex = -1;
            int monsterIndex = -1;

            for (int i = 0; i < mainWorld.player.inventory.Count; i++)
            {
                if (mainWorld.player.inventory[i].details.name == weaponName)
                {
                    weaponIndex = i;
                }
            }
            for (int i = 0; i < mainWorld.player.currentLocation.monsters.Count; i++)
            {
                if (mainWorld.player.currentLocation.monsters[i].localID == monsterID)
                {
                    monsterIndex = i;
                }
            }

            double monsterMultiplier = GetDamageMultiplier();
            double damageToPlayer = mainWorld.player.currentLocation.monsters[monsterIndex].baseDamage * monsterMultiplier;
            damageToPlayer = Math.Round(damageToPlayer);

            double playerMultiplier = GetDamageMultiplier();
            double damageToMonster = mainWorld.player.inventory[weaponIndex].details.baseDamage * playerMultiplier;
            damageToMonster = Math.Round(damageToMonster);

            mainWorld.player.currentLocation.monsters[monsterIndex].healthPoints -= Convert.ToInt32(damageToMonster);

            if (mainWorld.player.currentLocation.monsters[monsterIndex].healthPoints > 0)
            {
                mainWorld.player.healthPoints -= Convert.ToInt32(damageToPlayer);
            }

            return mainWorld;
        }
    }
}

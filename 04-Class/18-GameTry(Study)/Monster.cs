using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GameTry_Study_
{
    internal class Monster : LivingBeing
    {
        // Fields
        private string _difficulty;

        // Constructor
        public Monster(string difficulty)
        {
            _difficulty = difficulty;
            switch (difficulty)
            {
                case "Easy":
                    Name = "Yarasa";
                    HealthPoint = 300;
                    ManaPoint = 0;
                    AttackPoint = 25;
                    SkillDamage = 0;
                    break;
                case "Medium":
                    Name = "Tek Gözlü Yaratık";
                    HealthPoint = 500;
                    ManaPoint = 0;
                    AttackPoint = 45;
                    SkillDamage = 0;
                    break;
                case "Hard":
                    Name = "Dört Kollu Canavar";
                    HealthPoint = 800;
                    ManaPoint = 200;
                    AttackPoint = 75;
                    SkillDamage = 150;
                    break;
                default:
                    break;
            }
        }

        // Properties
        public string Difficulty
        {
            get
            {
                return _difficulty;
            }
        }

        // Abstract Override Method
        public override void Attack(int damage, int hp)
        {

        }
    }
}

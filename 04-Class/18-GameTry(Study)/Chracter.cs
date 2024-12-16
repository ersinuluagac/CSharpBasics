using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GameTry_Study_
{
    public class Character : LivingBeing
    {
        // Fields
        private int _characterType;
        private string _weapon;
        private int _armorPoint;


        //Constructor
        public Character(string name, int characterType)
        {
            Name = name;
            switch (characterType)
            {
                case 1:
                    _characterType = 1; // warrior
                    HealthPoint = 1000;
                    ManaPoint = 0;
                    AttackPoint = 100;
                    SkillDamage = 0;
                    _weapon = "Kılıç";
                    _armorPoint = 25;
                    break;
                case 2:
                    _characterType = 2; // mage
                    HealthPoint = 800;
                    ManaPoint = 400;
                    AttackPoint = 50;
                    SkillDamage = 200;
                    _weapon = "Asa";
                    _armorPoint = 15;
                    break;
                default:
                    break;
            }
        }

        // Properties
        public string CharacterType
        {
            get { return _characterType == 1 ? "Savaşçı" : "Büyücü"; }
        }
        public string Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                if (_characterType == 1)
                {
                    _weapon = "Kılıç";
                }
                else if (_characterType == 2)
                {
                    _weapon = "Asa";
                }
            }
        }
        public int ArmorPoint
        {
            get { return _armorPoint; }
        }


        // Abstract Override Method
        public override void Attack(int damage, int hp)
        {
            
        }
        public void Quit()
        {
            Console.WriteLine("Zindandan kaçıldı... Girişe geri dönülüyor!");
        }
    }
}

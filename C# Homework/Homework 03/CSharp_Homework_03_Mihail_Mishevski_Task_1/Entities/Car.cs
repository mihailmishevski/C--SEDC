using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Homework_03_Mihail_Mishevski_Task_1.Entities
{
    internal class Car
    {
        public string Model;

        public int Speed;

        public int result;

        public Car(string carModel, int carSpeed)
        {
            Model = carModel;
            Speed = carSpeed;
        }

        public int CalculateSpeed(int Skill)
        {
            result = Skill * Speed;
            return result;
        }
    }
}

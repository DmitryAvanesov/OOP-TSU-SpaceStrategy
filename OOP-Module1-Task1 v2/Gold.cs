﻿using System;

namespace OOP_Module1_Task1_v2
{
    class Gold : Resource
    {
        public override string Name => "Gold";

        public Gold()
        {
            Random random = new Random();
            Amount = random.Next(1, 3);
        }
    }
}
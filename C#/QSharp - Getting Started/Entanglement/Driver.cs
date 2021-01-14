﻿using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Entanglement
{
    class Driver
    {
        static void Main(string[] args)
        {
            var ones = 0;
            var equal = 0;
            using (var qsim = new QuantumSimulator())
            {
                for (int index = 0; index < 1000; index++)
                {
                    var (qubitOne, qubitTwo) = Entanglement.Run(qsim).Result;

                    if (qubitOne == Result.One)
                    {
                        ones++;
                    }

                    if (qubitOne == qubitTwo)
                    {
                        equal++;
                    }
                }
            }

            Console.WriteLine("Entanglement Result: ");
            Console.WriteLine($"\t   One: {ones}");
            Console.WriteLine($"\t  Zero: {1000-ones}");
            Console.WriteLine($"\t Equal: {equal/1000*100}");
            Console.ReadKey();
        }
    }
}
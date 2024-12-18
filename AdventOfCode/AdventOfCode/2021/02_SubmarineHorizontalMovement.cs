﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using static System.Int32;

namespace AdventOfCode._2021
{
    public class _02_SubmarineHorizontalMovement : IBaseClass
    {
        List<Movement> input = new List<Movement>(
            
            );
        public void Run()
        {
            List<Movement> movements = Movement.Builder();
            Int32 upDown = 0;
            Int32 moved = 0;

            foreach (Movement movement in movements)
            {
                switch (movement.MoveDirection)
                {
                    case Direction.Up:
                        upDown -= movement.MoveAmount;
                        break;
                    case Direction.Down:
                        upDown += movement.MoveAmount;
                        break;
                    case Direction.Forward:
                        moved += movement.MoveAmount;
                        break;
                    default:
                        break;
                }
            }

            Int32 horizontalPositionTimesFinalDeapthAwnser = moved * upDown;

        }

        public void RunSecond()
        {
            List<Movement> movements = Movement.Builder();
            Int32 upDown = 0;
            Int32 moved = 0;
            Int32 aim = 0;

            foreach (Movement movement in movements)
            {
                switch (movement.MoveDirection)
                {
                    case Direction.Up:
                        aim -= movement.MoveAmount;
                        break;
                    case Direction.Down:
                        aim += movement.MoveAmount;
                        break;
                    case Direction.Forward:
                        upDown += movement.MoveAmount * aim;
                        moved += movement.MoveAmount;
                        break;
                    default:
                        break;
                }
            }

            Int32 horizontalPositionTimesFinalDeapthAwnser = moved * upDown;

        }

        public class Movement
        {
            public Direction MoveDirection;
            public Int32 MoveAmount = 0;

            public Movement(Direction direction, Int32 moveAmount)
            {
                MoveDirection = direction;
                MoveAmount = moveAmount;
            }
            

            public static List<Movement> Builder()
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                List<String> moveAndAmount = "forward 9,forward 7,down 7,down 3,forward 2,forward 3,forward 7,down 6,forward 7,down 7,forward 9,down 9,up 2,down 5,up 1,forward 5,forward 6,up 4,down 3,down 4,down 5,up 6,down 3,forward 6,forward 4,down 4,forward 5,down 2,up 1,up 8,down 1,down 6,forward 8,down 4,forward 8,forward 6,forward 2,forward 2,forward 3,forward 8,up 9,up 2,down 3,up 3,forward 5,forward 2,up 5,forward 9,down 7,down 2,up 7,down 4,down 6,up 2,down 9,forward 7,down 8,forward 6,up 1,forward 6,forward 4,down 5,forward 6,down 8,down 3,forward 7,down 8,up 7,down 1,up 1,forward 9,down 7,up 3,down 6,down 6,down 6,down 7,down 9,down 6,down 9,down 8,down 3,down 7,down 3,up 8,down 5,down 9,up 4,forward 5,forward 5,forward 2,up 1,forward 6,down 6,down 2,forward 1,forward 8,down 4,down 1,down 8,down 7,forward 6,forward 8,down 8,up 1,up 1,forward 1,forward 3,up 8,down 1,forward 4,down 3,forward 3,forward 4,forward 3,down 3,down 9,down 3,up 6,forward 6,forward 8,forward 2,up 1,up 4,up 4,down 2,down 2,down 2,forward 7,up 9,down 9,up 1,down 5,forward 4,down 2,down 4,forward 3,down 7,down 9,forward 1,up 5,down 5,down 5,forward 2,down 6,forward 8,up 4,forward 6,up 1,down 4,forward 2,down 9,forward 5,down 7,down 8,down 9,forward 6,up 6,forward 9,forward 9,down 7,forward 7,forward 5,up 9,forward 3,down 9,down 1,down 8,down 4,forward 5,forward 6,forward 8,forward 8,down 4,down 3,down 8,forward 3,down 6,down 8,down 2,up 8,up 9,down 6,forward 3,down 4,down 6,forward 9,forward 6,up 2,down 8,forward 2,down 7,forward 9,up 9,down 9,down 2,forward 9,down 4,down 9,up 4,forward 6,down 2,down 9,forward 8,forward 2,up 8,forward 9,forward 2,forward 3,down 2,up 3,forward 9,down 6,down 3,down 1,forward 9,forward 8,down 9,up 7,down 8,up 7,forward 1,forward 1,forward 7,down 2,down 1,up 1,up 6,down 5,up 9,up 7,forward 1,forward 6,forward 1,up 4,down 6,forward 2,up 7,down 2,up 8,forward 9,forward 6,forward 3,forward 8,down 1,forward 8,up 3,forward 1,forward 1,up 9,down 1,down 8,down 2,forward 8,down 8,forward 7,down 5,forward 8,forward 3,forward 6,forward 7,up 5,down 5,forward 8,down 2,forward 3,down 4,down 9,forward 6,forward 5,up 4,forward 7,down 3,forward 9,forward 5,down 3,up 5,forward 4,forward 8,down 7,up 2,forward 7,down 5,up 2,down 9,forward 4,down 3,forward 5,forward 4,down 3,forward 6,up 1,forward 8,down 1,up 7,forward 8,up 1,up 1,forward 2,down 8,forward 4,forward 8,up 6,forward 5,forward 7,up 6,up 4,up 6,down 1,forward 3,down 1,down 1,down 8,forward 8,down 5,down 5,forward 5,forward 9,down 9,forward 7,down 3,down 5,forward 6,down 1,down 5,up 8,down 9,forward 3,down 6,up 2,down 2,forward 2,up 2,forward 8,down 2,forward 9,forward 2,down 7,down 5,forward 1,forward 7,up 6,up 8,forward 8,forward 8,up 3,forward 8,down 6,down 6,forward 4,down 8,down 5,down 7,forward 1,forward 9,forward 9,up 5,down 9,down 1,forward 4,forward 1,up 9,forward 6,down 6,forward 2,up 6,forward 9,up 1,down 2,up 3,forward 2,forward 1,forward 6,down 9,up 1,forward 7,up 3,forward 6,forward 6,up 2,down 8,forward 4,down 4,forward 2,forward 2,down 4,down 7,down 4,down 5,forward 3,down 1,forward 1,forward 8,down 7,up 1,forward 7,forward 2,down 9,down 2,up 2,forward 3,down 4,down 7,down 8,forward 4,forward 5,forward 3,up 3,down 6,forward 4,forward 4,forward 8,forward 1,up 2,up 3,down 4,up 9,forward 1,forward 1,forward 9,down 2,down 5,up 9,down 7,down 9,down 2,down 4,forward 1,forward 1,forward 8,down 9,down 6,forward 2,up 3,down 8,forward 1,forward 8,forward 4,up 7,forward 5,forward 2,forward 2,up 8,down 5,forward 6,down 3,up 5,forward 8,forward 3,forward 9,down 1,down 3,forward 8,down 2,forward 6,forward 2,down 3,down 3,forward 6,forward 4,forward 7,forward 2,up 7,up 4,up 6,forward 9,down 3,down 3,up 7,down 4,up 3,up 3,down 5,forward 1,up 3,down 1,forward 2,up 9,forward 7,down 6,forward 4,forward 8,up 1,forward 6,down 7,down 4,up 9,forward 4,down 7,up 1,forward 9,down 4,down 7,forward 1,down 6,down 6,forward 3,up 8,forward 3,down 1,down 5,down 8,forward 2,up 5,forward 2,up 7,forward 5,forward 1,forward 3,forward 4,forward 5,up 1,forward 9,down 5,down 7,up 9,down 9,forward 7,up 6,up 7,forward 2,forward 1,up 4,forward 6,forward 9,down 1,forward 4,down 5,forward 4,down 3,down 5,forward 6,forward 3,down 3,down 8,down 2,down 4,down 6,down 4,forward 2,up 9,down 3,forward 1,forward 9,forward 5,forward 5,forward 9,up 1,down 4,down 4,up 7,down 3,up 3,up 4,forward 3,forward 1,forward 8,up 6,down 8,down 4,forward 7,forward 9,forward 2,forward 8,up 2,down 4,down 5,forward 9,down 6,down 7,down 8,up 8,forward 3,forward 7,forward 8,up 2,down 9,down 6,forward 3,forward 4,down 4,forward 2,up 6,forward 1,forward 7,down 2,down 1,forward 2,forward 2,down 2,forward 2,forward 7,up 4,down 3,forward 9,down 7,down 7,down 6,forward 3,forward 9,down 9,forward 2,down 5,down 4,down 9,up 9,down 6,down 8,down 1,forward 8,up 4,up 4,down 8,forward 6,down 2,forward 4,forward 3,forward 2,forward 4,down 4,forward 6,down 9,up 7,up 5,down 7,down 4,up 3,forward 4,down 9,forward 6,forward 4,forward 4,down 9,forward 3,forward 2,up 7,forward 3,down 1,down 3,up 5,down 8,down 3,down 4,forward 7,forward 9,up 2,forward 3,up 4,down 5,up 3,up 9,down 6,down 2,down 5,up 4,up 6,forward 4,forward 6,up 5,up 5,forward 8,down 6,forward 6,down 7,down 5,down 3,down 8,forward 6,forward 9,forward 9,up 9,down 3,up 5,forward 4,down 7,forward 5,down 7,down 4,forward 2,forward 9,down 8,up 3,up 7,down 7,up 7,forward 3,down 2,forward 7,down 4,forward 1,down 6,forward 1,up 4,down 7,up 3,forward 7,forward 5,forward 7,forward 6,up 2,down 4,down 8,down 4,up 3,forward 3,up 3,up 3,down 7,down 2,down 3,forward 7,down 6,down 9,up 1,down 8,down 6,down 3,up 2,up 6,forward 9,forward 5,forward 4,forward 9,down 9,forward 2,up 7,down 4,down 8,up 2,forward 6,up 6,up 4,down 2,forward 6,forward 4,up 3,down 6,forward 5,forward 3,up 4,down 7,down 2,down 6,up 7,forward 2,forward 1,forward 3,down 2,forward 1,forward 2,forward 4,down 2,down 5,down 7,down 8,down 1,up 1,up 1,forward 9,down 3,down 1,forward 4,up 6,up 8,forward 7,forward 9,down 3,forward 9,down 9,forward 6,down 1,forward 7,down 9,forward 1,down 8,forward 8,up 7,forward 4,up 5,up 9,forward 1,forward 4,forward 3,down 3,down 8,up 3,forward 1,up 5,forward 5,up 6,forward 8,forward 1,down 7,forward 2,down 9,forward 3,forward 7,forward 2,down 4,forward 2,up 6,down 7,up 3,forward 7,down 8,down 3,forward 2,up 7,down 2,down 8,up 6,forward 7,forward 1,down 3,forward 2,forward 8,down 8,forward 1,down 7,down 1,up 5,up 3,forward 5,down 5,up 9,up 9,down 3,up 3,down 4,down 6,up 7,forward 3,up 5,down 3,forward 4,down 1,up 1,up 6,down 8,forward 5,up 2,down 5,forward 6,forward 4,forward 9,down 9,down 5,forward 5,down 7,down 7,down 8,forward 3,down 6,forward 5,forward 5,down 6,forward 3,down 7,up 4,up 3,down 5,forward 9,forward 9,up 9,down 1,up 2,up 3,down 7,forward 3,down 7,down 4,down 5,down 1,down 4,up 9,forward 1,up 8,forward 7,up 6,down 1,up 2,forward 2,up 9,down 6,forward 4,down 2,up 5,forward 1,forward 4,down 6,down 2,up 8,forward 2,forward 8,forward 4,down 9,up 3,forward 5,forward 9,forward 4,down 2,up 4,up 9,down 5,up 2,forward 6,up 2,down 6,up 5,up 3,up 9,forward 8,down 2,forward 7,up 8,down 9,forward 2,forward 2,down 6,forward 9,forward 2,forward 8,up 3,forward 5,down 4,forward 2,down 7,up 6,forward 7,down 6,down 8,down 3,up 4,up 5,down 2,down 9,forward 2,down 7,forward 2,forward 3,forward 9,down 6,down 1,forward 6,down 5,forward 2,down 5,down 1,forward 5,down 4,down 6,down 5,forward 9,up 6,up 5,up 2,down 1,down 8,forward 4,down 2,forward 5,down 1,forward 7,down 8,down 9,down 7,up 1,forward 2,up 8,down 9,down 2,down 1,down 9,down 2,down 5,forward 9,forward 1,down 1,forward 9,forward 7,down 6,down 1,down 7,forward 4,forward 1,forward 4,forward 5,forward 5,down 2,forward 7,forward 6,forward 3,forward 9,up 1,down 5,down 4,down 2,forward 1,up 7,forward 2"
                    .Split(',')
                    .ToList();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                String[] directionAndMovement = new String[2];
                List<Movement> movements = new List<Movement>();
                foreach (String t in moveAndAmount)
                {
                    directionAndMovement = t.Split(' ');
                    Enum.TryParse(directionAndMovement[0], true, out Direction direction);

                    movements.Add(new Movement(direction, Parse(directionAndMovement[1])));
                }

                return movements;
            }
        }

        public enum Direction
        {
            Up,
            Down,
            Forward
        }
    }
}
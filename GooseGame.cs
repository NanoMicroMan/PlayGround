﻿using System;
using System.Collections.Generic;

 namespace Sandbox
 {
     public class GooseGame
     {
         public static void PrintAllSpaces(in int spaceIndex)
         {
             for (int i = 1; i < 66; i++)
                 PrintSpace(i);
         }

         public static void PrintSpace(in int spaceIndex)
         {
             Console.Out.WriteLine(Space.CreateInstance(spaceIndex).GetText(spaceIndex));
         }
     }
     
 public abstract class Space
    {
        private static readonly Dictionary<int, Space> SpecialSpaces = new Dictionary<int, Space>
        {
            {6, new SpaceBridge(6)}, 
            {19, new SpaceHotel()}, 
            {31, new SpaceWell()}, 
            {42, new SpaceMaze()}, 
            {50, new SpacePrison()},
            {51, new SpacePrison()},
            {52, new SpacePrison()},
            {53, new SpacePrison()},
            {54, new SpacePrison()},
            {55, new SpacePrison()},
            {58, new SpaceDeath()},
            {63, new SpaceWon()},
            {64, new SpaceBeyond()}
        };

        public static Space CreateInstance(int spaceIndex)
        {
            return  SpecialSpaces.TryGetValue(Math.Min(spaceIndex, 64), out var space) ? space:
                    spaceIndex % 6 == 0 ? new SpaceJump() : new SpaceRegular();
        }

        public abstract String GetText(int spaceIndex);
    }
    
    public class SpaceRegular : Space
    {
        public override string GetText(int spaceIndex) => "Stay in space " + spaceIndex;
    }

    public class SpaceJump : Space
    {
        public override string GetText(int spaceIndex) => "Move two spaces forward";
    }
    
    public class SpaceBridge : Space
    {
        private readonly int _bridgeLength;
        public SpaceBridge(int bridgeLength)
        {
            _bridgeLength = bridgeLength;
        }

        public override string GetText(int spaceIndex) => "The Bridge: Go to space " + (spaceIndex + _bridgeLength);
    }
    
    public class SpaceHotel : Space
    {
        public override string GetText(int spaceIndex) => "The Hotel: Stay for (miss) one turn";
    }

    public class SpacePrison : Space
    {
        public override string GetText(int spaceIndex) => "The Maze: Go back to space 39";
    }

    public class SpaceMaze : Space
    {
        public override string GetText(int spaceIndex) => "The Prison: Wait until someone comes to release you - they then take your place";
    }

    public class SpaceWell : Space
    {
        public override string GetText(int spaceIndex) => "The Well: Wait until someone comes to pull you out - they then take your place";
    }
    
    public class SpaceWon : Space 
    {
        public override string GetText(int spaceIndex) => "Finish: you ended the game";
    }
    
    public class SpaceDeath : Space
    {
        public override string GetText(int spaceIndex) => "Death: Return your piece to the beginning - start the game again";
    }
    
    public class SpaceBeyond : Space
    {
        public override string GetText(int spaceIndex) => "Move to space 53 and stay in prison for two turns";
    }
}
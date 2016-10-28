﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyModel
    {
        public enum colorType { red, pink, orange, green }
        public enum direction
        {
            up,
            right,
            down,
            left
        }

        direction mDir = direction.right; //direction the AI is going from the beginning
        colorType mColor; //color of the enemy

        bool mIsRunningAway = false; //if true enemy is blue and running away from player
        bool mIsDead = false; //if the enemy gets eaten it must be heading to the box
        bool mHasEatenPacman = false; // if pacman gets eaten by enemy

        int mX = 1; //coordinates of the enemy
        int mY = 1;
        int mXObserver, mYObserver; //coordinates to check. Either player cooridnates or coordinates from begintile

        int mAnimation = 1;

        public int XObserver
        {
            get { return mXObserver; }
            set { mXObserver = value; }
        }

        public int YObserver
        {
            get { return mYObserver; }
            set { mYObserver = value; }
        }

        
        public int Animation
        {
            get { return mAnimation; }
            set { mAnimation = value; }
        }

        public colorType Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public bool IsRunningAway
        {
            get { return mIsRunningAway; }
            set { mIsRunningAway = value; }
        }

        public bool IsDead
        {
            get { return mIsDead; }
            set { mIsDead = value; }
        }

        public bool HasEatenPacman
        {
            get { return mHasEatenPacman; }
            set { mHasEatenPacman = value; }
        }

        public int X
        {
            get { return mX; }
            set { mX = value; }
        }

        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }

        public direction Direction
        {
            get { return mDir; }
            set { mDir = value; }
        }

    }
}

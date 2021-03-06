﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMario
{
    public partial class MainWorld : Form
    {
        bool right;
        bool left;
        bool up;
        bool down;
        bool jump;

        bool OnPlatform;

        int MarioState;


        int G = 25;
        int Force;

        public MainWorld()
        {
            InitializeComponent();

            Character.Top = this.Size.Height - 40 - Character.Height; //Start on ground

            MarioState = 0; //Start Mario with initial state
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (right == true)
            {
                MoveRight(5, Character);
                if (MarioState != 2 && MarioState != 3 && MarioState != 4)
                    MarioState = 2;
                else if (MarioState == 2)
                    MarioState = 3;
                else if (MarioState == 3)
                    MarioState = 4;
                else if (MarioState == 4)
                    MarioState = 2;
            }

            if (left == true)
            {
                MoveLeft(5, Character);
                if (MarioState != 5 && MarioState != 6 && MarioState != 7)
                    MarioState = 5;
                else if (MarioState == 5)
                    MarioState = 6;
                else if (MarioState == 6)
                    MarioState = 7;
                else if (MarioState == 7)
                    MarioState = 5;
            }

            if (down == true)
            {
                //MoveDown(5, Character); //Legacy code used for debugging
                //if (MarioState != 5 && MarioState != 6 && MarioState != 7 && MarioState != 9 && MarioState != 1)
                //    MarioState = 10;
                //else
                //    MarioState = 11;
            }

            if (up == true)
                MoveUp(5,Character);

            if (jump == true)
            {
                Character.Top -= Force;
                Force -= 1;

                if (MarioState != 5 && MarioState != 6 && MarioState != 7 && MarioState != 9 && MarioState != 1)
                    MarioState = 8;
                else
                    MarioState = 9;
            }

            if(Character.Top + Character.Height >= this.Size.Height - 40) //Check whether character touched the floor
            {
                Character.Top = this.Size.Height - 40 - Character.Height;
                jump = false;
            }
            else if(OnPlatform == true)
            {

            }
            else
            {
                Character.Top += 8; // falling
            }

            if (up == false && down == false && left == false && right == false && jump == false)
            {
                if (MarioState != 5 && MarioState != 6 && MarioState != 7 && MarioState != 9 && MarioState != 1)
                    MarioState = 0;
                else
                    MarioState = 1;
            }

            CollisionCheck(PlatformTest);

        }

        public int CollisionCheck (PictureBox obstacle)
        {
            int result = 0; //For debugging use
            //EDGE Collision
            if (Character.Bottom > obstacle.Top + Character.Height/3 && Character.Top < obstacle.Bottom && Character.Right > obstacle.Left && Character.Left < obstacle.Right && Character.Left > obstacle.Left)
            {
                left = false;
                Character.Left = obstacle.Right;
                result = 2;
            }
            if(Character.Bottom > obstacle.Top + +Character.Height / 3 && Character.Top < obstacle.Bottom && Character.Left < obstacle.Right && Character.Right > obstacle.Left)
            {
                right = false;
                Character.Left = obstacle.Left - Character.Width;
                result = 1;
            }

            //TOP Collision
            //if (Character.Left + Character.Width - 1 > PlatformTest.Left && Character.Left + Character.Width + 5 < PlatformTest.Left + PlatformTest.Width && Character.Top + Character.Top + Character.Height >= PlatformTest.Location.Y && Character.Top < PlatformTest.Location.Y)
            if (Character.Left + Character.Width> obstacle.Left && Character.Left < obstacle.Left + obstacle.Width && Character.Top + Character.Height >= obstacle.Top && Character.Top < obstacle.Top)
            {
                Character.Top = PlatformTest.Top - Character.Height; //this.Size.Height - 40 - PlatformTest.Height - Character.Height;
                Force = 0; 
                OnPlatform = true; //Prevent falling
                jump = false;
                result = 3;
            }
            else
                OnPlatform = false;

            return result;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //Debug use
        {
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.Down)
                down = true;
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if(jump != true)
            {
                if(e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //Debug use
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;

        }

        public void MoveRight(int distance, PictureBox sprite) { sprite.Location = new Point(sprite.Location.X + distance, sprite.Location.Y); }
        public void MoveLeft(int distance, PictureBox sprite) { sprite.Location = new Point(sprite.Location.X - 5, sprite.Location.Y); }
        public void MoveUp(int distance, PictureBox sprite) { sprite.Location = new Point(sprite.Location.X, sprite.Location.Y - 5); }
        public void MoveDown(int distance, PictureBox sprite) { sprite.Location = new Point(sprite.Location.X, sprite.Location.Y + 5); }
        public void Jump(PictureBox sprite)
        {
            Character.Top -= Force;
            Force -= 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (MarioState)
            {
                case 0:
                    Character.Image = Image.FromFile("Super Mario.gif");
                    break;
                case 1:
                    Character.Image = Image.FromFile("Super Mario Left.gif");
                    break;
                case 2:
                    Character.Image = Image.FromFile("Super Mario - Walk1.gif");
                    break;
                case 3:
                    Character.Image = Image.FromFile("Super Mario - Walk3.gif");
                    break;
                case 4:
                    Character.Image = Image.FromFile("Super Mario - Walk2.gif");
                    break;
                case 5:
                    Character.Image = Image.FromFile("Super Mario - Walk1 Left.gif");
                    break;
                case 6:
                    Character.Image = Image.FromFile("Super Mario - Walk3 Left.gif");
                    break;
                case 7:
                    Character.Image = Image.FromFile("Super Mario - Walk2 Left.gif");
                    break;
                case 8:
                    Character.Image = Image.FromFile("Super Mario - Jump.gif");
                    break;
                case 9:
                    Character.Image = Image.FromFile("Super Mario - Jump Left.gif");
                    break;
                case 10:
                    Character.Image = Image.FromFile("Super Mario - Duck.gif");
                    break;
                case 11:
                    Character.Image = Image.FromFile("Super Mario - Duck Left.gif");
                    break;
                case 12:
                    Character.Image = Image.FromFile("Mario - Dead.gif");
                    break;
                default:
                    Character.Image = Image.FromFile("Super Mario.gif");
                    break;
            }
        }
    }
}

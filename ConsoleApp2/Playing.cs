using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace ConsoleApp2
{
    
    
    public partial class Form4 : Form
    {
        // WindowsMediaPlayer p;
        
       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        bool ballStolen = false;
        Thread th;
        bool shooting = false;
        double ballSpeed;
        double angle = 0;
        bool angleLock = false;
        
        public Form4()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();
            

            
            // initialize here >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            /*p = new WindowsMediaPlayer();
             p.URL = "fans.mp3";*/
            // p.SoundLocation = "fans.wav";
            //p.PlayLooping();

            if (Choose.g1.pcount==1)
            {
                pictureBox3.Image = ConsoleApp2.Properties.Resources.madried1;
            }
            if (Choose.g1.pcount == 2)
            {
                pictureBox3.Image = ConsoleApp2.Properties.Resources.barcelona;
            }
            if (Choose.g1.pcount == 3)
            {
                pictureBox3.Image = ConsoleApp2.Properties.Resources.bayren;
            }
            if (Choose.g1.pcount == 4)
            {
                pictureBox3.Image = ConsoleApp2.Properties.Resources.faisaly;
            }
            if (Choose.g1.pcount == 5)
            {
                pictureBox3.Image = ConsoleApp2.Properties.Resources.united;
            }
            if (Choose.g1.pcount == 6)
            {
                pictureBox3.Image = ConsoleApp2.Properties.Resources.milan;
                
            }
            ////////////////////////////////////////////////
            if (Choose.P1.pcount == 1)
            {
                pictureBox2.Image = ConsoleApp2.Properties.Resources.madried1;
            }
            if (Choose.P1.pcount == 2)
            {
                pictureBox2.Image = ConsoleApp2.Properties.Resources.barcelona;
            }
            if (Choose.P1.pcount == 3)
            {
                pictureBox2.Image = ConsoleApp2.Properties.Resources.bayren;
            }
            if (Choose.P1.pcount == 4)
            {
                pictureBox2.Image = ConsoleApp2.Properties.Resources.faisaly;
            }
            if (Choose.P1.pcount == 5)
            {
                pictureBox2.Image = ConsoleApp2.Properties.Resources.united;
            }
            if (Choose.P1.pcount == 6)
            {
                pictureBox2.Image = ConsoleApp2.Properties.Resources.milan;

            }





            if (Choose.g1.avt == "Hulk")
            {
                Goalie.Image = ConsoleApp2.Properties.Resources.Hulk;
            }
            else if (Choose.g1.avt == "Thanos") {
                Goalie.Image = ConsoleApp2.Properties.Resources.Thanos;
            }
            else if (Choose.g1.avt == "Frank")
            {
                Goalie.Image = ConsoleApp2.Properties.Resources.output_onlinepngtools__21_;
            }
            else if (Choose.g1.avt == "Terminator")
            {
                Goalie.Image = ConsoleApp2.Properties.Resources.output_onlinepngtools__22_;
            }

            if (Choose.P1.avt == "Batman")
            {
                PLayr_Avatar.Image = ConsoleApp2.Properties.Resources.Batman;
            }
            else if (Choose.P1.avt == "Deadpool") {
                PLayr_Avatar.Image = ConsoleApp2.Properties.Resources.Deadpool;
            }
            else if (Choose.P1.avt == "Thor")
            {
                PLayr_Avatar.Image = ConsoleApp2.Properties.Resources.Thor;
            }
            else if (Choose.P1.avt == "Ironman")
            {
                PLayr_Avatar.Image = ConsoleApp2.Properties.Resources.output_onlinepngtools__20_;
            }


        }
        bool A = false;
        bool D = false;
        bool UP = false;
        bool DOWN = false;
        bool RIGHT = false;
        bool LEFT = false;
        bool W = false;
        bool S = false;
        bool SPACE = false;
        int kicktime = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            goalieSpeed += Int32.Parse(label4.Text) % 2;
            if (ballStolen == false)
            {
                label7.Text = (Int32.Parse(label7.Text) - 1).ToString();
                if (shooting == false)
                {
                    if (kicktime == 10)
                    {
                        ballStolen = true;
                    }
                    kicktime++;
                }
                else if (shooting == true)
                {
                    label7.Text = 10.ToString();
                    kicktime = 0;
                }
                label4.Text = round.ToString();
                if (ballStolen == true)
                {
                    label6.Visible = true;
                }
                THE_TIME.Text = (Int32.Parse(THE_TIME.Text) - 1).ToString();

            }
            else

                Timer.Stop();
          
        }
        int round = 1;
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Right)
            {
                RIGHT = true;   
            }
            if (e.KeyData == Keys.Up)
            {
                UP = true;
            }
            if (e.KeyData == Keys.Down)
            {
                DOWN = true;
            }
            if (e.KeyData == Keys.Left)
            {
                LEFT = true;
            }
            if (e.KeyData == Keys.W)
            {
                W = true;
            }
            if (e.KeyData == Keys.S)
            {
                S = true;
            }
            if (e.KeyData == Keys.A)
            {
                A = true;
            }
            if (e.KeyData == Keys.D)
            {
                D = true;
            }

        }
        
        int goalieSpeed=3;
        Random s = new Random();
        private void GOALIEMOVE_Tick(object sender, EventArgs e)
        {
            if (Choose.goaliemode == "Human")
            {
                if (W == true && Goalie.Location.Y >= UpperPost.Location.Y)
                {
                    Goalie.Location = new Point(Goalie.Location.X, Goalie.Location.Y - goalieSpeed);
                }
                if (S == true && Goalie.Location.Y <= LowerPost.Location.Y - 50)
                {
                    Goalie.Location = new Point(Goalie.Location.X, Goalie.Location.Y + goalieSpeed);
                }
                if (A == true)
                {
                    Goalie.Location = new Point(Goalie.Location.X - 1, Goalie.Location.Y);
                }
                if (D == true)
                {
                    Goalie.Location = new Point(Goalie.Location.X + 1, Goalie.Location.Y);
                }
            }
            else if (Choose.goaliemode=="Cpu")
            {
                if(level3.Enabled && pictureBox1.Visible==true)
                {
                    Goalie.Location = new Point(pictureBox1.Location.X, Goalie.Location.Y);
                 
                }
                Goalie.Location = new Point(Goalie.Location.X , Goalie.Location.Y + goalieSpeed);
                if (Goalie.Bounds.IntersectsWith(panel9.Bounds))
                {
                    goalieSpeed = -1 * goalieSpeed;
                }
                else if(Goalie.Bounds.IntersectsWith(panel10.Bounds))
                {

                    goalieSpeed = -1 * goalieSpeed;
                }
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                RIGHT = false;
            }
            if (e.KeyData == Keys.Left)
            {
                LEFT = false;
            }
            if (e.KeyData == Keys.Up)
            {
                UP = false;
            }
            if (e.KeyData == Keys.Down)
            {
                DOWN = false;
            }
            if (e.KeyData == Keys.W)
            {
                W = false;
            }
            if (e.KeyData == Keys.S)
            {
                S = false;
            }
            if (e.KeyData == Keys.Space)
            {
               
                    SPACE = false;
                    shooting = true;
                    ballSpeed = POWERUPINSIDE.Width / 2;
                
            }
            if (e.KeyData == Keys.A)
            {
                A = false;
            }
            if (e.KeyData == Keys.D)
            {
                D = false;
            }

        }

        private void PlayerMove_Tick(object sender, EventArgs e)
        {
            if (Choose.playermode == "Cpu")
            {
                if (level3.Enabled && Boost.Visible == true)
                {
                    if (shooting == false)
                    {
                        PLayr_Avatar.Location = new Point(Boost.Location.X , PLayr_Avatar.Location.Y);
                    }
                    if (shooting == false)
                    {
                        PLayr_Avatar.Location = new Point(Boost.Location.X , PLayr_Avatar.Location.Y);
                    }
                }

            }
            else if (Choose.playermode == "Human")
            {
                if (RIGHT == true && shooting == false)
                {
                    PLayr_Avatar.Location = new Point(PLayr_Avatar.Location.X + 3, PLayr_Avatar.Location.Y);
                }
                if (LEFT == true && shooting == false)
                {
                    PLayr_Avatar.Location = new Point(PLayr_Avatar.Location.X - 3, PLayr_Avatar.Location.Y);
                }
            }
        }
        bool ballLDefaultTaken = false;
        Point DefaultLocation;
        Random cpuShoot = new Random();
        private void POWER_UP_Tick(object sender, EventArgs e)
        {
            if (Choose.playermode == "Cpu")
            {
                if (shooting == false)
                {
                   ballSpeed = cpuShoot.Next(30, POWERBAROUTSIDE.Width-40)/2;
                    shooting = true;
                    angle = cpuShoot.Next(-9, 6);
                }
                if (ballLDefaultTaken == false)
                {


                    DefaultLocation = Ball.Location;

                    ballLDefaultTaken = true;
                }

            }
            else if (Choose.playermode == "Human")
            {
                if (shooting != true)
                {
                    if (POWERUPINSIDE.Width >= POWERBAROUTSIDE.Width && shooting == false)
                    {
                        ballSpeed = POWERUPINSIDE.Width / 2;



                        shooting = true;

                    }
                    if (SPACE == true && shooting == false)
                    {
                        POWERUPINSIDE.Width += 1;

                    }


                    if (ballLDefaultTaken == false)
                    {


                        DefaultLocation = Ball.Location;

                        ballLDefaultTaken = true;
                    }
                }
            }
         
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Space)
            {
                SPACE = true;
            }
           

        }
        
        int count = 0;
        bool postHit=false;
        bool bulletHit = false;
        bool newAngle = false;
        Random newAngle1 = new Random();
        int fireball = 0;
        private void SHOT_ON_Tick(object sender, EventArgs e)
        {
            if (ballStolen == false)
            {
                if (fireBallRound == round && FireBall == true)
                {
                    fireball = 10;

                    Moving_Ball.Image = ConsoleApp2.Properties.Resources.Fireball;


                }

                if (Moving_Ball.Bounds.IntersectsWith(Black_Hole.Bounds) && Black_Hole.Visible == true)
                {
                    if (ATT_SCORE.Text == 0.ToString())
                    {

                    }
                    else ATT_SCORE.Text = (Convert.ToInt32(ATT_SCORE.Text) - 1).ToString();
                    kicktime = 0;

                    //ATT_SCORE.Text = (Int32.Parse(ATT_SCORE.Text) - 1).ToString();
                    shooting = false;
                    POWERUPINSIDE.Width = 1;
                    Moving_Ball.Location = DefaultLocation;
                    Moving_Ball.Hide();

                    Ball.Show();
                    angleLock = false;
                    angle = 0;
                    postHit = false;
                    bulletHit = false;
                    newAngle = false;
                    round++;
                    fireball = 0;
                    Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                }
                if (Bullet1.Bounds.IntersectsWith(Moving_Ball.Bounds) || Bullet2.Bounds.IntersectsWith(Moving_Ball.Bounds))
                {
                    shooting = false;
                    POWERUPINSIDE.Width = 1;
                    Moving_Ball.Location = DefaultLocation;
                    Moving_Ball.Hide();

                    Ball.Show();
                    angleLock = false;
                    angle = 0;
                    postHit = false;
                    bulletHit = false;
                    newAngle = false;
                    round++;
                    fireball = 0;
                    Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                    label7.Text = 10.ToString();
                   if (ATT_SCORE.Text == 0.ToString() )
                    {
                        
                    }
                    else ATT_SCORE.Text = (Convert.ToInt32(ATT_SCORE.Text) - 1).ToString();
                    kicktime = 0;
                }
                if (Moving_Ball.Bounds.IntersectsWith(MUD.Bounds) && MUD.Visible == true)
                {
                    bulletHit = true;

                }
                if (Moving_Ball.Bounds.IntersectsWith(LowerPost.Bounds))
                {
                    postHit = true;

                }
                if (Moving_Ball.Bounds.IntersectsWith(UpperPost.Bounds))
                {
                    postHit = true;
                }
                if (Int32.Parse(ATT_SCORE.Text) > 3)
                {
                    Lvl.Text = "Level 2";

                }
                if (Int32.Parse(ATT_SCORE.Text) > 6)
                {
                    Lvl.Text = "Level 3";

                }
                if (shooting == true)
                {
                    angleLock = true;
                }

                if (postHit == true && shooting == true)
                {
                    if (bulletHit == true)
                    {
                        if (newAngle == false)
                        {
                            angle = Math.Abs(angle + 10);

                            newAngle = true;
                        }


                        if (Moving_Ball.Bounds.IntersectsWith(Goalie.Bounds))
                        {
                            GK_SCORE.Text = (Int32.Parse(GK_SCORE.Text) + 1).ToString();
                            POWERUPINSIDE.Width = 1;
                            shooting = false;
                            Moving_Ball.Location = DefaultLocation;

                            Ball.Show();
                            angleLock = false;
                            angle = 0;
                            postHit = false;
                            newAngle = false;
                            round++;
                            fireball = 0;
                            Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;

                        }

                        if (Moving_Ball.Bounds.IntersectsWith(panel3.Bounds) || Moving_Ball.Bounds.IntersectsWith(panel4.Bounds) || Moving_Ball.Bounds.IntersectsWith(panel5.Bounds) || Moving_Ball.Bounds.IntersectsWith(panel7.Bounds))
                        {
                            shooting = false;
                            POWERUPINSIDE.Width = 1;
                            Moving_Ball.Location = DefaultLocation;
                            Moving_Ball.Hide();

                            Ball.Show();
                            angleLock = false;
                            angle = 0;
                            postHit = false;
                            bulletHit = false;
                            newAngle = false;
                            round++;
                            fireball = 0;
                            Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                        }



                        if (count < 3)
                        {
                            Moving_Ball.Location = new Point(Moving_Ball.Location.X + (int)(ballSpeed * 0.35) + fireball, (int)(Moving_Ball.Location.Y + (angle)));
                            count++;
                        }

                        else
                        {

                            Moving_Ball.Location = new Point(Moving_Ball.Location.X + (int)(ballSpeed * 0.35) + fireball, (int)(Moving_Ball.Location.Y));
                            count++;



                            count = 0;


                        }


                    }
                    else
                          if (Moving_Ball.Bounds.IntersectsWith(panel3.Bounds) || Moving_Ball.Bounds.IntersectsWith(panel4.Bounds) || Moving_Ball.Bounds.IntersectsWith(panel5.Bounds) || Moving_Ball.Bounds.IntersectsWith(panel7.Bounds))
                    {
                        shooting = false;
                        POWERUPINSIDE.Width = 1;
                        Moving_Ball.Location = DefaultLocation;
                        Moving_Ball.Hide();

                        Ball.Show();
                        angleLock = false;
                        angle = 0;
                        postHit = false;
                        bulletHit = false;
                        newAngle = false;
                        round++;
                        fireball = 0;
                        Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                    }
                    if (count < 3)
                    {
                        Moving_Ball.Location = new Point(Moving_Ball.Location.X + (int)(ballSpeed * 0.35 + fireball), (int)(Moving_Ball.Location.Y + (angle * -1)));
                        count++;
                    }

                    else
                    {

                        Moving_Ball.Location = new Point(Moving_Ball.Location.X + (int)(ballSpeed * 0.35 + fireball), (int)(Moving_Ball.Location.Y));
                        count++;

                        if (count > 2)
                        {
                            count = 0;
                        }

                    }



                }
                if (shooting == true && postHit == false)
                {
                    if (bulletHit == true)
                    {
                        if (newAngle == false)
                        {
                            angle = newAngle1.Next(-15, 15);

                            newAngle = true;
                        }
                    }
                    Ball.Hide();
                    Moving_Ball.Show();

                    if (ballStolen == false)
                    {

                        if (bulletHit == true)
                        {


                            if (count < 3)
                            {
                                Moving_Ball.Location = new Point(Moving_Ball.Location.X - (int)(ballSpeed * 0.35 + fireball), (int)(Moving_Ball.Location.Y + (angle)));
                                count++;
                            }

                            else
                            {

                                Moving_Ball.Location = new Point(Moving_Ball.Location.X - (int)(ballSpeed * 0.35 + fireball), (int)(Moving_Ball.Location.Y));
                                count++;

                                if (count > 2)
                                {
                                    count = 0;
                                }

                            }
                        }


                        else
                        {

                            Moving_Ball.Location = new Point(Moving_Ball.Location.X - (int)(ballSpeed * 0.35 + fireball), (int)(Moving_Ball.Location.Y));
                            count++;
                            if (count < 3)
                            {
                                Moving_Ball.Location = new Point(Moving_Ball.Location.X - (int)(ballSpeed * 0.35 + fireball), (int)(Moving_Ball.Location.Y + (angle * -1)));
                                count++;
                            }
                            if (count > 2)
                            {
                                count = 0;
                            }


                        }

                      }

                    if (Moving_Ball.Bounds.IntersectsWith(GoalLine.Bounds))
                    {
                        shooting = false;
                        ATT_SCORE.Text = (Int32.Parse(ATT_SCORE.Text) + 1).ToString();
                        POWERUPINSIDE.Width = 1;
                        //p.Stop();
                        WindowsMediaPlayer p2 = new WindowsMediaPlayer();
                        p2.URL = "goal.mp3";
                        p2.controls.play();
                       
                       


                        Moving_Ball.Location = DefaultLocation;
                        //p.Play();
                        Ball.Show();
                        angleLock = false;
                        angle = 0;

                        bulletHit = false;
                        newAngle = false;
                        round++;
                        fireball = 0;
                        Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                    }
                    if (Moving_Ball.Bounds.IntersectsWith(panel3.Bounds))
                    {
                        shooting = false;

                        POWERUPINSIDE.Width = 1;
                        Moving_Ball.Location = DefaultLocation;

                        Ball.Show();
                        angleLock = false;
                        angle = 0;
                        postHit = false;
                        bulletHit = false;
                        newAngle = false;
                        round++;
                        fireball = 0;
                        Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;

                    }
                    if (Moving_Ball.Bounds.IntersectsWith(panel4.Bounds))
                    {
                        shooting = false;
                        POWERUPINSIDE.Width = 1;
                        Moving_Ball.Location = DefaultLocation;


                        Ball.Show();
                        angleLock = false;
                        angle = 0;
                        postHit = false;
                        bulletHit = false;
                        newAngle = false;

                        round++;
                        fireball = 0;
                        Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;

                    }
                    if (Moving_Ball.Bounds.IntersectsWith(panel5.Bounds))
                    {
                        shooting = false;
                        POWERUPINSIDE.Width = 1;
                        Moving_Ball.Location = DefaultLocation;


                        Ball.Show();
                        angleLock = false;
                        angle = 0;
                        postHit = false;
                        bulletHit = false;
                        newAngle = false;
                        fireball = 0;
                        round++;
                        Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                    }
                    if (Moving_Ball.Bounds.IntersectsWith(Goalie.Bounds))
                    {
                        GK_SCORE.Text = (Int32.Parse(GK_SCORE.Text) + 1).ToString();
                        POWERUPINSIDE.Width = 1;
                        shooting = false;
                        Moving_Ball.Location = DefaultLocation;

                        Ball.Show();
                        angleLock = false;
                        angle = 0;
                        postHit = false;
                        bulletHit = false;
                        newAngle = false;
                        round++;
                        fireball = 0;
                        Moving_Ball.Image = ConsoleApp2.Properties.Resources.Ball2;
                    }
                }
            }
        }

        private void AngleTimer_Tick(object sender, EventArgs e)
        {

            if(UP==true && angleLock == false)
            {
                angle += 0.3;
            }
            if(DOWN==true && angleLock == false)
            {
                angle -= 0.3;
            }
            label3.Text = angle.ToString();
        }

        private void Back_Ground_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
      
       
        private void PikaTimer_Tick(object sender, EventArgs e)
        {



        }
        bool newGoalSize = false;
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        Point bullet1Loc;
        Point bullet2Loc;
        Random bulletspeed = new Random();
        private void Bullets_Tick(object sender, EventArgs e)
        {

            if (Int32.Parse(THE_TIME.Text) <= 0)
            {
                
                ballStolen = true;
                
          
                label6.Show();
                Timer.Stop();

            }
            if (Lvl.Text == "Level 2" || Lvl.Text == "Level 3")
            {
                if (newGoalSize == false)
                {
                    Goal.Size = new Size(231, 458);
                    Goal.Location = new Point(3, 152);
                    UpperPost.Location = new Point(34, 165);
                    LowerPost.Location = new Point(34, 574);
                    GoalLine.Location = new Point(136, 221);
                    GoalLine.Size = new Size(14, 327);
                    newGoalSize = true;
               
                }
                Tank2.Show();
                Tank1.Show();
                Bullet1.Show();
                Bullet2.Show();
                Bullet1.Location = new Point(Bullet1.Location.X, Bullet1.Location.Y + bulletspeed.Next(3,4));
                
                
                    Bullet2.Location = new Point(Bullet2.Location.X, Bullet2.Location.Y + bulletspeed.Next(4,7));
                
              if(Bullet1.Bounds.IntersectsWith(panel4.Bounds))
                {
                    Bullet1.Location = bullet1Loc;
                }
                if (Bullet2.Bounds.IntersectsWith(panel4.Bounds))
                {
                    Bullet2.Location = bullet2Loc;
                }
          if(Lvl.Text=="Level 3")
                {
                    level3.Start();
                }
            }
          
            
        }
        Random boostRandom = new Random();
        Random boostRandom1 = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            bullet1Loc = Bullet1.Location;
            bullet2Loc = Bullet2.Location;
            timer1.Stop();
        }

        
        int axisY = 1;
        bool FireBall = false;
        int fireBallRound;
        bool ggg = false;
        bool BoostlocTaken = false;

        Random r = new Random();
        Point boostDefaultloc;
        Point boost2Defaultloc;
        bool gggg = false;
       
        private void level3_Tick(object sender, EventArgs e)
        {
            Boost_timer.Enabled = true;
            Black_Hole.Show();
            MUD.Show();
            Black_Hole.Location = new Point(Black_Hole.Location.X, Black_Hole.Location.Y - axisY);
            if (Black_Hole.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                axisY *= -1;
            }
            if (Black_Hole.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                axisY *= -1;
            }

            if (BoostlocTaken == false)
            {
                boostDefaultloc = Boost.Location;
                boost2Defaultloc = pictureBox1.Location;
                Boost.Location = new Point(Boost.Location.X + r.Next(1, 200), Boost.Location.Y);
                pictureBox1.Location = new Point(pictureBox1.Location.X + r.Next(1, 100), pictureBox1.Location.Y);
                BoostlocTaken = true;
                
            }

            if (!Boost.Bounds.IntersectsWith(PLayr_Avatar.Bounds) && boost_player >= boostRandom.Next(6,10))
            {
                Boost.Show();
                Boost.Location = new Point(Boost.Location.X, Boost.Location.Y + 2);

            }
            if (!pictureBox1.Bounds.IntersectsWith(Goalie.Bounds) && boost_goalie >= boostRandom1.Next(12, 16))
            {
                pictureBox1.Show();
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);

            }
            if (Boost.Bounds.IntersectsWith(PLayr_Avatar.Bounds) && ggg == false)
            {
                Boost.Hide();
                Boost.Location = boostDefaultloc;
                
                FireBall = true;
                if (shooting)
                {
                    fireBallRound = Int32.Parse(label4.Text) + 1;
                }
                else if (!shooting)
                {
                    fireBallRound = Int32.Parse(label4.Text);
                }
                ggg = true;
                ggg = false;
                boost_player = 0;
            }
            if (pictureBox1.Bounds.IntersectsWith(Goalie.Bounds) && gggg == false)
            {
                boost_goalie = 0;
                pictureBox1.Hide();
                pictureBox1.Location = boost2Defaultloc;

                Goalie.Height = 150;
                gggg = true;
                gggg = false;
                Goalie_fat.Enabled = true;

            }

        }
        bool g = false;
        private void Prizes_Tick(object sender, EventArgs e)
        {

            if (ballStolen == true && g == false)
            {

                History h1 = new History();
                foreach (Profile p in Profile.Profiles)
                {
                    if (p.Type == "Player")
                        h1.player = p.Name;
                    else
                        h1.goalie = p.Name;
                }
                h1.player_score = Int32.Parse(ATT_SCORE.Text);
                h1.goalie_score = Int32.Parse(GK_SCORE.Text);
                h1.duration = 90 - Int32.Parse(THE_TIME.Text);
                h1.date = DateTime.Now;
                h1.goalie = Choose.g1.Name;
                h1.player = Choose.P1.Name;
                h1.gamescount++;

                History.historyList.Add(h1);
                
                label9.Visible = true;
                label9.Enabled = true;
                g = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form4());
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void history_Click(object sender, EventArgs e)
        {
            Historyform h = new Historyform();
            h.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            History h1 = new History();
            foreach (Profile p in Profile.Profiles)
            {
                if (p.Type == "Player")
                    h1.player = p.Name;
                else
                    h1.goalie = p.Name;
            }
            h1.player_score = Int32.Parse(ATT_SCORE.Text);
            h1.goalie_score = Int32.Parse(GK_SCORE.Text);
            h1.duration = 90 - Int32.Parse(THE_TIME.Text);
          
            History.historyList.Add(h1);
            Menu h = new Menu();
            h.Show();
            this.Dispose();
        }

      

        private void label9_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
           this.Dispose();
            
            
        }
        int goaliec = 0;
        bool ggggg = false;
        private void Goalie_fat_Tick(object sender, EventArgs e)
        {
            goaliec++;
            if (goaliec == 10 && ggggg == false)
            {
                Goalie.Height = 100;
                ggggg = true;
            }
        }

        private void PLayr_Avatar_Click(object sender, EventArgs e)
        {

        }

        private void Goalie_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Tank1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int boost_player = 0; int boost_goalie = 0;
        private void Boost_timer_Tick(object sender, EventArgs e)
        {
            boost_player++;
            boost_goalie++;
        }
    }
}

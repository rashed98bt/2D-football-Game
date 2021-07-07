using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace ConsoleApp2
{

    class Program
    {
        static SoundPlayer music = new SoundPlayer();

         public static void play()
        {

             music.SoundLocation = "Genius.wav";
            music.PlayLooping();
        }
        public static void stopplay()
        {
            music.Stop();
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading_screen_Form());

        }
    }
    public class Profile {
        public static List<Profile> Profiles = new List<Profile>();
        public string Name { set; get; }
        public string Gender { set; get; }
        public int age { set; get; }
        public string avt { set; get; }
        public string Type { set; get; }
        public int profilecount = Profiles.Count;
        public int pcount { set; get; }
        
        public override string ToString()
        {
            return string.Format("Name:{0} Gender:{1} Age:{2} Type:{3} Avatar:{4}"
                , this.Name, this.Gender, this.age,this.Type,this.avt);
        }

    }
    public class History 
    {
        public static List<History> historyList = new List<History>();
        public string player { set; get; }
        public string goalie { set; get; }
        public int player_score { set; get; }
        public int goalie_score { set; get; }
        public int duration { set; get; }
       
        public DateTime date { set; get; }
        public int gamescount = historyList.Count;

        public override string ToString()
        {
            return string.Format("Player: {0} Goalie: {1} PlayerScore: {2} GoalieScore: {3} Duration S: {4} Date: {5}"
                ,this.player,this.goalie,this.player_score,this.goalie_score,this.duration,this.date);
        }
    }
    

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder query = new StringBuilder();
        string[] players = new string[3];
        Dictionary<int, Tuple<string, double>> allPlayers = new Dictionary<int, Tuple<string, double>>();
        Random random = new Random();
        int lastTeam = 1;
        List<Player> playerList = new List<Player>();
        List<Player> eightToTen = new List<Player>();
        List<Player> sevenToEight = new List<Player>();
        List<Player> sixToSeven = new List<Player>();
        List<Player> fiveToSix = new List<Player>();

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddPlayer formAddPlayer = new FormAddPlayer();
                formAddPlayer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "addPlayer Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                query.Clear();
                query.Append("SELECT * FROM Table_Players");
                allPlayers = SQLProcess.GetPlayers(query.ToString());
                ListPlayers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "Load Error");
            }
        }

        private void ListPlayers()
        {
            try
            {
                foreach (var player in allPlayers.Values)
                {
                    players[1] = player.Item1;
                    players[2] = player.Item2.ToString();
                    listViewAllPlayers.Items.Add(new ListViewItem(players));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "List Players Error");
            }
        }

        private void buttonCreateSquad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAllPlayers.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < listViewAllPlayers.CheckedItems.Count; i++)
                    {
                        playerList.Add(
                            new Player
                            {
                                playerName = listViewAllPlayers.CheckedItems[i].SubItems[1].Text,
                                overall = double.Parse(listViewAllPlayers.CheckedItems[i].SubItems[2].Text),
                            });
                    }
                    playerList = playerList.OrderBy(x => random.Next()).ToList();
                    
                    for (int i = 0; i < playerList.Count; i++)
                    {
                        if (playerList[i].overall >= 8)
                        {
                            eightToTen.Add(
                                new Player
                                {
                                    playerName = playerList[i].playerName,
                                    overall = playerList[i].overall,
                                });
                        }
                        else if (playerList[i].overall >= 7)
                        {
                            sevenToEight.Add(
                               new Player
                               {
                                   playerName = playerList[i].playerName,
                                   overall = playerList[i].overall,
                               });
                        }
                        else if (playerList[i].overall >= 6)
                        {
                            sixToSeven.Add(
                               new Player
                               {
                                   playerName = playerList[i].playerName,
                                   overall = playerList[i].overall,
                               });
                        }
                        else if (playerList[i].overall >= 5)
                        {
                            fiveToSix.Add(
                               new Player
                               {
                                   playerName = playerList[i].playerName,
                                   overall = playerList[i].overall,
                               });
                        }
                    }

                    for (int i = 0; i < eightToTen.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(eightToTen[i].playerName);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(eightToTen[i].playerName);
                            lastTeam = 1;
                        }
                    }
                    for (int i = 0; i < sevenToEight.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(sevenToEight[i].playerName);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(sevenToEight[i].playerName);
                            lastTeam = 1;
                        }
                    }
                    for (int i = 0; i < sixToSeven.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(sixToSeven[i].playerName);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(sixToSeven[i].playerName);
                            lastTeam = 1;
                        }
                    }
                    for (int i = 0; i < fiveToSix.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(fiveToSix[i].playerName);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(fiveToSix[i].playerName);
                            lastTeam = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "Create Squad Error");
            }
        }

        private void checkBoxAllSelect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "All Select Error");
            }
        }
    }

    public class Player
    {
        public string playerName { get; set; }
        public double overall { get; set; }

    }
}

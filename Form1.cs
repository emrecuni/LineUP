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
        string[] players = new string[4];
        Dictionary<int, Tuple<string, string, int>> allPlayers = new Dictionary<int, Tuple<string, string, int>>();
        Random random = new Random();
        int index = 0;
        int lastTeam = 1;
        Dictionary<string, int> goalkeepers = new Dictionary<string, int>();
        Dictionary<string, int> defences = new Dictionary<string, int>();
        Dictionary<string, int> middlefielders = new Dictionary<string, int>();
        Dictionary<string, int> forwards = new Dictionary<string, int>();

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddPlayer formAddPlayer = new FormAddPlayer();
                formAddPlayer.ShowDialog();
                //listview'ı güncelle sürekli
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
                    players[2] = player.Item2;
                    players[3] = player.Item3.ToString();
                    listView1.Items.Add(new ListViewItem(players));
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
                if (listView1.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < listView1.CheckedItems.Count; i++)
                    {
                        //index = random.Next(listView1.CheckedItems.Count);
                        //if (!allPlayers.ContainsKey(index))
                        //{
                        //allPlayers.Add(index, Tuple.Create(listView1.CheckedItems[index].SubItems[1].Text, listView1.CheckedItems[index].SubItems[2].Text));
                        switch (listView1.CheckedItems[i].SubItems[2].Text)
                        {
                            case "Kaleci":
                                goalkeepers.Add(listView1.CheckedItems[i].SubItems[1].Text, int.Parse(listView1.CheckedItems[i].SubItems[3].Text));
                                break;
                            case "Defans":
                                defences.Add(listView1.CheckedItems[i].SubItems[1].Text, int.Parse(listView1.CheckedItems[i].SubItems[3].Text));
                                break;
                            case "Orta Saha":
                                middlefielders.Add(listView1.CheckedItems[i].SubItems[1].Text, int.Parse(listView1.CheckedItems[i].SubItems[3].Text));
                                break;
                            case "Forvet":
                                forwards.Add(listView1.CheckedItems[i].SubItems[1].Text, int.Parse(listView1.CheckedItems[i].SubItems[3].Text));
                                break;
                        }
                        //}
                        //else
                        //    i--;
                    }
                    goalkeepers = goalkeepers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


                    for (int i = 0; i < goalkeepers.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(goalkeepers[i]);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(goalkeepers[i]);
                            lastTeam = 1;
                        }
                    }
                    for (int i = 0; i < defences.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(defences[i]);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(defences[i]);
                            lastTeam = 1;
                        }
                    }
                    for (int i = 0; i < middlefielders.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(middlefielders[i]);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(middlefielders[i]);
                            lastTeam = 1;
                        }
                    }
                    for (int i = 0; i < forwards.Count; i++)
                    {
                        if (lastTeam == 1)
                        {
                            listBoxTeamA.Items.Add(forwards[i]);
                            lastTeam = 2;
                        }
                        else
                        {
                            listBoxTeamB.Items.Add(forwards[i]);
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
    }
}





/*try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "addPlayer Error");
            }*/
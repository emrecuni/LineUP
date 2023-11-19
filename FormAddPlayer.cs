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
    public partial class FormAddPlayer : Form
    {
        public FormAddPlayer()
        {
            InitializeComponent();
        }

        StringBuilder playerName = new StringBuilder();
        StringBuilder playerPosition = new StringBuilder();
        StringBuilder filePath = new StringBuilder();
        StringBuilder query = new StringBuilder();
        List<string> players = new List<string>();
        Dictionary<int, Tuple<string, string, int>> allPlayers = new Dictionary<int, Tuple<string, string, int>>();
        bool control = true;
        int playerOverall;

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != null && textBoxName.Text != string.Empty && comboBoxPosition.SelectedIndex != -1)
                {
                    players.Clear();
                    playerName.Clear();
                    playerPosition.Clear();
                    allPlayers.Clear();
                    query.Clear();

                    playerName.Append(textBoxName.Text);
                    playerPosition.Append(comboBoxPosition.SelectedItem.ToString());
                    playerOverall = int.Parse(numericUpDownOverall.Value.ToString());

                    query.Append("SELECT * FROM Table_Players");
                    allPlayers = SQLProcess.GetPlayers(query.ToString());

                    foreach (var player in allPlayers.Values)
                    {
                        if (player.Item1 == playerName.ToString() && player.Item2 == playerPosition.ToString())
                        {
                            MessageBox.Show("Var Olan Oyuncuyu Ekleyemezsiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            control = false;
                            break;
                        }
                    }

                    if (control)
                    {
                        query.Clear();
                        query.Append($"INSERT INTO Table_Players (playerName, position, overall) VALUES ('{playerName}','{playerPosition}',{playerOverall})");
                        if (SQLProcess.AddPlayer(query.ToString()))
                            MessageBox.Show($"{playerName} Başarıyla Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("İşlem Sırasında Bir Hata Oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //if (!File.Exists(filePath.ToString()))
                    //    File.Create(filePath.ToString()).Close();

                    //allPlayers = File.ReadAllLines(filePath.ToString());

                    //foreach (var player in allPlayers)
                    //{
                    //    players.Add(player);
                    //    if (player.Contains(playerName.ToString()) && player.Contains(playerPosition.ToString()))
                    //    {
                    //        MessageBox.Show("Var Olan Oyuncuyu Ekleyemezsiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //        control = false;                           
                    //    }
                    //}

                    //players.Add("Seç#" +playerName + "#" + playerPosition);

                    //if (control)
                    //{
                    //    File.WriteAllLines(filePath.ToString(), players);
                    //    MessageBox.Show("Oyuncu Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "addPlayer Error");
            }
        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            filePath.Clear();
            filePath.Append(Application.StartupPath + "\\oyuncular.txt");
        }
    }
}

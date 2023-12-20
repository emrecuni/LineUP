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
        StringBuilder query = new StringBuilder();
        List<string> players = new List<string>();
        Dictionary<int, Tuple< string, double>> allPlayers = new Dictionary<int, Tuple< string, double>>();
        bool control = true;
        int playerOverall;

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != null && textBoxName.Text != string.Empty) 
                {
                    players.Clear();
                    playerName.Clear();
                    allPlayers.Clear();
                    query.Clear();

                    playerName.Append(textBoxName.Text);
                    playerOverall = int.Parse(numericUpDownOverall.Value.ToString());

                    query.Append("SELECT * FROM Table_Players");
                    allPlayers = SQLProcess.GetPlayers(query.ToString());

                    foreach (var player in allPlayers.Values)
                    {
                        if (player.Item1 == playerName.ToString())
                        {
                            MessageBox.Show("Var Olan Oyuncuyu Ekleyemezsiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            control = false;
                            break;
                        }
                    }

                    if (control)
                    {
                        query.Clear();
                        query.Append($"INSERT INTO Table_Players (playerName,  overall) VALUES ('{playerName}', {playerOverall})");
                        if (SQLProcess.AddPlayer(query.ToString()))
                            MessageBox.Show($"{playerName} Başarıyla Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("İşlem Sırasında Bir Hata Oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "addPlayer Error");
            }
        }
    }
}

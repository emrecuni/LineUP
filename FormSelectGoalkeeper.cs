using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineUp
{
    public partial class FormSelectGoalkeeper : Form
    {
        public FormSelectGoalkeeper(List<Player> players)
        {
            InitializeComponent();
            playerList = players;
        }

        List<Player> playerList = new List<Player>();

        private void FormSelectGoalkeeper_Load(object sender, EventArgs e)
        {
            try
            {
                FillCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Load Error");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGoalkeeper1.SelectedIndex != -1 && comboBoxGoalkeeper2.SelectedIndex != -1 && comboBoxGoalkeeper1.SelectedIndex != comboBoxGoalkeeper2.SelectedIndex) // 2 farklı kaleci seçilip seçilmediğini kontrol eder
                {
                    Form1.goalkepers.Clear();
                    Form1.goalkepers.Add(comboBoxGoalkeeper1.SelectedItem.ToString());
                    Form1.goalkepers.Add(comboBoxGoalkeeper2.SelectedItem.ToString());
                    Close();
                }
                else if (comboBoxGoalkeeper1.SelectedIndex == comboBoxGoalkeeper2.SelectedIndex) // aynı 2 kaleci seçildiyse
                    MessageBox.Show("Lütfen İki Farklı Kaleci Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else // 2 kaleci seçilmediyse
                    MessageBox.Show("Lütfen İki Kaleciyi Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Save Error");
            }
        }

        private void comboBoxGoalkeepers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //FillCombobox();
            //    ComboBox comboBox = (ComboBox)sender;
            //    if (comboBox.Name.Contains("1"))
            //        comboBoxGoalkeeper2.Items.RemoveAt(comboBox.SelectedIndex);
            //    else
            //        comboBoxGoalkeeper1.Items.RemoveAt(comboBox.SelectedIndex);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "SelectedIndex Error");
            //}
        }

        private void FillCombobox()
        {
            try
            {
                comboBoxGoalkeeper1.Items.Clear();
                comboBoxGoalkeeper2.Items.Clear();

                for (int i = 0; i < playerList.Count; i++)
                {
                    comboBoxGoalkeeper1.Items.Add(playerList[i].playerName);
                    comboBoxGoalkeeper2.Items.Add(playerList[i].playerName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "FillCombobox Error");
            }
        }

        private void comboBoxGoalkeepers_Enter(object sender, EventArgs e)
        {
            //try
            //{
            //    FillCombobox();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Enter Error");
            //}
        }

        private void FormSelectGoalkeeper_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                    Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Enter Error");
            }
        }
    }
}

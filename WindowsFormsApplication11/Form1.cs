using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using Memory.Win32;
using Memory.Utils;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.TopMost = true;
            this.Show();
            timer2.Start();
        }

        MemoryHelper32 helper = null;
        Boolean isInBattle = false;
        uint targetHp = 0;
        string hpMax1 = "0";
        string hpMax2 = "0";
        string hpMax3 = "0";
        string hpMax4 = "0";
        int[] offset = { 0x5D0 };

        private void searchHealth()
        {
            if (Process.GetProcessesByName("FFX").Length != 0)
            {
                uint baseAddr = getBaseAddress();
                targetHp = MemoryUtils.OffsetCalculator(helper, baseAddr, offset);
                if (targetHp != 1488)
                {
                    hpMax1 = enableEnemyHealth(enemyAGroup, 0);
                    hpMax2 = enableEnemyHealth(enemyBGroup, 1);
                    hpMax3 = enableEnemyHealth(enemyCGroup, 2);
                    hpMax4 = enableEnemyHealth(enemyDGroup, 3);

                    if (isInBattle)
                    {
                        killAll.Visible = true;
                        timer1.Start();
                        timer2.Stop();
                    }
                }
            }
        }

        private string enableEnemyHealth(Panel group, uint position)
        {
            string hpMaxValue = "0";
            if (getEnemyHp(targetHp, position) != 0)
            {
                group.Visible = true;
                hpMaxValue = getEnemyHp(targetHp, position).ToString();
                // only in battle if an enemy is still alive
                isInBattle = true;
            }
            return hpMaxValue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hpBit1 = getEnemyHp(targetHp, 0);
            int hpBit2 = getEnemyHp(targetHp, 1);
            int hpBit3 = getEnemyHp(targetHp, 2);
            int hpBit4 = getEnemyHp(targetHp, 3);
            hpLabel.Text = hpBit1.ToString();
            hpLabel2.Text = hpBit2.ToString();
            hpLabel3.Text = hpBit3.ToString();
            hpLabel4.Text = hpBit4.ToString();
            increaseMaxHpsIfHealed(hpBit1, hpBit2, hpBit3, hpBit4);
            hpMaxLabel.Text = hpMax1;
            hpMaxLabel2.Text = hpMax2;
            hpMaxLabel3.Text = hpMax3;
            hpMaxLabel4.Text = hpMax4;
            hpBarConfig(hpBar, hpBit1, hpMax1);
            hpBarConfig(hpBar2, hpBit2, hpMax2);
            hpBarConfig(hpBar3, hpBit3, hpMax3);
            hpBarConfig(hpBar4, hpBit4, hpMax4);
            enemyAGroup.Visible = hpBit1 > 0;
            enemyBGroup.Visible = hpBit2 > 0;
            enemyCGroup.Visible = hpBit3 > 0;
            enemyDGroup.Visible = hpBit4 > 0;
            if (hpBit1 <= 0 && hpBit2 <= 0 && hpBit3 <= 0 && hpBit4 <= 0) {
                timer1.Stop();
                timer2.Start();
                hpMaxLabel.Text = "0";
                hpMaxLabel2.Text = "0";
                hpMaxLabel3.Text = "0";
                hpMaxLabel4.Text = "0";
                isInBattle = false;
                killAll.Visible = false;
            }
        }

        private void increaseMaxHpsIfHealed(int currentHp1, int currentHp2, int currentHp3, int currentHp4)
        {
            if(Convert.ToInt32(hpMax1) < currentHp1)
            {
                hpMax1 = currentHp1.ToString();
            }
            if (Convert.ToInt32(hpMax2) < currentHp2)
            {
                hpMax2 = currentHp2.ToString();
            }
            if (Convert.ToInt32(hpMax3) < currentHp3)
            {
                hpMax3 = currentHp3.ToString();
            }
            if (Convert.ToInt32(hpMax4) < currentHp4)
            {
                hpMax4 = currentHp4.ToString();
            }
        }

        private int getEnemyHp(uint firstEnemyMemoryPosition, uint enemyPosition)
        {
            byte[] HpInBytes = helper.ReadMemoryBytes(firstEnemyMemoryPosition + (3984 * enemyPosition), 4);
            return BitConverter.ToInt32(HpInBytes, 0);
        }

        private void hpBarConfig(ProgressBar healthBar, int hp, string hpMax)
        {
            healthBar.Maximum = Convert.ToInt32(hpMax);
            healthBar.Minimum = 0;
            if (hp > 0 && hp <= Convert.ToInt32(hpMax)) {
                healthBar.Value = hp;
            } else {
                healthBar.Value = 0;
            }
            if(hp > Convert.ToInt32(hpMax)) {
                healthBar.Maximum = hp;
                healthBar.Value = hp;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("FFX").Length != 0 && !isInBattle)
            {
                searchHealth();
            }
        }

        private void killEnemy(uint position)
        {
            uint targetMemPosition = MemoryUtils.OffsetCalculator(helper, getBaseAddress(), offset) + (3984 * position);
            helper.WriteMemory(targetMemPosition, 0);
        }

        private void killEnemy1_Click(object sender, EventArgs e)
        {
            killEnemy(0);
        }

        private void killEnemy2_Click(object sender, EventArgs e)
        {
            killEnemy(1);
        }

        private void killEnemy3_Click(object sender, EventArgs e)
        {
            killEnemy(2);
        }

        private void killEnemy4_Click(object sender, EventArgs e)
        {
            killEnemy(3);
        }

        private uint getBaseAddress()
        {
            Process process = Process.GetProcessesByName("FFX")[0];
            helper = new MemoryHelper32(process);
            uint baseAddr = helper.GetBaseAddress(0xD34460);
            return baseAddr;
        }

        private void killAll_Click(object sender, EventArgs e)
        {
            for (uint i = 0; i < 4; i++)
            {
                killEnemy(i);
            }
        }
    }
}

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

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr valor1);
        [DllImport("kernel32.dll")]
        public static extern Int32 WriteProcessMemory(IntPtr valor, IntPtr add, uint[] jk, UInt32 Size, IntPtr edk);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(UInt32 Addres, Int32 am, UInt32 ID);

        MemoryHelper32 helper = null;
        Boolean isInBattle = false;
        uint targetHp = 0;
        string hpMax1 = "0";
        string hpMax2 = "0";
        string hpMax3 = "0";
        string hpMax4 = "0";

        private void searchHealth()
        {
            if (Process.GetProcessesByName("FFX").Length != 0)
            {
                Process process = Process.GetProcessesByName("FFX")[0];
                helper = new MemoryHelper32(process);
                uint baseAddr1 = helper.GetBaseAddress(0xD34460);
                int[] offset = { 0x5D0 };
                targetHp = MemoryUtils.OffsetCalculator(helper, baseAddr1, offset);
                if (targetHp != 0)
                {
                    hpMax1 = getEnemyHp(targetHp, 0).ToString();
                    hpMax2 = getEnemyHp(targetHp, 1).ToString();
                    hpMax3 = getEnemyHp(targetHp, 2).ToString();
                    hpMax4 = getEnemyHp(targetHp, 3).ToString();

                    timer1.Start();
                    timer2.Stop();
                }
            }
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
            hpMaxLabel.Text = hpMax1;
            hpMaxLabel2.Text = hpMax2;
            hpMaxLabel3.Text = hpMax3;
            hpMaxLabel4.Text = hpMax4;
            hpBarConfig(hpBit1, hpMax1);
            hpBarConfig2(hpBit2, hpMax2);
            hpBarConfig3(hpBit3, hpMax3);
            hpBarConfig4(hpBit4, hpMax4);
            if (hpBit1 <= 0 && hpBit2 <= 0 && hpBit3 <= 0 && hpBit4 <= 0) {
                timer1.Stop();
                timer2.Start();
                hpMaxLabel.Text = "0";
                hpMaxLabel2.Text = "0";
                hpMaxLabel3.Text = "0";
                hpMaxLabel4.Text = "0";
                isInBattle = false;
            }
        }

        private int getEnemyHp(uint firstEnemyMemoryPosition, uint enemyPosition)
        {
            byte[] HpInBytes = helper.ReadMemoryBytes(firstEnemyMemoryPosition + (3984 * enemyPosition), 4);
            return BitConverter.ToInt32(HpInBytes, 0);
        }

        private void hpBarConfig(int hp, string hpMax)
        {
            hpBar.Maximum = Convert.ToInt32(hpMax);
            hpBar.Minimum = 0;
            if (hp > 0 && hp <= Convert.ToInt32(hpMax)) {
                hpBar.Value = hp;
            } else {
                hpBar.Value = 0;
            }
            if(hp > Convert.ToInt32(hpMax)) {
                hpBar.Maximum = hp;
                hpBar.Value = hp;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("FFX").Length != 0 && !isInBattle)
            {
                searchHealth();
            }
        }

        private void hpBarConfig2(int hp, string hpMax)
        {
            hpBar2.Maximum = Convert.ToInt32(hpMax);
            hpBar2.Minimum = 0;
            if (hp > 0 && hp <= Convert.ToInt32(hpMax))
            {
                hpBar2.Value = hp;
            }
            else
            {
                hpBar2.Value = 0;
            }
            if (hp > Convert.ToInt32(hpMax))
            {
                hpBar2.Maximum = hp;
                hpBar2.Value = hp;
            }
        }

        private void hpBarConfig3(int hp, string hpMax)
        {
            hpBar3.Maximum = Convert.ToInt32(hpMax);
            hpBar3.Minimum = 0;
            if (hp > 0 && hp <= Convert.ToInt32(hpMax))
            {
                hpBar3.Value = hp;
            }
            else
            {
                hpBar3.Value = 0;
            }
            if (hp > Convert.ToInt32(hpMax))
            {
                hpBar3.Maximum = hp;
                hpBar3.Value = hp;
            }
        }

        private void hpBarConfig4(int hp, string hpMax)
        {
            hpBar4.Maximum = Convert.ToInt32(hpMax);
            hpBar4.Minimum = 0;
            if (hp > 0 && hp <= Convert.ToInt32(hpMax))
            {
                hpBar4.Value = hp;
            }
            else
            {
                hpBar4.Value = 0;
            }
            if (hp > Convert.ToInt32(hpMax))
            {
                hpBar4.Maximum = hp;
                hpBar4.Value = hp;
            }
        }
    }
}
